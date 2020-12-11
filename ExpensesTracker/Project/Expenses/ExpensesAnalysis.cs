using ExpensesTracker.BusinessObject;
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

namespace ExpensesTracker.Project.Expenses
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ExpensesAnalysis : Form
    {
        #region Constructor
        public ExpensesAnalysis()
        {
            InitializeComponent();
        }
        #endregion

        #region Parameter

        /// <summary>
        /// 
        /// </summary>
        string parameter1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string parameter2 { get; set; }

        #endregion

        #region Events Methods
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpensesAnalysis_Load(object sender, EventArgs e)
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
            LoadList();
        }

        #endregion

        #region Private Methods
        private void LoadForm()
        {
            cmbChartType.SelectedItem = "Monthly";
            cmbYear.SelectedItem = Convert.ToString(DateTime.Today.Year);
            LoadCombobox();

            LoadParameter(DateTime.Today.Year, DateTime.Today.Month);
            // TODO: This line of code loads data into the 'bharatDataSet1.Husband_Wife' table. You can move, or remove it, as needed.
            LoadChart();
            LoadList();
        }

        private void LoadList()
        {
            DataTable ldtbTable = new DataTable();
            listView1.Clear();
            int Total = 0;
            string query = GlobalFunction.GetQueryById(Constant.Query.LOAD_EXPENSES_CHART);
            query = string.Format(query, parameter1, parameter2);

            ldtbTable = DBFunction.FetchDataFromDatabase(Constant.Common.DATABASE_NAME, query);
            string lstrItem = string.Empty;
            foreach (DataRow dr in ldtbTable.Rows)
            {
                Total = Total + Convert.ToInt32(dr[Constant.Common.Alias.AMOUNT]);
                lstrItem = Convert.ToString(dr[TableEnum.enmExpenses_Category.EXPENSES_CATEGORY_NAME.ToString()]) + " - " + Convert.ToString(dr[Constant.Common.Alias.AMOUNT]);
                listView1.Items.Add(lstrItem);
            }
            lblTotalSpendResult.Text = Total > 0 ? Convert.ToString(Total) : "0";
        }

        public void LoadChart()
        {
            DataTable ldtbTable = new DataTable();
            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].Name = "Expenses";

            string query = GlobalFunction.GetQueryById(Constant.Query.LOAD_EXPENSES_CHART);
            query = string.Format(query, parameter1, parameter2);
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
                    chart1.ChartAreas[0].AxisY.Maximum = ldtbTable.AsEnumerable().Select(x => x.Field<int>(Constant.Common.Alias.AMOUNT)).Max().GetCeilingNumber(1000);
                    foreach (DataRow dr in ldtbTable.Rows)
                    {
                        chart1.Series[month].Points.AddXY(dr["Expenses_Category_Name"], dr[Constant.Common.Alias.AMOUNT]);
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
                cmbMonth.Items.Add(new { Text = TableEnum.Month.January.ToString(), Value = 1 });
                cmbMonth.Items.Add(new { Text = TableEnum.Month.February.ToString(), Value = 2 });
                cmbMonth.Items.Add(new { Text = TableEnum.Month.March.ToString(), Value = 3 });
                cmbMonth.Items.Add(new { Text = TableEnum.Month.April.ToString(), Value = 4 });
                cmbMonth.Items.Add(new { Text = TableEnum.Month.May.ToString(), Value = 5 });
                cmbMonth.Items.Add(new { Text = TableEnum.Month.June.ToString(), Value = 6 });
                cmbMonth.Items.Add(new { Text = TableEnum.Month.July.ToString(), Value = 7 });
                cmbMonth.Items.Add(new { Text = TableEnum.Month.August.ToString(), Value = 8 });
                cmbMonth.Items.Add(new { Text = TableEnum.Month.September.ToString(), Value = 9 });
                cmbMonth.Items.Add(new { Text = TableEnum.Month.October.ToString(), Value = 10 });
                cmbMonth.Items.Add(new { Text = TableEnum.Month.November.ToString(), Value = 11 });
                cmbMonth.Items.Add(new { Text = TableEnum.Month.December.ToString(), Value = 12 });
            }
        }

        public void LoadParameter(int aintYear, int aintMonth)
        {
            if (Convert.ToString(cmbChartType.SelectedItem) == "Monthly")
            {
                parameter1 = GlobalFunction.GetFirstDateOfMonth(aintYear, aintMonth).ToString(Constant.Common.DATE_FORMAT_yyyy_MM_dd);
                parameter2 = GlobalFunction.GetLastDateOfMonth(aintYear, aintMonth).ToString(Constant.Common.DATE_FORMAT_yyyy_MM_dd);
            }
            else if (Convert.ToString(cmbChartType.SelectedItem) == "Quarterly")
            {
                parameter1 = GlobalFunction.GetFirstDateOfMonth(aintYear, (3 * aintMonth) + 1).ToString(Constant.Common.DATE_FORMAT_yyyy_MM_dd);
                parameter2 = GlobalFunction.GetLastDateOfMonth(aintYear, (3 * aintMonth) + 3).ToString(Constant.Common.DATE_FORMAT_yyyy_MM_dd);
            }
        }

        #endregion


    }
}
