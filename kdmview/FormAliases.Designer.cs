namespace kdmview
{
    partial class FormAliases
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aliasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recipientAliasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            if(null==this.kdmDataSet)
                this.kdmDataSet = new kdmview.KdmDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipientAliasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdmDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aliasDataGridViewTextBoxColumn,
            this.recipientDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.recipientAliasBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(940, 208);
            this.dataGridView1.TabIndex = 0;
            // 
            // aliasDataGridViewTextBoxColumn
            // 
            this.aliasDataGridViewTextBoxColumn.DataPropertyName = "Alias";
            this.aliasDataGridViewTextBoxColumn.HeaderText = "Alias";
            this.aliasDataGridViewTextBoxColumn.Name = "aliasDataGridViewTextBoxColumn";
            // 
            // recipientDataGridViewTextBoxColumn
            // 
            this.recipientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.recipientDataGridViewTextBoxColumn.DataPropertyName = "Recipient";
            this.recipientDataGridViewTextBoxColumn.HeaderText = "Recipient";
            this.recipientDataGridViewTextBoxColumn.Name = "recipientDataGridViewTextBoxColumn";
            this.recipientDataGridViewTextBoxColumn.ReadOnly = true;
            this.recipientDataGridViewTextBoxColumn.Width = 77;
            // 
            // recipientAliasBindingSource
            // 
            this.recipientAliasBindingSource.DataMember = "RecipientAlias";
            this.recipientAliasBindingSource.DataSource = this.kdmDataSet;
            // 
            // kdmDataSet
            // 
            this.kdmDataSet.DataSetName = "KdmDataSet";
            this.kdmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormAliases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 208);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAliases";
            this.ShowInTaskbar = false;
            this.Text = "Aliases for KDM Recipient Subject";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipientAliasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdmDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aliasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recipientDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource recipientAliasBindingSource;
        private KdmDataSet kdmDataSet;
    }
}