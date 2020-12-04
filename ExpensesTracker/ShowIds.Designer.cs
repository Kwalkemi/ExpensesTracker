namespace ExpensesTracker
{
    partial class ShowIds
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
            this.dataGridViewShow = new System.Windows.Forms.DataGridView();
            this.lOGININFOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registration_TrackerDataset = new ExpensesTracker.DataSet.Registration_TrackerDataset();
            this.lOGIN_INFOTableAdapter = new ExpensesTracker.DataSet.Registration_TrackerDatasetTableAdapters.LOGIN_INFOTableAdapter();
            this.lOGININFOIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASSWORDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRSTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gENDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGININFOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registration_TrackerDataset)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShow
            // 
            this.dataGridViewShow.AutoGenerateColumns = false;
            this.dataGridViewShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lOGININFOIDDataGridViewTextBoxColumn,
            this.uSERNAMEDataGridViewTextBoxColumn,
            this.pASSWORDDataGridViewTextBoxColumn,
            this.fIRSTNAMEDataGridViewTextBoxColumn,
            this.lASTNAMEDataGridViewTextBoxColumn,
            this.gENDERDataGridViewTextBoxColumn});
            this.dataGridViewShow.DataSource = this.lOGININFOBindingSource;
            this.dataGridViewShow.Location = new System.Drawing.Point(12, 31);
            this.dataGridViewShow.Name = "dataGridViewShow";
            this.dataGridViewShow.RowHeadersWidth = 51;
            this.dataGridViewShow.RowTemplate.Height = 24;
            this.dataGridViewShow.Size = new System.Drawing.Size(551, 311);
            this.dataGridViewShow.TabIndex = 0;
            this.dataGridViewShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lOGININFOBindingSource
            // 
            this.lOGININFOBindingSource.DataMember = "LOGIN_INFO";
            this.lOGININFOBindingSource.DataSource = this.registration_TrackerDataset;
            // 
            // registration_TrackerDataset
            // 
            this.registration_TrackerDataset.DataSetName = "Registration_TrackerDataset";
            this.registration_TrackerDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOGIN_INFOTableAdapter
            // 
            this.lOGIN_INFOTableAdapter.ClearBeforeFill = true;
            // 
            // lOGININFOIDDataGridViewTextBoxColumn
            // 
            this.lOGININFOIDDataGridViewTextBoxColumn.DataPropertyName = "LOGIN_INFO_ID";
            this.lOGININFOIDDataGridViewTextBoxColumn.HeaderText = "LOGIN_INFO_ID";
            this.lOGININFOIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lOGININFOIDDataGridViewTextBoxColumn.Name = "lOGININFOIDDataGridViewTextBoxColumn";
            this.lOGININFOIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.lOGININFOIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // uSERNAMEDataGridViewTextBoxColumn
            // 
            this.uSERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn.HeaderText = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uSERNAMEDataGridViewTextBoxColumn.Name = "uSERNAMEDataGridViewTextBoxColumn";
            // 
            // pASSWORDDataGridViewTextBoxColumn
            // 
            this.pASSWORDDataGridViewTextBoxColumn.DataPropertyName = "PASSWORD";
            this.pASSWORDDataGridViewTextBoxColumn.HeaderText = "PASSWORD";
            this.pASSWORDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pASSWORDDataGridViewTextBoxColumn.Name = "pASSWORDDataGridViewTextBoxColumn";
            // 
            // fIRSTNAMEDataGridViewTextBoxColumn
            // 
            this.fIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRST_NAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.fIRSTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fIRSTNAMEDataGridViewTextBoxColumn.Name = "fIRSTNAMEDataGridViewTextBoxColumn";
            // 
            // lASTNAMEDataGridViewTextBoxColumn
            // 
            this.lASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LAST_NAME";
            this.lASTNAMEDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lASTNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lASTNAMEDataGridViewTextBoxColumn.Name = "lASTNAMEDataGridViewTextBoxColumn";
            // 
            // gENDERDataGridViewTextBoxColumn
            // 
            this.gENDERDataGridViewTextBoxColumn.DataPropertyName = "GENDER";
            this.gENDERDataGridViewTextBoxColumn.HeaderText = "GENDER";
            this.gENDERDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gENDERDataGridViewTextBoxColumn.Name = "gENDERDataGridViewTextBoxColumn";
            this.gENDERDataGridViewTextBoxColumn.Visible = false;
            // 
            // ShowIds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 352);
            this.Controls.Add(this.dataGridViewShow);
            this.Name = "ShowIds";
            this.Text = "ShowIds";
            this.Load += new System.EventHandler(this.ShowIds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGININFOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registration_TrackerDataset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShow;
        private DataSet.Registration_TrackerDataset registration_TrackerDataset;
        private System.Windows.Forms.BindingSource lOGININFOBindingSource;
        private DataSet.Registration_TrackerDatasetTableAdapters.LOGIN_INFOTableAdapter lOGIN_INFOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lOGININFOIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSWORDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gENDERDataGridViewTextBoxColumn;
    }
}