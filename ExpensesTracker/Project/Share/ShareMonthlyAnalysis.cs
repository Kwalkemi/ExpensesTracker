using ExpensesTracker.BusinessObject;
using ExpensesTracker.Project.Share.Business;
using ExpensesTracker.Project.Share.Business.Factory;
using ExpensesTracker.Project.Share.Interface;
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

        public string ChartType { get; set; }

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
                ChartType = AnalysisEnum.MONTHLY.ToString();
            }
            else if (Convert.ToString(cmbChartType.SelectedItem) == Constant.Common.ChartType.QUARTERLY)
            {
                Year_Parameter = Convert.ToInt32(cmbYear.SelectedItem);
                ChartType = AnalysisEnum.QUARTERLY.ToString();
            }
            else if (Convert.ToString(cmbChartType.SelectedItem) == Constant.Common.ChartType.YEARLY)
            {
                Year_Parameter = Convert.ToInt32(cmbYear.SelectedItem);
                ChartType = AnalysisEnum.YEARLY.ToString();
            }
        }

        private void LoadChart()
        {
            chartMonthlyExpenses.Series.Clear();
            chartMonthlyExpenses.ChartAreas[0].AxisY.Minimum = 0;
            chartMonthlyExpenses.ChartAreas[0].Name = "Share_Analysis";

            ChartTypeFactory chartTypeFactory = new ChartTypeFactory(ChartType);
            chartTypeFactory.Year = Year_Parameter;
            IAnalysisChart analysisChart = chartTypeFactory.ChartTypeFactoryMethod();

            DataTable ldtbTable = analysisChart.FetchDataFromTable();
            DataTable ldtbTableMain = analysisChart.GetDataTableFromQueryData(ldtbTable);

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
                listViewMonthlyAnalysis.Items.Clear();
                foreach (DataRow dr in ldtbTableMain.Rows)
                {
                    string lstrItem = string.Empty;
                    if (Convert.ToString(cmbChartType.SelectedItem) == Constant.Common.ChartType.YEARLY)
                    {
                        chartMonthlyExpenses.Series[Year_Parameter.ToString()].Points.AddXY(dr["Year"], dr["Earning"]);
                        lstrItem = Convert.ToString(dr["Year"]) + " : " + Convert.ToString(dr["Earning"]);
                    }
                    else
                    {
                        chartMonthlyExpenses.Series[Year_Parameter.ToString()].Points.AddXY(dr["Month"], dr["Earning"]);
                        lstrItem = Convert.ToString(dr["Month"]) + " : " + Convert.ToString(dr["Earning"]);
                    }
                    listViewMonthlyAnalysis.Items.Add(lstrItem);
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
