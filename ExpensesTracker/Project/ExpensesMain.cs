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

namespace ExpensesTracker.Project
{
    public partial class ExpensesMain : Form
    {
        public ExpensesMain()
        {
            InitializeComponent();
        }

        private void ExpensesMain_Load(object sender, EventArgs e)
        {
            lblUserMain.Text = GlobalFunction.GetFullNameById(Login.UserId);
        }

        private void btnHusbandWife_MouseHover(object sender, EventArgs e)
        {
            btnHusbandWife.BackColor = Color.Red;
        }

        private void btnHusbandWife_MouseLeave(object sender, EventArgs e)
        {
            btnHusbandWife.BackColor = Color.DarkOrange;
        }

        private void btnExpensesTracker_MouseHover(object sender, EventArgs e)
        {
            btnExpensesTracker.BackColor = Color.Red;
        }

        private void btnExpensesTracker_MouseLeave(object sender, EventArgs e)
        {
            btnExpensesTracker.BackColor = Color.DarkOrange;
        }

        private void btnShareTracker_MouseHover(object sender, EventArgs e)
        {
            btnShareTracker.BackColor = Color.Red;
        }

        private void btnShareTracker_MouseLeave(object sender, EventArgs e)
        {
            btnShareTracker.BackColor = Color.DarkOrange;
        }

        private void btnHusbandWife_Click(object sender, EventArgs e)
        {
            this.Hide();
            HusbandWife.HusbandWife husbandWife = new HusbandWife.HusbandWife();
            husbandWife.Show();
        }

        private void btnExpensesTracker_Click(object sender, EventArgs e)
        {
            Application.Run(new Login());
        }

        private void btnShareTracker_Click(object sender, EventArgs e)
        {
            Application.Run(new Login());
        }
    }
}
