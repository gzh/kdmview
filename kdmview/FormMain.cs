using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.IsolatedStorage;

using System.Xml;

namespace kdmview
{
    public partial class FormMain : Form
    {
        XmlNamespaceManager nsm = new XmlNamespaceManager(new NameTable());
        IsolatedStorageFile isoStore;
        public FormMain()
        {
            nsm.AddNamespace("etm", "http://www.smpte-ra.org/schemas/430-3/2006/ETM");
            nsm.AddNamespace("kdm", "http://www.smpte-ra.org/schemas/430-1/2006/KDM");

            isoStore = IsolatedStorageFile.GetStore(IsolatedStorageScope.Machine | IsolatedStorageScope.Assembly, 
                null, null);
            if (isoStore.FileExists("selectedPath.txt"))
            {
                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("selectedPath.txt", FileMode.Open, isoStore))
                {
                    using (StreamReader reader = new StreamReader(isoStream))
                    {
                        this.selectedPath = reader.ReadLine();
                    }
                }
            }

            InitializeComponent();

            reload();
        }

        FileSystemWatcher fsw=null;

        private void Fsw_Deleted(object sender, FileSystemEventArgs e)
        {
            this.BeginInvoke(new Action(delegate ()
            {
                foreach (var r in this.kdmDataSet.kdMessages.Select("Filename = '" + e.FullPath + "'"))
                {
                    r.Delete();
                }
            }));
        }

        private void Fsw_Renamed(object sender, RenamedEventArgs e)
        {
            this.BeginInvoke(new Action(delegate ()
            {
                foreach (var r in this.kdmDataSet.kdMessages.Select("Filename = '" + e.OldFullPath + "'"))
                {
                    r.Delete();
                }
                if (e.FullPath.StartsWith(this.selectedPath))
                {
                    loadFile(e.FullPath);
                }
            }));
        }

        private void Fsw_Created(object sender, FileSystemEventArgs e)
        {
            this.BeginInvoke(new Action(delegate () {
                loadFile(e.FullPath);
            }));
        }

        private string selectedPath=null;

        private void toolStripOpenFolder_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            var res = dlg.ShowDialog();
            if (res != DialogResult.OK)
                return;
            this.selectedPath = dlg.SelectedPath;
            this.reload();

            using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("selectedPath.txt", FileMode.Create, isoStore))
            {
                using (StreamWriter writer = new StreamWriter(isoStream))
                {
                    writer.WriteLine(this.selectedPath);
                }
            }
        }
        private void reload()
        {
            if (string.IsNullOrEmpty(this.selectedPath))
                return;
            if (!Directory.Exists(this.selectedPath))
            {
                MessageBox.Show("Selected folder " + this.selectedPath + " does not exist.");
                return;
            }
            this.kdmDataSet.Clear();

            loadAliases();

            var files = Directory.EnumerateFiles(this.selectedPath, "*.xml");
            foreach(var f in files)
            {
                loadFile(f);
            }

            setFileWatcher();

            this.Text = "kdmview :: " + this.selectedPath;
        }
        void setFileWatcher()
        {
            if (this.fsw != null)
            {
                this.fsw.Dispose();
            }
            fsw = new FileSystemWatcher();
            this.fsw.Filter = "*.xml";
            this.fsw.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
           | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            this.fsw.Path = selectedPath;

            fsw.Created += Fsw_Created;
            fsw.Deleted += Fsw_Deleted;
            fsw.Renamed += Fsw_Renamed;

            fsw.EnableRaisingEvents = true;
        }

        private void loadFile(string filename)
        {
            if (!WaitForFile(filename))
                return;
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filename);

                XmlNode root = doc.DocumentElement.SelectSingleNode("descendant::etm:AuthenticatedPublic", nsm);
                this.addRow(filename, root);
            }
            catch
            {

            }
        }
        private void addRow(string filename, XmlNode root)
        {
            Guid messageId;
            string annotationText;
            string contentTitleText;
            DateTime notValidBefore;
            DateTime notValidAfter;
            string recipientSubject;
            string recipientSubjectAlias;
            bool expired;

            messageId = Guid.Parse(root.SelectSingleNode("descendant::etm:MessageId", nsm).InnerText.Substring(9));
            annotationText = root.SelectSingleNode("descendant::etm:AnnotationText", nsm).InnerText;
            XmlNode e = root.SelectSingleNode("descendant::etm:RequiredExtensions/kdm:KDMRequiredExtensions", nsm);
            contentTitleText = e.SelectSingleNode("descendant::kdm:ContentTitleText", nsm).InnerText;
            notValidBefore = DateTime.Parse(e.SelectSingleNode("descendant::kdm:ContentKeysNotValidBefore", nsm).InnerText);
            notValidAfter = DateTime.Parse(e.SelectSingleNode("descendant::kdm:ContentKeysNotValidAfter", nsm).InnerText);

            recipientSubject = root.SelectSingleNode("descendant::kdm:Recipient/kdm:X509SubjectName", nsm).InnerText;

            expired = notValidAfter < DateTime.UtcNow;
            recipientSubjectAlias = recipientSubject;
            var rs = kdmDataSet.RecipientAlias.Select("Recipient = '" + recipientSubject + "'");
            if (rs.Length > 0)
            {
                try
                {
                    string a = (rs[0] as KdmDataSet.RecipientAliasRow).Alias;
                    if (!string.IsNullOrEmpty(a))
                        recipientSubjectAlias = a;
                }
                catch
                {

                }
            }

            this.kdmDataSet.kdMessages.AddkdMessagesRow(messageId, annotationText, contentTitleText,
                notValidBefore, notValidAfter, recipientSubject, filename, Path.GetFileName(filename), recipientSubjectAlias, expired);
        }
        bool WaitForFile(string fullPath)
        {
            int numTries = 0;
            while (true)
            {
                ++numTries;
                try
                {
                    using (FileStream fs = new FileStream(fullPath,
                        FileMode.Open, FileAccess.ReadWrite,
                        FileShare.None, 100))
                    {
                        fs.ReadByte();
                        break;
                    }
                }
                catch (Exception ex)
                {
                    if (numTries > 10)
                    {
                        return false;
                    }
                    System.Threading.Thread.Sleep(500);
                }
            }
            return true;
        }

        private void loadAliases()
        {
            if (isoStore.FileExists("RecipientAliases.xml"))
            {
                using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("RecipientAliases.xml", FileMode.Open, isoStore))
                {
                    try
                    {
                        this.kdmDataSet.RecipientAlias.ReadXml(isoStream);
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show("An error occured while reading the recipient aliases: " + e.ToString());
                    }
                }
            }
        }

        private void toolStripRemove_Click(object sender, EventArgs e)
        {
            removeSelected();
        }
        private void removeSelected()
        {
            foreach (DataGridViewRow r in this.dataGridView.SelectedRows)
            {
                var x = (r.DataBoundItem as System.Data.DataRowView).Row as kdmview.KdmDataSet.kdMessagesRow;
                string trashcan = selectedPath + "\\.kdmview.trashcan\\";
                if (!Directory.Exists(trashcan))
                {
                    Directory.CreateDirectory(trashcan);
                }
                var backupname = trashcan + Path.GetFileName(x.Filename);
                if (!File.Exists(backupname))
                    File.Move(x.Filename, backupname);
                else
                    File.Delete(x.Filename);
            }
        }

        private void toolStripEditAliases_Click(object sender, EventArgs e)
        {
            foreach(var x in kdmDataSet.kdMessages.Rows)
            {
                string s = (x as KdmDataSet.kdMessagesRow).RecipientSubject;
                if (kdmDataSet.RecipientAlias.Select("Recipient = '" + s + "'").Length==0)
                {
                    kdmDataSet.RecipientAlias.AddRecipientAliasRow(s, null);
                }
            }
            FormAliases fa = new FormAliases(this.kdmDataSet);
            
            fa.ShowDialog();
            using (IsolatedStorageFileStream isoStream = new IsolatedStorageFileStream("RecipientAliases.xml", FileMode.Create, isoStore))
            {
                this.kdmDataSet.RecipientAlias.WriteXml(isoStream);
            }
            reload();
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                removeSelected();
            }
            if (e.KeyCode == Keys.Space)
            {
                this.dataGridView.CurrentRow.Selected = !this.dataGridView.CurrentRow.Selected;
            }
        }
    }
}
