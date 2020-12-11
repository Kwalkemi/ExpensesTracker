namespace ExpensesTracker.Project.HusbandWife
{
    partial class HusbandWifeAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblChartType = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbChartType = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.listViewHusbandWifeAnalysis = new System.Windows.Forms.ListView();
            this.lblTotalSpendResult = new System.Windows.Forms.Label();
            this.lblTotalSpend = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 77);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueMember = "Expenses_Category_Name";
            series2.YValueMembers = "Amount";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(953, 449);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblYear.Location = new System.Drawing.Point(21, 30);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(62, 27);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "Year: ";
            // 
            // lblChartType
            // 
            this.lblChartType.AutoSize = true;
            this.lblChartType.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblChartType.Location = new System.Drawing.Point(297, 30);
            this.lblChartType.Name = "lblChartType";
            this.lblChartType.Size = new System.Drawing.Size(125, 27);
            this.lblChartType.TabIndex = 2;
            this.lblChartType.Text = "Chart Type: ";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblMonth.Location = new System.Drawing.Point(643, 32);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(84, 27);
            this.lblMonth.TabIndex = 3;
            this.lblMonth.Text = "Month: ";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020"});
            this.cmbYear.Location = new System.Drawing.Point(85, 31);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(159, 24);
            this.cmbYear.TabIndex = 4;
            // 
            // cmbChartType
            // 
            this.cmbChartType.FormattingEnabled = true;
            this.cmbChartType.Items.AddRange(new object[] {
            "Monthly",
            "Quarterly"});
            this.cmbChartType.Location = new System.Drawing.Point(426, 33);
            this.cmbChartType.Name = "cmbChartType";
            this.cmbChartType.Size = new System.Drawing.Size(159, 24);
            this.cmbChartType.TabIndex = 5;
            this.cmbChartType.SelectedIndexChanged += new System.EventHandler(this.cmbChartType_SelectedIndexChanged_1);
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(740, 33);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(159, 24);
            this.cmbMonth.TabIndex = 6;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged_1);
            // 
            // listViewHusbandWifeAnalysis
            // 
            this.listViewHusbandWifeAnalysis.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewHusbandWifeAnalysis.HideSelection = false;
            this.listViewHusbandWifeAnalysis.Location = new System.Drawing.Point(1020, 122);
            this.listViewHusbandWifeAnalysis.Name = "listViewHusbandWifeAnalysis";
            this.listViewHusbandWifeAnalysis.Size = new System.Drawing.Size(227, 404);
            this.listViewHusbandWifeAnalysis.TabIndex = 8;
            this.listViewHusbandWifeAnalysis.UseCompatibleStateImageBehavior = false;
            this.listViewHusbandWifeAnalysis.View = System.Windows.Forms.View.List;
            // 
            // lblTotalSpendResult
            // 
            this.lblTotalSpendResult.AutoSize = true;
            this.lblTotalSpendResult.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalSpendResult.Location = new System.Drawing.Point(1125, 33);
            this.lblTotalSpendResult.Name = "lblTotalSpendResult";
            this.lblTotalSpendResult.Size = new System.Drawing.Size(80, 27);
            this.lblTotalSpendResult.TabIndex = 11;
            this.lblTotalSpendResult.Text = "Result: ";
            // 
            // lblTotalSpend
            // 
            this.lblTotalSpend.AutoSize = true;
            this.lblTotalSpend.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalSpend.Location = new System.Drawing.Point(986, 33);
            this.lblTotalSpend.Name = "lblTotalSpend";
            this.lblTotalSpend.Size = new System.Drawing.Size(133, 27);
            this.lblTotalSpend.TabIndex = 10;
            this.lblTotalSpend.Text = "Total Spend: ";
            // 
            // HusbandWifeAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1271, 549);
            this.Controls.Add(this.lblTotalSpendResult);
            this.Controls.Add(this.lblTotalSpend);
            this.Controls.Add(this.listViewHusbandWifeAnalysis);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbChartType);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblChartType);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.chart1);
            this.Name = "HusbandWifeAnalysis";
            this.Text = "Husband Wife Analysis";
            this.Load += new System.EventHandler(this.HusbandWifeAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblChartType;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbChartType;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ListView listViewHusbandWifeAnalysis;
        private System.Windows.Forms.Label lblTotalSpendResult;
        private System.Windows.Forms.Label lblTotalSpend;
    }
}