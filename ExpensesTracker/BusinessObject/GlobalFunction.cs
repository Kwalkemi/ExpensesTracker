using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
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
            string istrPath = System.IO.Path.Combine(Application.StartupPath, Constant.Common.XML);
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
        /// <param name="Id"></param>
        /// <returns></returns>
        public static string GetUserNameById(int Id)
        {
            string lstrFullName = string.Empty;
            string istrPath = System.IO.Path.Combine(Application.StartupPath, Constant.Common.XML);
            string str = XmlFunction.GetQueriesById(istrPath, Constant.Common.ENTITY_NAME, Constant.Query.GET_USER_INFO_BY_ID);
            str = String.Format(str, Id);
            DataTable dataTable = DBFunction.FetchDataFromDatabase(Constant.Common.DATABASE_NAME, str);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                lstrFullName = Convert.ToString(dataTable.Rows[0][TableEnum.enmLogin_Info.USERNAME.ToString()]);
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
            string istrPath = System.IO.Path.Combine(Application.StartupPath, Constant.Common.XML);
            return XmlFunction.GetMessageById(istrPath, Constant.Common.ENTITY_NAME, astrMessage);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="astrMessage"></param>
        /// <returns></returns>
        public static string GetQueryById(string astrMessage)
        {
            string istrPath = System.IO.Path.Combine(Application.StartupPath, Constant.Common.XML);
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
            int num = 0;
            if (aintnum == 0)
                return 0;
            if ((aintnum < 0 && aintnum > -1000) || (aintnum > 0 && aintnum < 1000))
            {
                if (aintnum > 0 && aintnum < 100)
                {
                    return 10;
                }
                else if(aintnum < 0 && aintnum > -100)
                {
                    return -10;
                }
                else
                {
                    num = (aintnum / 100) + 1;
                    num = num * 100;
                }
            }
            else
            {
                num = (aintnum / 1000) + 1;
                num = num * 1000;
            }
            return num;
        }

        /// <summary>
        /// Get the ceiling number
        /// </summary>
        /// <param name="aintnum"></param>
        /// <param name="withRef">with reference of</param>
        /// <returns></returns>
        public static int GetCeilingNumber(this decimal aintnum, int withRef)
        {
            decimal num = 0;
            if (aintnum == 0)
                return 0;
            if ((aintnum < 0 && aintnum > -1000) || (aintnum > 0 && aintnum < 1000))
            {
                if (aintnum > 0 && aintnum < 100)
                {
                    return 10;
                }
                else if (aintnum < 0 && aintnum > -100)
                {
                    return -10;
                }
                else
                {
                    num = (aintnum / 100) + 1;
                    num = num * 100;
                }
            }
            else
            {
                num = (aintnum / 1000) + 1;
                num = num * 1000;
            }
            return Convert.ToInt32(num);
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

        public static string GetQuarterFromMonthName(this string astrMonth)
        {
            switch (astrMonth)
            {
                case "January":
                case "February":
                case "March":
                    {
                        return "1st-Qtr";
                    }
                case "April":
                case "May":
                case "June":
                    {
                        return "2nd-Qtr";
                    }
                case "July":
                case "August":
                case "September":
                    {
                        return "3rd-Qtr";
                    }
                case "October":
                case "November":
                case "December":
                    {
                        return "4th-Qtr";
                    }
                default:
                    return "No Qtr";
            }
        }


        public static string pdfText()
        {
            //PdfReader reader = new PdfReader(@"C:\Users\HP\Desktop\statement\ABC.pdf");
            string text = string.Empty;

            //for (int page = 1; page <= reader.NumberOfPages; page++)
            //{
            //    text += PdfTextExtractor.GetTextFromPage(reader, page);
            //}
            //reader.Close();


            using (var doc = WordprocessingDocument.Open(@"C:\Users\HP\Desktop\statement\ABC.docx", false))
            {
                // To create a temporary table   
                DataTable dt = new DataTable();
                int rowCount = 0;

                // Find the first table in the document.   
                List<Table> lsttable = doc.MainDocumentPart.Document.Body.Elements<Table>().ToList();

                foreach (Table table in lsttable)
                {
                     rowCount = 0;
                    dt = new DataTable();
                    // To get all rows from table  
                    IEnumerable<TableRow> rows = table.Elements<TableRow>();

                    try
                    {
                        // To read data from rows and to add records to the temporary table  
                        foreach (TableRow row in rows)
                        {
                            if (rowCount == 0)
                            {
                                foreach (TableCell cell in row.Descendants<TableCell>())
                                {
                                    dt.Columns.Add(cell.InnerText);
                                }
                                rowCount += 1;
                            }
                            else
                            {
                                dt.Rows.Add();
                                int i = 0;
                                foreach (TableCell cell in row.Descendants<TableCell>())
                                {
                                    dt.Rows[dt.Rows.Count - 1][i] = cell.InnerText;
                                    i++;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
                // To display the result   
                // Bind datatable(temporary table) to the datagridview   
                //dgvTable.DataSource = dt;
            }








            return text;
        }

        public static string XMPPDFParser(string astrNode)
        {
            StringBuilder lstrbNodeData = new StringBuilder();
            string lstrNode = astrNode ?? "EBN";
            try
            {
                var lReader = File.ReadLines(@"C:\Users\HP\Desktop\statement\ABC.pdf");
                int lintStartIndex = 0, lintLastIndex = 0;
                lintStartIndex = lReader.ToList().FindIndex(x => x.StartsWith("<" + lstrNode));
                if (lstrNode != "EBN" && lintStartIndex == -1)
                {
                    lstrNode = "EBN";
                    lintStartIndex = lReader.ToList().FindIndex(x => x.StartsWith("<" + lstrNode));
                }
                lintLastIndex = lReader.ToList().FindIndex(x => x.StartsWith("</" + lstrNode + ">"));
                string[] larrOutput = lReader.ToList().GetRange(lintStartIndex, lintLastIndex - lintStartIndex + 1).ToArray();
                foreach (string lstrLines in larrOutput)
                {
                    string lstTempData = lstrLines;
                    if (lstrLines.ToLower().Contains("code>"))
                    {
                        int lstrFirstPartLength = lstrLines.Substring(0, lstrLines.IndexOf("</")).Length;
                        string lstrCodeTrimData = lstrLines.Substring(0, lstrLines.IndexOf("</")).TrimEnd();
                        string lstrCodeend = lstrLines.Substring(lstrLines.IndexOf("</"), lstrLines.Length - lstrFirstPartLength);
                        lstTempData = lstrCodeTrimData + lstrCodeend;
                    }
                    lstrbNodeData.Append(lstTempData);
                    lstrbNodeData.AppendLine();
                }
            }
            catch (Exception ex)
            {
                
            }
            return lstrbNodeData.ToString();
        }
    }
}
