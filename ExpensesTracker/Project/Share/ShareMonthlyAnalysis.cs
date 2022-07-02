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

namespace ExpensesTracker.Project.Share
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ShareMonthlyAnalysis : Form
    {
        private readonly string istrDematAccountType;
        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        public ShareMonthlyAnalysis(string astrDematAccountType)
        {
            InitializeComponent();
            this.istrDematAccountType = astrDematAccountType;
        }
        #endregion

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public int Year_Parameter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string User_Parameter { get; set; }

        #endregion

        #region Events Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShareMonthlyAnalysis_Load(object sender, EventArgs e)
        {
            cmbChartType.SelectedItem = "Monthly";
            cmbYear.SelectedItem = Convert.ToString(DateTime.Today.Year);
            LoadCombobox();
            LoadUserlist();
            LoadParameter();
            LoadChart();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadParameter();
            LoadChart();
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// 
        /// </summary>
        private void LoadCombobox()
        {
            cmbYear.SelectedValue = DateTime.Now.Year;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aintYear"></param>
        /// <param name="aintMonth"></param>
        private void LoadParameter()
        {
            if (checkedListUsers.CheckedIndices.Count == 2)
                User_Parameter = "1,2";
            else if (checkedListUsers.CheckedIndices.Count == 1)
            {
                int index = checkedListUsers.CheckedIndices[0];
                if (index == 0)
                    User_Parameter = "1";
                else if (index == 1)
                    User_Parameter = "2";
            }
            else
                User_Parameter = string.Empty;

            if (Convert.ToString(cmbChartType.SelectedItem) == Constant.Common.ChartType.MONTHLY)
            {
                Year_Parameter = Convert.ToInt32(cmbYear.SelectedItem);
            }
            else if (Convert.ToString(cmbChartType.SelectedItem) == Constant.Common.ChartType.QUARTERLY)
            {
                Year_Parameter = Convert.ToInt32(cmbYear.SelectedItem);
            }
        }

        private void LoadChart()
        {
            if (User_Parameter != string.Empty)
            {
                listViewMonthlyAnalysis.Clear();
                DataTable ldtbTableMain = new DataTable();
                chartMonthlyExpenses.Series.Clear();
                chartMonthlyExpenses.ChartAreas[0].AxisY.Minimum = 0;
                chartMonthlyExpenses.ChartAreas[0].Name = "MonthlyAnalysisShare";

                string query = GlobalFunction.GetQueryById(Constant.Query.LOAD_MONTHLY_CHART_SHARE);
                //Year_Parameter = 2018;
                query = string.Format(query, User_Parameter, Year_Parameter, this.istrDematAccountType);
                DataTable ldtbTable = DBFunction.FetchDataFromDatabase(Constant.Common.DATABASE_NAME, query);

                if (Convert.ToString(cmbChartType.SelectedItem) == Constant.Common.ChartType.MONTHLY)
                    ldtbTableMain = ConvertIntoMonthlyChartTable(ldtbTable);

                else if (Convert.ToString(cmbChartType.SelectedItem) == Constant.Common.ChartType.QUARTERLY)
                    ldtbTableMain = ConvertIntoQuarterlyChartTable(ldtbTable);

                string month = string.Empty;
                chartMonthlyExpenses.Series.Add(Year_Parameter.ToString());
                if (ldtbTableMain.Rows.Count > 0)
                {
                    chartMonthlyExpenses.ChartAreas[0].AxisY.Maximum = ldtbTableMain.AsEnumerable().Select(x => x.Field<int>("Earning")).Max().GetCeilingNumber(1000);
                    chartMonthlyExpenses.ChartAreas[0].AxisY.Minimum = ldtbTableMain.AsEnumerable().Select(x => x.Field<int>("Earning")).Min().GetCeilingNumber(1000);
                    if (chartMonthlyExpenses.ChartAreas[0].AxisY.Minimum > 0)
                        chartMonthlyExpenses.ChartAreas[0].AxisY.Minimum = 0;
                    else if (chartMonthlyExpenses.ChartAreas[0].AxisY.Minimum == 0 && chartMonthlyExpenses.ChartAreas[0].AxisY.Maximum == 0)
                        chartMonthlyExpenses.ChartAreas[0].AxisY.Maximum = 100;
                    chartMonthlyExpenses.ChartAreas[0].AxisY.IsStartedFromZero = true;
                    chartMonthlyExpenses.ChartAreas[0].AxisX.Interval = 1;
                    foreach (DataRow dr in ldtbTableMain.Rows)
                        chartMonthlyExpenses.Series[Year_Parameter.ToString()].Points.AddXY(dr["Month"], dr["Earning"]);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void LoadUserlist()
        {
            string query = GlobalFunction.GetQueryById(Constant.Query.GET_USER_LIST);
            DataTable ldtbTable = DBFunction.FetchDataFromDatabase(Constant.Common.DATABASE_NAME, query);
            foreach (DataRow dr in ldtbTable.Rows)
            {
                if (Convert.ToString(dr[TableEnum.enmLogin_Info.USERNAME.ToString()]) == GlobalFunction.GetUserNameById(Login.UserId))
                    checkedListUsers.Items.Add(dr[TableEnum.enmLogin_Info.USERNAME.ToString()], true);
                else
                    checkedListUsers.Items.Add(dr[TableEnum.enmLogin_Info.USERNAME.ToString()]);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="adtbTable"></param>
        /// <returns></returns>
        private DataTable ConvertIntoMonthlyChartTable(DataTable adtbTable)
        {
            int lintTotal = 0;
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Month");
            dataTable.Columns.Add("Earning", typeof(Int32));
            string lstrItem = string.Empty;
            List<string> lstNum = new List<string>();
            if (adtbTable.IsNotNull() && adtbTable.Rows.Count > 0)
            {
                for (int i = 1; i <= 12; i++)
                {
                    lstNum.Add(i.ToString());
                    DataRow[] dataRows = adtbTable.Select("SHARE_MONTH = " + i);
                    if (dataRows.Count() > 0)
                    {
                        DataRow dataRow = dataTable.NewRow();
                        dataRow["Month"] = ((TableEnum.Month)(dataRows[0]["SHARE_MONTH"])).ToString();
                        dataRow["Earning"] = Convert.ToInt32(dataRows[0]["PROFIT_LOSS"]);
                        lintTotal = lintTotal + Convert.ToInt32(dataRows[0]["PROFIT_LOSS"]);
                        dataTable.Rows.Add(dataRow);
                        lstrItem = Convert.ToString(dataRow["Month"]) + " : " + Convert.ToString(dataRow["Earning"]);
                        listViewMonthlyAnalysis.Items.Add(lstrItem);
                    }
                    else
                    {
                        DataRow dataRow = dataTable.NewRow();
                        dataRow["Month"] = ((TableEnum.Month)i).ToString(); ;
                        dataRow["Earning"] = 0;
                        dataTable.Rows.Add(dataRow);
                        lstrItem = Convert.ToString(dataRow["Month"]) + " : " + Convert.ToString(dataRow["Earning"]);
                        listViewMonthlyAnalysis.Items.Add(lstrItem);
                    }
                }
            }
            lblTotalSpendResult.Text = lintTotal.ToString();
            return dataTable;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="adtbTable"></param>
        /// <returns></returns>
        private DataTable ConvertIntoQuarterlyChartTable(DataTable adtbTable)
        {
            DataTable dataTable = new DataTable();
            DataTable dataTableNew = new DataTable();
            dataTable.Columns.Add("Month", typeof(string));
            dataTable.Columns.Add("Earning", typeof(Int32));
            string lstrItem = string.Empty;
            List<string> lstNum = new List<string>();
            if (adtbTable.IsNotNull() && adtbTable.Rows.Count > 0)
            {
                for (int i = 1; i <= 12; i++)
                {
                    lstNum.Add(i.ToString());
                    DataRow[] dataRows = adtbTable.Select("SHARE_MONTH = " + i);
                    if (dataRows.Count() > 0)
                    {
                        DataRow dataRow = dataTable.NewRow();
                        dataRow["Month"] = ((TableEnum.Month)(dataRows[0]["SHARE_MONTH"])).ToString().GetQuarterFromMonthName();
                        dataRow["Earning"] = Convert.ToInt32(dataRows[0]["PROFIT_LOSS"]);
                        dataTable.Rows.Add(dataRow);
                    }
                    else
                    {
                        DataRow dataRow = dataTable.NewRow();
                        dataRow["Month"] = ((TableEnum.Month)i).ToString().GetQuarterFromMonthName();
                        dataRow["Earning"] = 0;
                        dataTable.Rows.Add(dataRow);
                    }
                }
            }
            var Member = dataTable.AsEnumerable().GroupBy(x => x.Field<string>("Month"));
            dataTableNew = dataTable.Clone();
            foreach (var group in Member)
            {
                DataRow dtRow = dataTableNew.NewRow();
                dtRow["Month"] = group.Key;
                dtRow["Earning"] = group.Sum(x => x.Field<int>("Earning"));
                dataTableNew.Rows.Add(dtRow);
                lstrItem = Convert.ToString(dtRow["Month"]) + " : " + Convert.ToString(dtRow["Earning"]);
                listViewMonthlyAnalysis.Items.Add(lstrItem);
            }
            return dataTableNew;
        }
        #endregion

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadParameter();
            LoadChart();
        }

        private void checkedListUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadParameter();
            LoadChart();
        }
    }
}
