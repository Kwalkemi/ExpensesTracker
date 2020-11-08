using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLibrary;

namespace ExpensesTracker.BusinessObject
{
    public static class GlobalFunction
    {
        public static string GetFullNameById(int Id)
        {
            string lstrFullName = string.Empty;
            string istrPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + Constant.Common.XML;
            string str = XmlFunction.GetQueriesById(istrPath, Constant.Common.ENTITY_NAME, Constant.Query.GET_USER_INFO_BY_ID);
            str = String.Format(str, Id);
            DataTable dataTable = DBFunction.FetchDataFromDatabase(Constant.Common.DATABASE_NAME, str);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                lstrFullName = Convert.ToString(dataTable.Rows[0][TableEnum.enmLogin_Info.FIRST_NAME.ToString()]) + Convert.ToString(dataTable.Rows[0][TableEnum.enmLogin_Info.LAST_NAME.ToString()]);
            }
            return lstrFullName;
        }
    }
}
