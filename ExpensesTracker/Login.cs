using ExpensesTracker.BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserLibrary;

namespace ExpensesTracker
{
    public partial class Login : Form
    {
        public Login()
        {
            istrPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + Constant.Common.XML;
            InitializeComponent();
        }

        public static int UserId = 0;
        private string istrPath { get; set; }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == string.Empty)
            {
                errorProvider1.SetError(txtUser, XmlFunction.GetMessageById(istrPath, Constant.Common.ENTITY_NAME, Constant.Error.ERROR_2));
            }
            if(txtpassword.Text == string.Empty)
            {
                errorProvider1.SetError(txtpassword, XmlFunction.GetMessageById(istrPath, Constant.Common.ENTITY_NAME, Constant.Error.ERROR_3));
            }
            if (txtUser.Text != string.Empty && txtpassword.Text != string.Empty)
            {
                errorProvider1.Clear();
                string str = XmlFunction.GetQueriesById(istrPath, Constant.Common.ENTITY_NAME, Constant.Queryies.GET_USER_INFO);
                str = String.Format(str, txtUser.Text, txtpassword.Text);

                string result = DBFunction.FetchScalarFromDatabase(Constant.Common.DATABASE_NAME, str);
                if (result != string.Empty && Convert.ToInt32(result) > 0)
                {
                    Login.UserId = Convert.ToInt32(result);
                    if (checkBoxRemember.Checked)
                    {
                        str = XmlFunction.GetQueriesById(istrPath, Constant.Common.ENTITY_NAME, Constant.Queryies.UPDATE_REMEMBER_ME_CODE_VALUE);
                        str = String.Format(str, Login.UserId);
                        DBFunction.UpdateTable(Constant.Common.DATABASE_NAME, str);
                    }
                    //this.Hide();
                    //Share form1 = new Share();
                    //form1.Show();
                }
                else
                {
                    MessageBox.Show(XmlFunction.GetMessageById(istrPath, Constant.Common.ENTITY_NAME, Constant.Error.ERROR_1));
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }
    }
}
