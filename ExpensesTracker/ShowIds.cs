using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpensesTracker
{
    public partial class ShowIds : Form
    {
        public ShowIds()
        {
            InitializeComponent();
        }

        private void ShowIds_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registration_TrackerDataset.LOGIN_INFO' table. You can move, or remove it, as needed.
            this.lOGIN_INFOTableAdapter.Fill(this.registration_TrackerDataset.LOGIN_INFO);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string lstrUserId = Convert.ToString(dataGridViewShow.Rows[e.RowIndex].Cells[1].Value);
            string lstrPassword = Convert.ToString(dataGridViewShow.Rows[e.RowIndex].Cells[2].Value);
            this.Hide();
            Login parent = (Login)this.Owner;
            parent.SetText(lstrUserId, lstrPassword);
        }
    }
}
