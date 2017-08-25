namespace kdmview
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripOpenFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripEditAliases = new System.Windows.Forms.ToolStripButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.contentTitleTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipientSubjectAliasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contentKeysNotValidBeforeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentKeysNotValidAfterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filenameShortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdMessagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kdmDataSet = new kdmview.KdmDataSet();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdMessagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdmDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOpenFolder,
            this.toolStripRemove,
            this.toolStripSeparator1,
            this.toolStripEditAliases});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripOpenFolder
            // 
            this.toolStripOpenFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.toolStripOpenFolder, "toolStripOpenFolder");
            this.toolStripOpenFolder.Name = "toolStripOpenFolder";
            this.toolStripOpenFolder.Click += new System.EventHandler(this.toolStripOpenFolder_Click);
            // 
            // toolStripRemove
            // 
            this.toolStripRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.toolStripRemove, "toolStripRemove");
            this.toolStripRemove.Name = "toolStripRemove";
            this.toolStripRemove.Click += new System.EventHandler(this.toolStripRemove_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripEditAliases
            // 
            this.toolStripEditAliases.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripEditAliases.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.toolStripEditAliases, "toolStripEditAliases");
            this.toolStripEditAliases.Name = "toolStripEditAliases";
            this.toolStripEditAliases.Click += new System.EventHandler(this.toolStripEditAliases_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contentTitleTextDataGridViewTextBoxColumn,
            this.recipientSubjectAliasDataGridViewTextBoxColumn,
            this.expiredDataGridViewCheckBoxColumn,
            this.contentKeysNotValidBeforeDataGridViewTextBoxColumn,
            this.contentKeysNotValidAfterDataGridViewTextBoxColumn,
            this.filenameShortDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.kdMessagesBindingSource;
            resources.ApplyResources(this.dataGridView, "dataGridView");
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // contentTitleTextDataGridViewTextBoxColumn
            // 
            this.contentTitleTextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.contentTitleTextDataGridViewTextBoxColumn.DataPropertyName = "ContentTitleText";
            resources.ApplyResources(this.contentTitleTextDataGridViewTextBoxColumn, "contentTitleTextDataGridViewTextBoxColumn");
            this.contentTitleTextDataGridViewTextBoxColumn.Name = "contentTitleTextDataGridViewTextBoxColumn";
            this.contentTitleTextDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recipientSubjectAliasDataGridViewTextBoxColumn
            // 
            this.recipientSubjectAliasDataGridViewTextBoxColumn.DataPropertyName = "RecipientSubjectAlias";
            resources.ApplyResources(this.recipientSubjectAliasDataGridViewTextBoxColumn, "recipientSubjectAliasDataGridViewTextBoxColumn");
            this.recipientSubjectAliasDataGridViewTextBoxColumn.Name = "recipientSubjectAliasDataGridViewTextBoxColumn";
            this.recipientSubjectAliasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expiredDataGridViewCheckBoxColumn
            // 
            this.expiredDataGridViewCheckBoxColumn.DataPropertyName = "Expired";
            resources.ApplyResources(this.expiredDataGridViewCheckBoxColumn, "expiredDataGridViewCheckBoxColumn");
            this.expiredDataGridViewCheckBoxColumn.Name = "expiredDataGridViewCheckBoxColumn";
            this.expiredDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // contentKeysNotValidBeforeDataGridViewTextBoxColumn
            // 
            this.contentKeysNotValidBeforeDataGridViewTextBoxColumn.DataPropertyName = "ContentKeysNotValidBefore";
            resources.ApplyResources(this.contentKeysNotValidBeforeDataGridViewTextBoxColumn, "contentKeysNotValidBeforeDataGridViewTextBoxColumn");
            this.contentKeysNotValidBeforeDataGridViewTextBoxColumn.Name = "contentKeysNotValidBeforeDataGridViewTextBoxColumn";
            this.contentKeysNotValidBeforeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contentKeysNotValidAfterDataGridViewTextBoxColumn
            // 
            this.contentKeysNotValidAfterDataGridViewTextBoxColumn.DataPropertyName = "ContentKeysNotValidAfter";
            resources.ApplyResources(this.contentKeysNotValidAfterDataGridViewTextBoxColumn, "contentKeysNotValidAfterDataGridViewTextBoxColumn");
            this.contentKeysNotValidAfterDataGridViewTextBoxColumn.Name = "contentKeysNotValidAfterDataGridViewTextBoxColumn";
            this.contentKeysNotValidAfterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filenameShortDataGridViewTextBoxColumn
            // 
            this.filenameShortDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.filenameShortDataGridViewTextBoxColumn.DataPropertyName = "FilenameShort";
            resources.ApplyResources(this.filenameShortDataGridViewTextBoxColumn, "filenameShortDataGridViewTextBoxColumn");
            this.filenameShortDataGridViewTextBoxColumn.Name = "filenameShortDataGridViewTextBoxColumn";
            this.filenameShortDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kdMessagesBindingSource
            // 
            this.kdMessagesBindingSource.DataMember = "kdMessages";
            this.kdMessagesBindingSource.DataSource = this.kdmDataSet;
            // 
            // kdmDataSet
            // 
            this.kdmDataSet.DataSetName = "KdmDataSet";
            this.kdmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormMain";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdMessagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdmDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripOpenFolder;
        private System.Windows.Forms.ToolStripButton toolStripRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripEditAliases;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource kdMessagesBindingSource;
        private KdmDataSet kdmDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentTitleTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipientSubjectAliasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn expiredDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentKeysNotValidBeforeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentKeysNotValidAfterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filenameShortDataGridViewTextBoxColumn;
    }
}

