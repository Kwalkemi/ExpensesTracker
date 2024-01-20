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
    internal class YearlyChart : IAnalysisChart
    {
        
        public DataTable FetchDataFromTable()
        {
            string query = GlobalFunction.GetQueryById(Constant.Query.LOAD_YEARLY_CHART_SHARE);
            DataTable ldtbTable = DBFunction.FetchDataFromDatabase(Constant.Common.DATABASE_NAME, query);

            return ldtbTable;
        }

        public DataTable GetDataTableFromQueryData(DataTable adtbTable)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Year", typeof(string));
            dataTable.Columns.Add("Earning", typeof(Int32));
            string lstrItem = string.Empty;
            List<string> lstNum = new List<string>();
            if (adtbTable.IsNotNull() && adtbTable.Rows.Count > 0)
            {
                for (int i = 2018; i <= DateTime.Now.Year; i++)
                {
                    lstNum.Add(i.ToString());
                    DataRow[] dataRows = adtbTable.Select("SHARE_YEAR = " + i);
                    if (dataRows.Count() > 0)
                    {
                        DataRow dataRow = dataTable.NewRow();
                        dataRow["Year"] = dataRows[0]["SHARE_YEAR"].ToString();
                        dataRow["Earning"] = Convert.ToInt32(dataRows[0]["PROFIT_LOSS"]);
                        dataTable.Rows.Add(dataRow);
                    }
                }
            }
            return dataTable;
        }
    }
}
