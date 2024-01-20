using ExpensesTracker.BusinessObject;
using ExpensesTracker.Project.Share.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLibrary;

namespace ExpensesTracker.Project.Share.Business.ChartTypeProduct
{
    internal class QuarterlyChart : IAnalysisChart
    {
        public DataTable FetchDataFromTable()
        {
            string query = GlobalFunction.GetQueryById(Constant.Query.LOAD_MONTHLY_CHART_SHARE);
            //query = string.Format(query, _UserParameter, 0);
            DataTable ldtbTable = DBFunction.FetchDataFromDatabase(Constant.Common.DATABASE_NAME, query);

            return ldtbTable;
        }

        public DataTable GetDataTableFromQueryData(DataTable adtbTable)
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
            return dataTableNew;
        }
    }
}
