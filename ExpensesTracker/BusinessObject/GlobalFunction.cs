using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserLibrary;

namespace ExpensesTracker.BusinessObject
{
    /// <summary>
    /// 
    /// </summary>
    public static class GlobalFunction
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="astrMessage"></param>
        /// <returns></returns>
        public static string GetMessageById(string astrMessage)
        {
            string istrPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + Constant.Common.XML;
            return XmlFunction.GetMessageById(istrPath, Constant.Common.ENTITY_NAME, astrMessage);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="astrMessage"></param>
        /// <returns></returns>
        public static string GetQueryById(string astrMessage)
        {
            string istrPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + Constant.Common.XML;
            return XmlFunction.GetQueriesById(istrPath, Constant.Common.ENTITY_NAME, astrMessage);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="caption"></param>
        /// <returns></returns>
        public static string ShowAddCategoryDialog(string caption)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            TextBox textBox = new TextBox() { Left = 50, Top = 25, Width = 200 };
            Button confirmation = new Button() { Text = "Add", Left = 100, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="caption"></param>
        /// <param name="items"></param>
        /// <returns></returns>
        public static string ShowRemoveCategoryDialog(string caption, List<string> items)
        {
            Form prompt = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            ComboBox combo = new ComboBox() { Left = 60, Top = 25, Width = 150 };
            Button confirmation = new Button() { Text = "Remove", Left = 80, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            foreach (string item in items)
                combo.Items.Add(item);
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(combo);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? Convert.ToString(combo.SelectedItem) : string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aintYear"></param>
        /// <param name="aintMonth"></param>
        /// <returns></returns>
        public static DateTime GetFirstDateOfMonth(this int aintYear, int aintMonth)
        {
            DateTime ldtDate = new DateTime(aintYear, aintMonth, 1);
            return ldtDate;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aintYear"></param>
        /// <param name="aintMonth"></param>
        /// <returns></returns>
        public static DateTime GetLastDateOfMonth(this int aintYear, int aintMonth)
        {
            DateTime ldtDate = new DateTime(aintYear, aintMonth, 1);
            ldtDate = ldtDate.AddMonths(1).AddDays(-1);
            return ldtDate;
        }

        /// <summary>
        /// Get the ceiling number
        /// </summary>
        /// <param name="aintnum"></param>
        /// <param name="withRef">with reference of</param>
        /// <returns></returns>
        public static int GetCeilingNumber(this int aintnum, int withRef)
        {
            int num = (aintnum / 1000) + 1;
            num = num * 1000;
            return num;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aQuarter"></param>
        /// <returns></returns>
        public static List<string> GetMonthNameFromQuarter(this int aQuarter)
        {
            List<string> lstMonth = new List<string>();

            switch (aQuarter)
            {
                case 0:
                    {
                        lstMonth.Add("January");
                        lstMonth.Add("Febuary");
                        lstMonth.Add("March");
                        break;
                    }
                case 1:
                    {
                        lstMonth.Add("April");
                        lstMonth.Add("May");
                        lstMonth.Add("June");
                        break;
                    }
                case 2:
                    {
                        lstMonth.Add("July");
                        lstMonth.Add("August");
                        lstMonth.Add("September");
                        break;
                    }
                case 3:
                    {
                        lstMonth.Add("October");
                        lstMonth.Add("November");
                        lstMonth.Add("December");
                        break;
                    }
            }
            return lstMonth;
        }
    }
}
