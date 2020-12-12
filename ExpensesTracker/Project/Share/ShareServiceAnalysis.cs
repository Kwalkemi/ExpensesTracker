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
    /// Share Service Analysis
    /// </summary>
    public partial class ShareServiceAnalysis : Form
    {
        #region Constructor
        /// <summary>
        /// Constructor of Share Service Analysis
        /// </summary>
        public ShareServiceAnalysis()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties

        /// <summary>
        /// Year Parameter
        /// </summary>
        public int Year_Parameter { get; set; }

        /// <summary>
        /// User Parameter
        /// </summary>
        public int User_Parameter { get; set; }

        /// <summary>
        /// Month Parameter
        /// </summary>
        public int Month_Parameter { get; set; }

        #endregion

        #region Events Method

        private void ShareServiceAnalysis_Load(object sender, EventArgs e)
        {
            cmbChartType.SelectedItem = "Monthly";
            cmbYear.SelectedItem = Convert.ToString(DateTime.Today.Year);
            //cmbMonth.SelectedItem = Convert.ToString(DateTime.Today.Month);
            LoadCombobox();
            LoadUserlist();
            LoadParameter();
            LoadChart();
            LoadList();
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int month = Convert.ToInt32(cmbMonth.SelectedItem.GetType().GetProperty("Value").GetValue(cmbMonth.SelectedItem, null));
            LoadParameter();
            LoadChart();
            LoadList();
        }

        #endregion

        #region Private Methods
        /// <summary>
        /// 
        /// </summary>
        private void LoadCombobox()
        {
            cmbMonth.DisplayMember = "Text";
            cmbMonth.ValueMember = "Value";
            cmbMonth.SelectedItem = " ";
            cmbMonth.Items.Clear();
            if (Convert.ToString(cmbChartType.SelectedItem) == Constant.Common.ChartType.QUARTERLY)
            {
                cmbMonth.Items.Add(new { Text = "1st Quarter", Value = 0 });
                cmbMonth.Items.Add(new { Text = "2nd Quarter", Value = 1 });
                cmbMonth.Items.Add(new { Text = "3rd Quarter", Value = 2 });
                cmbMonth.Items.Add(new { Text = "4th Quarter", Value = 3 });
            }
            else if (Convert.ToString(cmbChartType.SelectedItem) == Constant.Common.ChartType.MONTHLY)
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aintYear"></param>
        /// <param name="aintMonth"></param>
        private void LoadParameter()
        {
            User_Parameter = Login.UserId;
            if (Convert.ToString(cmbChartType.SelectedItem) == Constant.Common.ChartType.MONTHLY)
            {
                if (cmbMonth.SelectedItem != null)
                    Month_Parameter = Convert.ToInt32(cmbMonth.SelectedItem.GetType().GetProperty("Value").GetValue(cmbMonth.SelectedItem, null));
                else
                    Month_Parameter = DateTime.Today.Month;
                Year_Parameter = Convert.ToInt32(cmbYear.SelectedItem);
            }
            else if (Convert.ToString(cmbChartType.SelectedItem) == Constant.Common.ChartType.QUARTERLY)
            {
                Year_Parameter = Convert.ToInt32(cmbMonth.SelectedItem);
            }
        }

        private void LoadChart()
        {
            listViewServiceAnalysis.Clear();
            chartMonthlyExpenses.Series.Clear();
            chartMonthlyExpenses.ChartAreas[0].AxisY.Minimum = 0;
            chartMonthlyExpenses.ChartAreas[0].Name = "MonthlyAnalysisShareService";

            string query = GlobalFunction.GetQueryById(Constant.Query.LOAD_MONTHLY_CHART_SERVICE);
            //Year_Parameter = 2018;
            query = string.Format(query, User_Parameter, Year_Parameter, Month_Parameter);
            DataTable ldtbTable = DBFunction.FetchDataFromDatabase(Constant.Common.DATABASE_NAME, query);

            string month = string.Empty;
            chartMonthlyExpenses.Series.Add(Constant.Common.Alias.SERVICES);
            if (ldtbTable.Rows.Count > 0)
            {
                chartMonthlyExpenses.ChartAreas[0].AxisY.Maximum = ldtbTable.AsEnumerable().Select(x => x.Field<decimal>(Constant.Common.Alias.PROFIT_LOSS)).Max().GetCeilingNumber(1000);
                chartMonthlyExpenses.ChartAreas[0].AxisY.Minimum = ldtbTable.AsEnumerable().Select(x => x.Field<decimal>(Constant.Common.Alias.PROFIT_LOSS)).Min().GetCeilingNumber(1000);
                if (chartMonthlyExpenses.ChartAreas[0].AxisY.Minimum > 0)
                    chartMonthlyExpenses.ChartAreas[0].AxisY.Minimum = 0;
                chartMonthlyExpenses.ChartAreas[0].AxisY.IsStartedFromZero = true;
                chartMonthlyExpenses.ChartAreas[0].AxisX.Interval = 1;
                foreach (DataRow dr in ldtbTable.Rows)
                    chartMonthlyExpenses.Series[Constant.Common.Alias.SERVICES].Points.AddXY(dr[Constant.Common.Alias.SERVICES], dr[Constant.Common.Alias.PROFIT_LOSS]);
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
        private void LoadList()
        {
            DataTable ldtbTable = new DataTable();
            listViewServiceAnalysis.Clear();
            int Total = 0;
            string query = GlobalFunction.GetQueryById(Constant.Query.LOAD_MONTHLY_CHART_SERVICE);
            query = string.Format(query, User_Parameter, Year_Parameter, Month_Parameter);

            ldtbTable = DBFunction.FetchDataFromDatabase(Constant.Common.DATABASE_NAME, query);
            string lstrItem = string.Empty;
            foreach (DataRow dr in ldtbTable.Rows)
            {
                Total = Total + Convert.ToInt32(dr[Constant.Common.Alias.PROFIT_LOSS]);
                lstrItem = Convert.ToString(dr[Constant.Common.Alias.SERVICES]) + " - " + Convert.ToString(dr[Constant.Common.Alias.PROFIT_LOSS]);
                listViewServiceAnalysis.Items.Add(lstrItem);
            }
            lblTotalSpendResult.Text = Total > 0 ? Convert.ToString(Total) : "0";
        }
        #endregion


    }
}
