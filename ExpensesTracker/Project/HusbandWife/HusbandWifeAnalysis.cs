﻿using ExpensesTracker.BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserLibrary;

namespace ExpensesTracker.Project.HusbandWife
{
    /// <summary>
    /// 
    /// </summary>
    public partial class HusbandWifeAnalysis : Form
    {
        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        public HusbandWifeAnalysis()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        DateTime parameter1 { get; set; }
        DateTime parameter2 { get; set; }
        #endregion

        #region Events Method
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HusbandWifeAnalysis_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCombobox();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int month = Convert.ToInt32(cmbMonth.SelectedItem.GetType().GetProperty("Value").GetValue(cmbMonth.SelectedItem, null));
            LoadParameter(Convert.ToInt32(cmbYear.SelectedItem), month);
            LoadChart();
        }
        #endregion

        #region Private Method

        /// <summary>
        /// 
        /// </summary>
        private void LoadForm()
        {
            cmbChartType.SelectedItem = "Monthly";
            cmbYear.SelectedItem = Convert.ToString(DateTime.Today.Year);
            LoadCombobox();

            LoadParameter(DateTime.Today.Year, DateTime.Today.Month);
            LoadChart();
        }

        /// <summary>
        /// 
        /// </summary>
        private void LoadChart()
        {
            DataTable ldtbTable = new DataTable();
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].Name = "Expenses";

            string query = GlobalFunction.GetQueryById(Constant.Query.LOAD_HUSBAND_WIFE_CHART);

            ldtbTable = DBFunction.FetchDataFromDatabase(Constant.Common.DATABASE_NAME, query);

            if (Convert.ToString(cmbChartType.SelectedItem) == "Monthly")
            {
                string month = string.Empty;
                if (cmbMonth.SelectedItem != null)
                    month = Convert.ToString(cmbMonth.SelectedItem.GetType().GetProperty("Text").GetValue(cmbMonth.SelectedItem, null));
                else
                    month = DateTime.Now.ToString("MMMM");
                chart1.Series.Add(month);
                if (ldtbTable.Rows.Count > 0)
                {
                    chart1.ChartAreas[0].AxisY.Maximum = ldtbTable.AsEnumerable().Select(x => x.Field<int>("Amount")).Max().GetCeilingNumber(1000);
                    foreach (DataRow dr in ldtbTable.Rows)
                    {
                        chart1.Series[month].Points.AddXY(dr["Expenses_Category_Name"], dr["Amount"]);
                    }
                }
                else
                {
                    query = "Select Expenses_Category_Id, Expenses_Category_Name, '0'  Amount from Expenses_Category";
                    chart1.ChartAreas[0].AxisY.Maximum = 100;
                    ldtbTable = DBFunction.FetchDataFromDatabase(Constant.Common.DATABASE_NAME, query);
                    if (ldtbTable.Rows.Count > 0)
                    {
                        foreach (DataRow dr in ldtbTable.Rows)
                        {
                            chart1.Series[month].Points.AddXY(dr["Expenses_Category_Name"], dr["Amount"]);
                        }
                    }
                }
            }
            else if (Convert.ToString(cmbChartType.SelectedItem) == "Quarterly")
            {
                List<string> monthname = new List<string>();
                string month = string.Empty;
                if (cmbMonth.SelectedItem != null)
                {
                    month = Convert.ToString(cmbMonth.SelectedItem.GetType().GetProperty("Value").GetValue(cmbMonth.SelectedItem, null));
                    monthname = GlobalFunction.GetMonthNameFromQuarter(Convert.ToInt32(month));
                    chart1.Series.Add(monthname[0]);
                    chart1.Series.Add(monthname[1]);
                    chart1.Series.Add(monthname[2]);
                }
                else
                    month = DateTime.Now.ToString("MMMM");

                if (ldtbTable.Rows.Count > 0)
                {
                    chart1.ChartAreas[0].AxisY.Maximum = ldtbTable.AsEnumerable().Select(x => x.Field<int>("Amount")).Max().GetCeilingNumber(1000);
                    foreach (string mon in monthname)
                    {
                        int iMonthNo = Convert.ToDateTime("01-" + mon.Substring(0, 3) + "-2020").Month;
                        DataRow[] ldtbTableTemp = ldtbTable.Select("Months = '" + iMonthNo + "'");
                        if (ldtbTableTemp.Count() > 0)
                        {
                            foreach (DataRow dr in ldtbTableTemp)
                            {
                                chart1.Series[mon].Points.AddXY(dr["Expenses_Category_Name"], dr["Amount"]);
                            }
                        }
                    }
                }
                else
                {
                    query = "Select Expenses_Category_Id, Expenses_Category_Name, '0'  Amount from Expenses_Category";
                    ldtbTable = DBFunction.FetchDataFromDatabase(Constant.Common.DATABASE_NAME, query);
                    if (ldtbTable.Rows.Count > 0)
                    {
                        foreach (string mon in monthname)
                        {
                            foreach (DataRow dr in ldtbTable.Rows)
                            {
                                chart1.Series[mon].Points.AddXY(dr["Expenses_Category_Name"], dr["Amount"]);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void LoadCombobox()
        {
            cmbMonth.DisplayMember = "Text";
            cmbMonth.ValueMember = "Value";
            cmbMonth.SelectedItem = " ";
            cmbMonth.Items.Clear();
            if (Convert.ToString(cmbChartType.SelectedItem) == "Quarterly")
            {
                cmbMonth.Items.Add(new { Text = "1st Quarter", Value = 0 });
                cmbMonth.Items.Add(new { Text = "2nd Quarter", Value = 1 });
                cmbMonth.Items.Add(new { Text = "3rd Quarter", Value = 2 });
                cmbMonth.Items.Add(new { Text = "4th Quarter", Value = 3 });
            }
            else if (Convert.ToString(cmbChartType.SelectedItem) == "Monthly")
            {
                cmbMonth.Items.Add(new { Text = "January", Value = 1 });
                cmbMonth.Items.Add(new { Text = "Febuary", Value = 2 });
                cmbMonth.Items.Add(new { Text = "March", Value = 3 });
                cmbMonth.Items.Add(new { Text = "April", Value = 4 });
                cmbMonth.Items.Add(new { Text = "May", Value = 5 });
                cmbMonth.Items.Add(new { Text = "June", Value = 6 });
                cmbMonth.Items.Add(new { Text = "July", Value = 7 });
                cmbMonth.Items.Add(new { Text = "August", Value = 8 });
                cmbMonth.Items.Add(new { Text = "September", Value = 9 });
                cmbMonth.Items.Add(new { Text = "October", Value = 10 });
                cmbMonth.Items.Add(new { Text = "November", Value = 11 });
                cmbMonth.Items.Add(new { Text = "December", Value = 12 });
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aintYear"></param>
        /// <param name="aintMonth"></param>
        private void LoadParameter(int aintYear, int aintMonth)
        {
            if (Convert.ToString(cmbChartType.SelectedItem) == "Monthly")
            {
                parameter1 = GlobalFunction.GetFirstDateOfMonth(aintYear, aintMonth);
                parameter2 = GlobalFunction.GetLastDateOfMonth(aintYear, aintMonth);
            }
            else if (Convert.ToString(cmbChartType.SelectedItem) == "Quarterly")
            {
                parameter1 = GlobalFunction.GetFirstDateOfMonth(aintYear, (3 * aintMonth) + 1);
                parameter2 = GlobalFunction.GetLastDateOfMonth(aintYear, (3 * aintMonth) + 3);
            }
        }

        #endregion
    }
}
