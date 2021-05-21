namespace ExpensesTracker.Project.Assets
{
    partial class Assets
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
            this.gridViewAsset = new System.Windows.Forms.DataGridView();
            this.aSSETDETAILIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSSETHEADERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSSETDESCIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSSETAMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aSSETPROCEDUREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assets1 = new ExpensesTracker.DataSet.Assets();
            this.lblDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAssetUpdate = new System.Windows.Forms.Button();
            this.btnAssetInsert = new System.Windows.Forms.Button();
            this.txtAssetAmt = new System.Windows.Forms.TextBox();
            this.lblAssetAmt = new System.Windows.Forms.Label();
            this.txtAssetDesc = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblFinalAssetValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aSSET_PROCEDURETableAdapter1 = new ExpensesTracker.DataSet.AssetsTableAdapters.ASSET_PROCEDURETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAsset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSETPROCEDUREBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assets1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewAsset
            // 
            this.gridViewAsset.AutoGenerateColumns = false;
            this.gridViewAsset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewAsset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewAsset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aSSETDETAILIDDataGridViewTextBoxColumn,
            this.aSSETHEADERIDDataGridViewTextBoxColumn,
            this.aSSETDESCIPTIONDataGridViewTextBoxColumn,
            this.aSSETAMOUNTDataGridViewTextBoxColumn});
            this.gridViewAsset.DataSource = this.aSSETPROCEDUREBindingSource;
            this.gridViewAsset.Location = new System.Drawing.Point(261, 102);
            this.gridViewAsset.Name = "gridViewAsset";
            this.gridViewAsset.RowHeadersWidth = 51;
            this.gridViewAsset.RowTemplate.Height = 24;
            this.gridViewAsset.Size = new System.Drawing.Size(650, 429);
            this.gridViewAsset.TabIndex = 0;
            this.gridViewAsset.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewAsset_CellClick);
            this.gridViewAsset.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridViewAsset_RowPostPaint);
            // 
            // aSSETDETAILIDDataGridViewTextBoxColumn
            // 
            this.aSSETDETAILIDDataGridViewTextBoxColumn.DataPropertyName = "ASSET_DETAIL_ID";
            this.aSSETDETAILIDDataGridViewTextBoxColumn.HeaderText = "ASSET_DETAIL_ID";
            this.aSSETDETAILIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aSSETDETAILIDDataGridViewTextBoxColumn.Name = "aSSETDETAILIDDataGridViewTextBoxColumn";
            this.aSSETDETAILIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aSSETHEADERIDDataGridViewTextBoxColumn
            // 
            this.aSSETHEADERIDDataGridViewTextBoxColumn.DataPropertyName = "ASSET_HEADER_ID";
            this.aSSETHEADERIDDataGridViewTextBoxColumn.HeaderText = "ASSET_HEADER_ID";
            this.aSSETHEADERIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aSSETHEADERIDDataGridViewTextBoxColumn.Name = "aSSETHEADERIDDataGridViewTextBoxColumn";
            this.aSSETHEADERIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // aSSETDESCIPTIONDataGridViewTextBoxColumn
            // 
            this.aSSETDESCIPTIONDataGridViewTextBoxColumn.DataPropertyName = "ASSET_DESCIPTION";
            this.aSSETDESCIPTIONDataGridViewTextBoxColumn.HeaderText = "ASSET_DESCIPTION";
            this.aSSETDESCIPTIONDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aSSETDESCIPTIONDataGridViewTextBoxColumn.Name = "aSSETDESCIPTIONDataGridViewTextBoxColumn";
            // 
            // aSSETAMOUNTDataGridViewTextBoxColumn
            // 
            this.aSSETAMOUNTDataGridViewTextBoxColumn.DataPropertyName = "ASSET_AMOUNT";
            this.aSSETAMOUNTDataGridViewTextBoxColumn.HeaderText = "ASSET_AMOUNT";
            this.aSSETAMOUNTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aSSETAMOUNTDataGridViewTextBoxColumn.Name = "aSSETAMOUNTDataGridViewTextBoxColumn";
            // 
            // aSSETPROCEDUREBindingSource
            // 
            this.aSSETPROCEDUREBindingSource.DataMember = "ASSET_PROCEDURE";
            this.aSSETPROCEDUREBindingSource.DataSource = this.assets1;
            // 
            // assets1
            // 
            this.assets1.DataSetName = "Assets";
            this.assets1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescription.Location = new System.Drawing.Point(34, 39);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(147, 23);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Asset Description";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.btnAssetUpdate);
            this.panel1.Controls.Add(this.btnAssetInsert);
            this.panel1.Controls.Add(this.txtAssetAmt);
            this.panel1.Controls.Add(this.lblAssetAmt);
            this.panel1.Controls.Add(this.txtAssetDesc);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Location = new System.Drawing.Point(23, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 429);
            this.panel1.TabIndex = 7;
            // 
            // btnAssetUpdate
            // 
            this.btnAssetUpdate.BackColor = System.Drawing.Color.MistyRose;
            this.btnAssetUpdate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnAssetUpdate.Location = new System.Drawing.Point(40, 328);
            this.btnAssetUpdate.Name = "btnAssetUpdate";
            this.btnAssetUpdate.Size = new System.Drawing.Size(143, 44);
            this.btnAssetUpdate.TabIndex = 8;
            this.btnAssetUpdate.Text = "Update";
            this.btnAssetUpdate.UseVisualStyleBackColor = false;
            this.btnAssetUpdate.Click += new System.EventHandler(this.btnAssetUpdate_Click);
            // 
            // btnAssetInsert
            // 
            this.btnAssetInsert.BackColor = System.Drawing.Color.MistyRose;
            this.btnAssetInsert.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnAssetInsert.Location = new System.Drawing.Point(38, 267);
            this.btnAssetInsert.Name = "btnAssetInsert";
            this.btnAssetInsert.Size = new System.Drawing.Size(143, 44);
            this.btnAssetInsert.TabIndex = 7;
            this.btnAssetInsert.Text = "Insert";
            this.btnAssetInsert.UseVisualStyleBackColor = false;
            this.btnAssetInsert.Click += new System.EventHandler(this.btnAssetInsert_Click);
            // 
            // txtAssetAmt
            // 
            this.txtAssetAmt.Location = new System.Drawing.Point(17, 198);
            this.txtAssetAmt.Name = "txtAssetAmt";
            this.txtAssetAmt.Size = new System.Drawing.Size(179, 22);
            this.txtAssetAmt.TabIndex = 6;
            // 
            // lblAssetAmt
            // 
            this.lblAssetAmt.AutoSize = true;
            this.lblAssetAmt.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.lblAssetAmt.Location = new System.Drawing.Point(47, 162);
            this.lblAssetAmt.Name = "lblAssetAmt";
            this.lblAssetAmt.Size = new System.Drawing.Size(119, 23);
            this.lblAssetAmt.TabIndex = 5;
            this.lblAssetAmt.Text = "Asset Amount";
            // 
            // txtAssetDesc
            // 
            this.txtAssetDesc.Location = new System.Drawing.Point(19, 82);
            this.txtAssetDesc.Multiline = true;
            this.txtAssetDesc.Name = "txtAssetDesc";
            this.txtAssetDesc.Size = new System.Drawing.Size(179, 47);
            this.txtAssetDesc.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.LightCoral;
            this.btnCalculate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.Location = new System.Drawing.Point(32, 25);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(189, 44);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblFinalAssetValue
            // 
            this.lblFinalAssetValue.AutoSize = true;
            this.lblFinalAssetValue.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.lblFinalAssetValue.Location = new System.Drawing.Point(368, 37);
            this.lblFinalAssetValue.Name = "lblFinalAssetValue";
            this.lblFinalAssetValue.Size = new System.Drawing.Size(56, 23);
            this.lblFinalAssetValue.TabIndex = 9;
            this.lblFinalAssetValue.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(542, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // aSSET_PROCEDURETableAdapter1
            // 
            this.aSSET_PROCEDURETableAdapter1.ClearBeforeFill = true;
            // 
            // Assets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(936, 557);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFinalAssetValue);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridViewAsset);
            this.Name = "Assets";
            this.Text = "Assets";
            this.Load += new System.EventHandler(this.Assets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAsset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSETPROCEDUREBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assets1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewAsset;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAssetUpdate;
        private System.Windows.Forms.Button btnAssetInsert;
        private System.Windows.Forms.TextBox txtAssetAmt;
        private System.Windows.Forms.Label lblAssetAmt;
        private System.Windows.Forms.TextBox txtAssetDesc;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblFinalAssetValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSSETDETAILIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSSETHEADERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSSETDESCIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aSSETAMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource aSSETPROCEDUREBindingSource;
        private DataSet.Assets assets1;
        private DataSet.AssetsTableAdapters.ASSET_PROCEDURETableAdapter aSSET_PROCEDURETableAdapter1;
    }
}