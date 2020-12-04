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

        public static int Login_Info_Id = 0;

        private void ShowIds_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'registration_TrackerDataset.LOGIN_INFO' table. You can move, or remove it, as needed.
            this.lOGIN_INFOTableAdapter.Fill(this.registration_TrackerDataset.LOGIN_INFO);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           Login.UserId = Convert.ToInt32(dataGridViewShow.Rows[e.RowIndex].Cells[0].Value);
            this.Hide();
        }
    }
}
