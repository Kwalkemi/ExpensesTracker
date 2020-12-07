namespace ExpensesTracker.Project.Share
{
    partial class ShareMonthlyAnalysis
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
            this.lblTotalSpendResult = new System.Windows.Forms.Label();
            this.lblTotalSpend = new System.Windows.Forms.Label();
            this.listViewMonthlyAnalysis = new System.Windows.Forms.ListView();
            this.cmbChartType = new System.Windows.Forms.ComboBox();
            this.lblChartType = new System.Windows.Forms.Label();
            this.chartMonthlyExpenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkedListUsers = new System.Windows.Forms.CheckedListBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblUserList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthlyExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalSpendResult
            // 
            this.lblTotalSpendResult.AutoSize = true;
            this.lblTotalSpendResult.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalSpendResult.Location = new System.Drawing.Point(848, 28);
            this.lblTotalSpendResult.Name = "lblTotalSpendResult";
            this.lblTotalSpendResult.Size = new System.Drawing.Size(80, 27);
            this.lblTotalSpendResult.TabIndex = 19;
            this.lblTotalSpendResult.Text = "Result: ";
            // 
            // lblTotalSpend
            // 
            this.lblTotalSpend.AutoSize = true;
            this.lblTotalSpend.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalSpend.Location = new System.Drawing.Point(709, 28);
            this.lblTotalSpend.Name = "lblTotalSpend";
            this.lblTotalSpend.Size = new System.Drawing.Size(133, 27);
            this.lblTotalSpend.TabIndex = 18;
            this.lblTotalSpend.Text = "Total Spend: ";
            // 
            // listViewMonthlyAnalysis
            // 
            this.listViewMonthlyAnalysis.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewMonthlyAnalysis.HideSelection = false;
            this.listViewMonthlyAnalysis.Location = new System.Drawing.Point(1020, 126);
            this.listViewMonthlyAnalysis.Name = "listViewMonthlyAnalysis";
            this.listViewMonthlyAnalysis.Size = new System.Drawing.Size(213, 404);
            this.listViewMonthlyAnalysis.TabIndex = 17;
            this.listViewMonthlyAnalysis.UseCompatibleStateImageBehavior = false;
            this.listViewMonthlyAnalysis.View = System.Windows.Forms.View.List;
            // 
            // cmbChartType
            // 
            this.cmbChartType.FormattingEnabled = true;
            this.cmbChartType.Items.AddRange(new object[] {
            "Monthly",
            "Quarterly",
            "Yearly"});
            this.cmbChartType.Location = new System.Drawing.Point(135, 27);
            this.cmbChartType.Name = "cmbChartType";
            this.cmbChartType.Size = new System.Drawing.Size(159, 24);
            this.cmbChartType.TabIndex = 15;
            this.cmbChartType.SelectedIndexChanged += new System.EventHandler(this.cmbChartType_SelectedIndexChanged);
            // 
            // lblChartType
            // 
            this.lblChartType.AutoSize = true;
            this.lblChartType.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblChartType.Location = new System.Drawing.Point(6, 24);
            this.lblChartType.Name = "lblChartType";
            this.lblChartType.Size = new System.Drawing.Size(125, 27);
            this.lblChartType.TabIndex = 12;
            this.lblChartType.Text = "Chart Type: ";
            // 
            // chartMonthlyExpenses
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMonthlyExpenses.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMonthlyExpenses.Legends.Add(legend1);
            this.chartMonthlyExpenses.Location = new System.Drawing.Point(30, 73);
            this.chartMonthlyExpenses.Name = "chartMonthlyExpenses";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "Expenses_Category_Name";
            series1.YValueMembers = "Amount";
            this.chartMonthlyExpenses.Series.Add(series1);
            this.chartMonthlyExpenses.Size = new System.Drawing.Size(953, 449);
            this.chartMonthlyExpenses.TabIndex = 10;
            this.chartMonthlyExpenses.Text = "chart1";
            // 
            // checkedListUsers
            // 
            this.checkedListUsers.FormattingEnabled = true;
            this.checkedListUsers.Location = new System.Drawing.Point(1139, 27);
            this.checkedListUsers.Name = "checkedListUsers";
            this.checkedListUsers.Size = new System.Drawing.Size(120, 72);
            this.checkedListUsers.TabIndex = 20;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020"});
            this.cmbYear.Location = new System.Drawing.Point(448, 28);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(159, 24);
            this.cmbYear.TabIndex = 22;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblYear.Location = new System.Drawing.Point(356, 27);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(62, 27);
            this.lblYear.TabIndex = 21;
            this.lblYear.Text = "Year: ";
            // 
            // lblUserList
            // 
            this.lblUserList.AutoSize = true;
            this.lblUserList.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserList.Location = new System.Drawing.Point(1159, -1);
            this.lblUserList.Name = "lblUserList";
            this.lblUserList.Size = new System.Drawing.Size(79, 23);
            this.lblUserList.TabIndex = 23;
            this.lblUserList.Text = "User List";
            // 
            // ShareMonthlyAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1271, 549);
            this.Controls.Add(this.lblUserList);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.checkedListUsers);
            this.Controls.Add(this.lblTotalSpendResult);
            this.Controls.Add(this.lblTotalSpend);
            this.Controls.Add(this.listViewMonthlyAnalysis);
            this.Controls.Add(this.cmbChartType);
            this.Controls.Add(this.lblChartType);
            this.Controls.Add(this.chartMonthlyExpenses);
            this.Name = "ShareMonthlyAnalysis";
            this.Text = "ShareMonthlyAnalysis";
            this.Load += new System.EventHandler(this.ShareMonthlyAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthlyExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalSpendResult;
        private System.Windows.Forms.Label lblTotalSpend;
        private System.Windows.Forms.ListView listViewMonthlyAnalysis;
        private System.Windows.Forms.ComboBox cmbChartType;
        private System.Windows.Forms.Label lblChartType;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonthlyExpenses;
        private System.Windows.Forms.CheckedListBox checkedListUsers;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblUserList;
    }
}