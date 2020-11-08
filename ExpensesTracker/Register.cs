using ExpensesTracker.BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserLibrary;

namespace ExpensesTracker
{
    public partial class Register : Form
    {
        private string istrPath { get; set; }
        public Register()
        {
            istrPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + Constant.Common.XML;
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> ldict = new Dictionary<string, string>();
            if (txtUsername.Text == string.Empty)
                errorProvider1.SetError(txtPassword, XmlFunction.GetMessageById(istrPath, Constant.Common.ENTITY_NAME, Constant.Error.ERROR_2));
            else
                ldict.Add(TableEnum.enmLogin_Info.USERNAME.ToString(), txtUsername.Text); 
            if (txtPassword.Text == string.Empty)
                errorProvider1.SetError(txtPassword, XmlFunction.GetMessageById(istrPath, Constant.Common.ENTITY_NAME, Constant.Error.ERROR_3));
            if (txtConfirmPassword.Text == string.Empty)
                errorProvider1.SetError(txtConfirmPassword, XmlFunction.GetMessageById(istrPath, Constant.Common.ENTITY_NAME, Constant.Error.ERROR_4));
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                errorProvider1.SetError(txtPassword, XmlFunction.GetMessageById(istrPath, Constant.Common.ENTITY_NAME, Constant.Error.ERROR_5));
                errorProvider1.SetError(txtConfirmPassword, XmlFunction.GetMessageById(istrPath, Constant.Common.ENTITY_NAME, Constant.Error.ERROR_5));
            }
            else
                ldict.Add(TableEnum.enmLogin_Info.PASSWORD.ToString(), txtPassword.Text);
            if (txtFirstname.Text == string.Empty)
                errorProvider1.SetError(txtPassword, XmlFunction.GetMessageById(istrPath, Constant.Common.ENTITY_NAME, Constant.Error.ERROR_6));
            else
                ldict.Add(TableEnum.enmLogin_Info.FIRST_NAME.ToString(), txtFirstname.Text);
            if (txtlastname.Text == string.Empty)
                errorProvider1.SetError(txtPassword, XmlFunction.GetMessageById(istrPath, Constant.Common.ENTITY_NAME, Constant.Error.ERROR_7));
            else
                ldict.Add(TableEnum.enmLogin_Info.LAST_NAME.ToString(), txtlastname.Text);
            
            if (!radioMale.Checked && !radioFemale.Checked)
            {
                errorProvider1.SetError(radioFemale, XmlFunction.GetMessageById(istrPath, Constant.Common.ENTITY_NAME, Constant.Error.ERROR_8));
            }
            else
            {
                string str = radioMale.Checked ? Constant.Common.Gender.MALE : radioFemale.Checked ? Constant.Common.Gender.FEMALE : string.Empty;
                ldict.Add(TableEnum.enmLogin_Info.GENDER.ToString(), str);
            }
            int Id = DBFunction.InsertIntoTable(Constant.Common.DATABASE_NAME, TableEnum.enmTableName.LOGIN_INFO.ToString(), ldict);
            if (Id > 0)
            {
                MessageBox.Show(XmlFunction.GetMessageById(istrPath, Constant.Common.ENTITY_NAME, Constant.Message.REGISTRATION_SUCCESSFULY));
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        /// <summary>
        /// Validation Text Changed Method
        /// </summary>
        /// <param name="sender">Pass the object of sender</param>
        /// <param name="e">Pass the parameter of e</param>
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (!txtUsername.Text.Contains(Constant.Common.SPECIAL_CHARACTER_AT_THE_RATE) || !txtUsername.Text.Contains(Constant.Common.DOT_COM))
            {
                errorProvider1.SetError(txtUsername, XmlFunction.GetMessageById(istrPath, Constant.Common.ENTITY_NAME, Constant.Error.ERROR_9));
            }
            else
            {
                errorProvider1.SetError(txtUsername, string.Empty);
            }
        }
    }
}
