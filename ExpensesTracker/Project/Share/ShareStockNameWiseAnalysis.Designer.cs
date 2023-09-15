
namespace ExpensesTracker.Project.Share
{
    partial class ShareStockNameWiseAnalysis
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
            this.dataGridViewShareWiseProfit = new System.Windows.Forms.DataGridView();
            this.shares_TrackerDataset = new ExpensesTracker.DataSet.Shares_TrackerDataset();
            this.sHAREWISEPROFITBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sHARE_WISE_PROFITTableAdapter = new ExpensesTracker.DataSet.Shares_TrackerDatasetTableAdapters.SHARE_WISE_PROFITTableAdapter();
            this.sHARESNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aMTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShareWiseProfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shares_TrackerDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHAREWISEPROFITBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewShareWiseProfit
            // 
            this.dataGridViewShareWiseProfit.AutoGenerateColumns = false;
            this.dataGridViewShareWiseProfit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShareWiseProfit.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewShareWiseProfit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShareWiseProfit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sHARESNAMEDataGridViewTextBoxColumn,
            this.aMTDataGridViewTextBoxColumn});
            this.dataGridViewShareWiseProfit.DataSource = this.sHAREWISEPROFITBindingSource;
            this.dataGridViewShareWiseProfit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewShareWiseProfit.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewShareWiseProfit.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewShareWiseProfit.Name = "dataGridViewShareWiseProfit";
            this.dataGridViewShareWiseProfit.RowHeadersWidth = 51;
            this.dataGridViewShareWiseProfit.RowTemplate.Height = 24;
            this.dataGridViewShareWiseProfit.Size = new System.Drawing.Size(530, 632);
            this.dataGridViewShareWiseProfit.TabIndex = 0;
            // 
            // shares_TrackerDataset
            // 
            this.shares_TrackerDataset.DataSetName = "Shares_TrackerDataset";
            this.shares_TrackerDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sHAREWISEPROFITBindingSource
            // 
            this.sHAREWISEPROFITBindingSource.DataMember = "SHARE_WISE_PROFIT";
            this.sHAREWISEPROFITBindingSource.DataSource = this.shares_TrackerDataset;
            // 
            // sHARE_WISE_PROFITTableAdapter
            // 
            this.sHARE_WISE_PROFITTableAdapter.ClearBeforeFill = true;
            // 
            // sHARESNAMEDataGridViewTextBoxColumn
            // 
            this.sHARESNAMEDataGridViewTextBoxColumn.DataPropertyName = "SHARES_NAME";
            this.sHARESNAMEDataGridViewTextBoxColumn.HeaderText = "Share Name";
            this.sHARESNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sHARESNAMEDataGridViewTextBoxColumn.Name = "sHARESNAMEDataGridViewTextBoxColumn";
            // 
            // aMTDataGridViewTextBoxColumn
            // 
            this.aMTDataGridViewTextBoxColumn.DataPropertyName = "AMT";
            this.aMTDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.aMTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aMTDataGridViewTextBoxColumn.Name = "aMTDataGridViewTextBoxColumn";
            this.aMTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ShareStockNameWiseAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(530, 632);
            this.Controls.Add(this.dataGridViewShareWiseProfit);
            this.Name = "ShareStockNameWiseAnalysis";
            this.Text = "ShareStockNameWiseAnalysis";
            this.Load += new System.EventHandler(this.ShareStockNameWiseAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShareWiseProfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shares_TrackerDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHAREWISEPROFITBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewShareWiseProfit;
        private DataSet.Shares_TrackerDataset shares_TrackerDataset;
        private System.Windows.Forms.BindingSource sHAREWISEPROFITBindingSource;
        private DataSet.Shares_TrackerDatasetTableAdapters.SHARE_WISE_PROFITTableAdapter sHARE_WISE_PROFITTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHARESNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aMTDataGridViewTextBoxColumn;
    }
}