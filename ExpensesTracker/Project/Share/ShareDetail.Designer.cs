namespace ExpensesTracker.Project.Share
{
    partial class ShareDetail
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
            this.lblShareName = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResultValue = new System.Windows.Forms.Label();
            this.txtShareAmt = new System.Windows.Forms.TextBox();
            this.txtShareQty = new System.Windows.Forms.TextBox();
            this.txtShareCharges = new System.Windows.Forms.TextBox();
            this.dateShareDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateShareDetail = new System.Windows.Forms.Button();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblHdr = new System.Windows.Forms.Label();
            this.checkHeaderUpdate = new System.Windows.Forms.CheckBox();
            this.txtHdrId = new System.Windows.Forms.TextBox();
            this.shares_TrackerDataset = new ExpensesTracker.DataSet.Shares_TrackerDataset();
            this.sHAREDETAILPROCEDUREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sHARE_DETAIL_PROCEDURETableAdapter = new ExpensesTracker.DataSet.Shares_TrackerDatasetTableAdapters.SHARE_DETAIL_PROCEDURETableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shares_TrackerDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHAREDETAILPROCEDUREBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sHAREDETAILPROCEDUREBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(952, 444);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // lblShareName
            // 
            this.lblShareName.AutoSize = true;
            this.lblShareName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblShareName.Location = new System.Drawing.Point(87, 20);
            this.lblShareName.Name = "lblShareName";
            this.lblShareName.Size = new System.Drawing.Size(66, 27);
            this.lblShareName.TabIndex = 1;
            this.lblShareName.Text = "label1";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(563, 20);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(80, 27);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result: ";
            // 
            // lblResultValue
            // 
            this.lblResultValue.AutoSize = true;
            this.lblResultValue.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblResultValue.Location = new System.Drawing.Point(649, 20);
            this.lblResultValue.Name = "lblResultValue";
            this.lblResultValue.Size = new System.Drawing.Size(80, 27);
            this.lblResultValue.TabIndex = 3;
            this.lblResultValue.Text = "Result: ";
            // 
            // txtShareAmt
            // 
            this.txtShareAmt.Location = new System.Drawing.Point(394, 542);
            this.txtShareAmt.Name = "txtShareAmt";
            this.txtShareAmt.Size = new System.Drawing.Size(117, 22);
            this.txtShareAmt.TabIndex = 4;
            // 
            // txtShareQty
            // 
            this.txtShareQty.Location = new System.Drawing.Point(546, 542);
            this.txtShareQty.Name = "txtShareQty";
            this.txtShareQty.Size = new System.Drawing.Size(117, 22);
            this.txtShareQty.TabIndex = 5;
            // 
            // txtShareCharges
            // 
            this.txtShareCharges.Location = new System.Drawing.Point(697, 542);
            this.txtShareCharges.Name = "txtShareCharges";
            this.txtShareCharges.Size = new System.Drawing.Size(117, 22);
            this.txtShareCharges.TabIndex = 6;
            // 
            // dateShareDate
            // 
            this.dateShareDate.Location = new System.Drawing.Point(137, 542);
            this.dateShareDate.Name = "dateShareDate";
            this.dateShareDate.Size = new System.Drawing.Size(200, 22);
            this.dateShareDate.TabIndex = 7;
            // 
            // btnUpdateShareDetail
            // 
            this.btnUpdateShareDetail.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpdateShareDetail.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateShareDetail.Location = new System.Drawing.Point(844, 536);
            this.btnUpdateShareDetail.Name = "btnUpdateShareDetail";
            this.btnUpdateShareDetail.Size = new System.Drawing.Size(82, 31);
            this.btnUpdateShareDetail.TabIndex = 65;
            this.btnUpdateShareDetail.Text = "Update";
            this.btnUpdateShareDetail.UseVisualStyleBackColor = false;
            this.btnUpdateShareDetail.Click += new System.EventHandler(this.btnUpdateShareDetail_Click_1);
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblUpdate.Location = new System.Drawing.Point(25, 539);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(79, 27);
            this.lblUpdate.TabIndex = 66;
            this.lblUpdate.Text = "Update";
            // 
            // lblHdr
            // 
            this.lblHdr.AutoSize = true;
            this.lblHdr.Location = new System.Drawing.Point(177, 581);
            this.lblHdr.Name = "lblHdr";
            this.lblHdr.Size = new System.Drawing.Size(383, 17);
            this.lblHdr.TabIndex = 67;
            this.lblHdr.Text = "If you want to add Update Header Id then tick the check box";
            // 
            // checkHeaderUpdate
            // 
            this.checkHeaderUpdate.AutoSize = true;
            this.checkHeaderUpdate.Location = new System.Drawing.Point(572, 582);
            this.checkHeaderUpdate.Name = "checkHeaderUpdate";
            this.checkHeaderUpdate.Size = new System.Drawing.Size(18, 17);
            this.checkHeaderUpdate.TabIndex = 68;
            this.checkHeaderUpdate.UseVisualStyleBackColor = true;
            this.checkHeaderUpdate.CheckedChanged += new System.EventHandler(this.checkHeaderUpdate_CheckedChanged);
            // 
            // txtHdrId
            // 
            this.txtHdrId.Location = new System.Drawing.Point(596, 578);
            this.txtHdrId.Name = "txtHdrId";
            this.txtHdrId.Size = new System.Drawing.Size(117, 22);
            this.txtHdrId.TabIndex = 69;
            // 
            // shares_TrackerDataset
            // 
            this.shares_TrackerDataset.DataSetName = "Shares_TrackerDataset";
            this.shares_TrackerDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sHAREDETAILPROCEDUREBindingSource
            // 
            this.sHAREDETAILPROCEDUREBindingSource.DataMember = "SHARE_DETAIL_PROCEDURE";
            this.sHAREDETAILPROCEDUREBindingSource.DataSource = this.shares_TrackerDataset;
            // 
            // sHARE_DETAIL_PROCEDURETableAdapter
            // 
            this.sHARE_DETAIL_PROCEDURETableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RECORD_TYPE";
            this.dataGridViewTextBoxColumn1.HeaderText = "Record Type";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TRADING_DATE";
            this.dataGridViewTextBoxColumn2.HeaderText = "Trading Date";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SHARES_AMT";
            this.dataGridViewTextBoxColumn3.HeaderText = "Shares Amt";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SHARES_QTY";
            this.dataGridViewTextBoxColumn4.HeaderText = "Shares Qty";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SHARES_CHARGES";
            this.dataGridViewTextBoxColumn5.HeaderText = "Shares Charges";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TOTAL";
            this.dataGridViewTextBoxColumn6.HeaderText = "Total";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // ShareDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(976, 615);
            this.Controls.Add(this.txtHdrId);
            this.Controls.Add(this.checkHeaderUpdate);
            this.Controls.Add(this.lblHdr);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.btnUpdateShareDetail);
            this.Controls.Add(this.dateShareDate);
            this.Controls.Add(this.txtShareCharges);
            this.Controls.Add(this.txtShareQty);
            this.Controls.Add(this.txtShareAmt);
            this.Controls.Add(this.lblResultValue);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblShareName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShareDetail";
            this.Text = "ShareDetail";
            this.Load += new System.EventHandler(this.ShareDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shares_TrackerDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHAREDETAILPROCEDUREBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblShareName;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResultValue;
        private System.Windows.Forms.TextBox txtShareAmt;
        private System.Windows.Forms.TextBox txtShareQty;
        private System.Windows.Forms.TextBox txtShareCharges;
        private System.Windows.Forms.DateTimePicker dateShareDate;
        private System.Windows.Forms.Button btnUpdateShareDetail;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn rECORDTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRADINGDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHARESAMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHARESQTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHARESCHARGESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.Label lblHdr;
        private System.Windows.Forms.CheckBox checkHeaderUpdate;
        private System.Windows.Forms.TextBox txtHdrId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sHAREDETAILPROCEDUREBindingSource;
        private DataSet.Shares_TrackerDataset shares_TrackerDataset;
        private DataSet.Shares_TrackerDatasetTableAdapters.SHARE_DETAIL_PROCEDURETableAdapter sHARE_DETAIL_PROCEDURETableAdapter;
    }
}