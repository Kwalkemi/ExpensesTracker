namespace ExpensesTracker.Project.Expenses
{
    partial class ExpensesAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblChartType = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbChartType = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblTotalSpend = new System.Windows.Forms.Label();
            this.lblTotalSpendResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 77);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "Expenses_Category_Name";
            series1.YValueMembers = "Amount";
            this.chart1.Series.Add(series1);
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
            this.cmbChartType.SelectedIndexChanged += new System.EventHandler(this.cmbChartType_SelectedIndexChanged);
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(740, 33);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(159, 24);
            this.cmbMonth.TabIndex = 6;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(1010, 106);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(241, 404);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // lblTotalSpend
            // 
            this.lblTotalSpend.AutoSize = true;
            this.lblTotalSpend.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalSpend.Location = new System.Drawing.Point(985, 33);
            this.lblTotalSpend.Name = "lblTotalSpend";
            this.lblTotalSpend.Size = new System.Drawing.Size(133, 27);
            this.lblTotalSpend.TabIndex = 8;
            this.lblTotalSpend.Text = "Total Spend: ";
            // 
            // lblTotalSpendResult
            // 
            this.lblTotalSpendResult.AutoSize = true;
            this.lblTotalSpendResult.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalSpendResult.Location = new System.Drawing.Point(1124, 33);
            this.lblTotalSpendResult.Name = "lblTotalSpendResult";
            this.lblTotalSpendResult.Size = new System.Drawing.Size(80, 27);
            this.lblTotalSpendResult.TabIndex = 9;
            this.lblTotalSpendResult.Text = "Result: ";
            // 
            // ExpensesAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1271, 549);
            this.Controls.Add(this.lblTotalSpendResult);
            this.Controls.Add(this.lblTotalSpend);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbChartType);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblChartType);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.chart1);
            this.Name = "ExpensesAnalysis";
            this.Text = "Expenses Analysis";
            this.Load += new System.EventHandler(this.ExpensesAnalysis_Load);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblTotalSpend;
        private System.Windows.Forms.Label lblTotalSpendResult;
    }
}