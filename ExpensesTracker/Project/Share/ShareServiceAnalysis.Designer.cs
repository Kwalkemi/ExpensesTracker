namespace ExpensesTracker.Project.Share
{
    partial class ShareServiceAnalysis
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
            this.listViewServiceAnalysis = new System.Windows.Forms.ListView();
            this.cmbChartType = new System.Windows.Forms.ComboBox();
            this.lblChartType = new System.Windows.Forms.Label();
            this.chartMonthlyExpenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkedListUsersService = new System.Windows.Forms.CheckedListBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblUserList = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthlyExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalSpendResult
            // 
            this.lblTotalSpendResult.AutoSize = true;
            this.lblTotalSpendResult.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalSpendResult.Location = new System.Drawing.Point(1009, 28);
            this.lblTotalSpendResult.Name = "lblTotalSpendResult";
            this.lblTotalSpendResult.Size = new System.Drawing.Size(80, 27);
            this.lblTotalSpendResult.TabIndex = 19;
            this.lblTotalSpendResult.Text = "Result: ";
            // 
            // lblTotalSpend
            // 
            this.lblTotalSpend.AutoSize = true;
            this.lblTotalSpend.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalSpend.Location = new System.Drawing.Point(870, 28);
            this.lblTotalSpend.Name = "lblTotalSpend";
            this.lblTotalSpend.Size = new System.Drawing.Size(133, 27);
            this.lblTotalSpend.TabIndex = 18;
            this.lblTotalSpend.Text = "Total Spend: ";
            // 
            // listViewServiceAnalysis
            // 
            this.listViewServiceAnalysis.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewServiceAnalysis.HideSelection = false;
            this.listViewServiceAnalysis.Location = new System.Drawing.Point(985, 126);
            this.listViewServiceAnalysis.Name = "listViewServiceAnalysis";
            this.listViewServiceAnalysis.Size = new System.Drawing.Size(248, 404);
            this.listViewServiceAnalysis.TabIndex = 17;
            this.listViewServiceAnalysis.UseCompatibleStateImageBehavior = false;
            this.listViewServiceAnalysis.View = System.Windows.Forms.View.List;
            // 
            // cmbChartType
            // 
            this.cmbChartType.FormattingEnabled = true;
            this.cmbChartType.Items.AddRange(new object[] {
            "Monthly",
            "Quarterly",
            "Yearly"});
            this.cmbChartType.Location = new System.Drawing.Point(132, 27);
            this.cmbChartType.Name = "cmbChartType";
            this.cmbChartType.Size = new System.Drawing.Size(159, 24);
            this.cmbChartType.TabIndex = 15;
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
            this.chartMonthlyExpenses.Size = new System.Drawing.Size(920, 449);
            this.chartMonthlyExpenses.TabIndex = 10;
            this.chartMonthlyExpenses.Text = "chart1";
            // 
            // checkedListUsersService
            // 
            this.checkedListUsersService.FormattingEnabled = true;
            this.checkedListUsersService.Location = new System.Drawing.Point(1139, 27);
            this.checkedListUsersService.Name = "checkedListUsersService";
            this.checkedListUsersService.Size = new System.Drawing.Size(120, 72);
            this.checkedListUsersService.TabIndex = 20;
            this.checkedListUsersService.SelectedIndexChanged += new System.EventHandler(this.checkedListUsersService_SelectedIndexChanged);
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(664, 28);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(159, 24);
            this.cmbMonth.TabIndex = 22;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblMonth.Location = new System.Drawing.Point(575, 27);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(89, 27);
            this.lblMonth.TabIndex = 21;
            this.lblMonth.Text = "Month : ";
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
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021"});
            this.cmbYear.Location = new System.Drawing.Point(386, 28);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(159, 24);
            this.cmbYear.TabIndex = 25;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.lblYear.Location = new System.Drawing.Point(313, 27);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(67, 27);
            this.lblYear.TabIndex = 24;
            this.lblYear.Text = "Year : ";
            // 
            // ShareServiceAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1271, 549);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblUserList);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.checkedListUsersService);
            this.Controls.Add(this.lblTotalSpendResult);
            this.Controls.Add(this.lblTotalSpend);
            this.Controls.Add(this.listViewServiceAnalysis);
            this.Controls.Add(this.cmbChartType);
            this.Controls.Add(this.lblChartType);
            this.Controls.Add(this.chartMonthlyExpenses);
            this.Name = "ShareServiceAnalysis";
            this.Text = "ShareServiceAnalysis";
            this.Load += new System.EventHandler(this.ShareServiceAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMonthlyExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTotalSpendResult;
        private System.Windows.Forms.Label lblTotalSpend;
        private System.Windows.Forms.ListView listViewServiceAnalysis;
        private System.Windows.Forms.ComboBox cmbChartType;
        private System.Windows.Forms.Label lblChartType;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonthlyExpenses;
        private System.Windows.Forms.CheckedListBox checkedListUsersService;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblUserList;

        #endregion

        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblYear;
    }
}