using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserLibrary;
using ExpensesTracker.Project;
using ExpensesTracker.BusinessObject;
using System.IO;
using System.Reflection;
using System.Web;

namespace ExpensesTracker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new Login());
                //string istrPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + Constant.Common.XML;
                string istrPath = Path.Combine(Application.StartupPath, Constant.Common.XML);
                string str = XmlFunction.GetQueriesById(istrPath, Constant.Common.ENTITY_NAME, Constant.Query.GET_UPDATE_REMEMBER_CODE_VALUE);
                DataTable dataTable = DBFunction.FetchDataFromDatabase(Constant.Common.DATABASE_NAME, str);
                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    if (Convert.ToString(dataTable.Rows[0][TableEnum.enmCode_Value.DATA1.ToString()]) == string.Empty)
                        Application.Run(new Login());
                    else
                    {
                        Login.UserId = Convert.ToInt32(dataTable.Rows[0][TableEnum.enmCode_Value.DATA1.ToString()]);
                        Application.Run(new ExpensesMain());
                    }
                }
                else
                    Application.Run(new ShowIds());
            }
            catch(Exception ex)
            {
                Error.Exception_Msg = ex.Message
                Error.Source = ex.Source;
                Error.Stack_Trace = ex.StackTrace;
                Application.Run(new Error());
            }
        }
    }
}
