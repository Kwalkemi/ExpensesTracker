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
using UserLibrary;

namespace ExpensesTracker.Project.Expenses
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Expenses : Form
    {

        #region Constructor

        /// <summary>
        /// 
        /// </summary>
        public Expenses()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public int iintUpdateId { get; set; }

        #endregion

        #region Events Method

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Expenses_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtItem.Text == string.Empty)
            {
                errorProvider1.SetError(txtItem, GlobalFunction.GetMessageById(Constant.Error.ERROR_12));
            }
            else if (txtAmount.Text == string.Empty)
            {
                errorProvider1.SetError(txtAmount, GlobalFunction.GetMessageById(Constant.Error.ERROR_11));
            }
            else if (!rdoOtging.Checked && !rdiIncmg.Checked)
            {
                errorProvider1.SetError(panel1, GlobalFunction.GetMessageById(Constant.Error.ERROR_13));
            }
            else
            {
                string Expensestype = string.Empty;
                if (rdiIncmg.Checked)
                    Expensestype = Constant.Expenses_Tracker.Transaaction_Type.INCOMING;
                else if (rdoOtging.Checked)
                    Expensestype = Constant.Expenses_Tracker.Transaaction_Type.OUTGOING;

                string categoryId = GlobalFunction.GetQueryById(Constant.Query.GET_EXPENSES_CATEGORY_ID_BY_NAME);
                categoryId = string.Format(categoryId, Constant.Table_Category_Value.EXPENSES_TRACKER_CATEGORY, cmbcategory.SelectedItem.ToString());

                string lstrId = DBFunction.FetchScalarFromDatabase(Constant.Common.DATABASE_NAME, categoryId);
                Dictionary<string, string> ldict = new Dictionary<string, string>();
                ldict.Add(TableEnum.enmExpenses_Tracker.EXPENSES_ITEM.ToString(), txtItem.Text);
                ldict.Add(TableEnum.enmExpenses_Tracker.EXPENSES_DATE.ToString(), Convert.ToString(dateTimePickerExpense.Value));
                ldict.Add(TableEnum.enmExpenses_Tracker.EXPENSES_DATE.ToString(), txtAmount.Text);
                ldict.Add(TableEnum.enmExpenses_Tracker.EXPENSES_CATEGORY_ID.ToString(), lstrId);
                ldict.Add(TableEnum.enmExpenses_Tracker.EXPENSES_TYPE_ID.ToString(), Constant.Common.CodeId.CODE_ID_4);
                ldict.Add(TableEnum.enmExpenses_Tracker.EXPENSES_TYPE_VALUE.ToString(), Expensestype);
                DBFunction.InsertIntoTable(Constant.Common.DATABASE_NAME, TableEnum.enmTableName.EXPENSES_TRACKER.ToString(), ldict);
                LoadForm();
            }
            Sum();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtItem.Text == string.Empty)
            {
                errorProvider1.SetError(txtItem, GlobalFunction.GetMessageById(Constant.Error.ERROR_11));
            }
            else if (txtAmount.Text == string.Empty)
            {
                errorProvider1.SetError(txtAmount, GlobalFunction.GetMessageById(Constant.Error.ERROR_11));
            }
            else
            {
                string Expensestype = string.Empty;
                if (rdiIncmg.Checked)
                    Expensestype = Constant.Expenses_Tracker.Transaaction_Type.INCOMING;
                else if (rdoOtging.Checked)
                    Expensestype = Constant.Expenses_Tracker.Transaaction_Type.OUTGOING;

                string lstrQuery = GlobalFunction.GetQueryById(Constant.Query.GET_EXPENSES_CATEGORY_ID_BY_NAME);
                lstrQuery = string.Format(lstrQuery, Constant.Table_Category_Value.EXPENSES_TRACKER_CATEGORY, cmbcategory.SelectedItem.ToString());
                string Id = DBFunction.FetchScalarFromDatabase(Constant.Common.DATABASE_NAME, lstrQuery);
                lstrQuery = @"Update EXPENSES_TRACKER Set EXPENSES_ITEM = '" + txtItem.Text + "' , EXPENSES_AMT = " + txtAmount.Text +
                    " , EXPENSES_DATE = '" + dateTimePickerExpense.Value + "', EXPENSES_CATEGORY_ID = " + Id + ", EXPENSES_TYPE_VALUE = '" + Expensestype + "' Where EXPENSES_TRACKER_ID = " + iintUpdateId;
                DBFunction.UpdateTable(Constant.Common.DATABASE_NAME, lstrQuery);
                LoadForm();
            }
            Sum();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            iintUpdateId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
            txtItem.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            txtAmount.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            dateTimePickerExpense.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            cmbcategory.SelectedItem = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            if (Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value) == Constant.Expenses_Tracker.Transaaction_Type_Desc.INCOMING)
                rdiIncmg.Checked = true;
            else if (Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value) == Constant.Expenses_Tracker.Transaaction_Type_Desc.OUTGOING)
                rdoOtging.Checked = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCtgry_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> ldict = new Dictionary<string, string>();
            ldict.Add(TableEnum.enmExpenses_Category.EXPENSES_CATEGORY_TABLE_ID.ToString(), Constant.Common.CodeId.CODE_ID_3);
            ldict.Add(TableEnum.enmExpenses_Category.EXPENSES_CATEGORY_TABLE_VALUE.ToString(), Constant.Table_Category_Value.EXPENSES_TRACKER_CATEGORY);
            string promptValue = GlobalFunction.ShowAddCategoryDialog(Constant.Common.CATEGORY_ADD_BOX);
            if (promptValue != string.Empty)
            {
                ldict.Add(TableEnum.enmExpenses_Category.EXPENSES_CATEGORY_NAME.ToString(), promptValue);
                DBFunction.InsertIntoTable(Constant.Common.DATABASE_NAME, TableEnum.enmTableName.EXPENSES_CATEGORY.ToString(), ldict);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRmvCtgry_Click(object sender, EventArgs e)
        {
            DBFunction lDBFunction = new DBFunction();
            List<string> lstItem = new List<string>();
            foreach (string item in cmbcategory.Items)
                lstItem.Add(item);
            string promptValue = GlobalFunction.ShowRemoveCategoryDialog(Constant.Common.CATEGORY_REMOVE_BOX, lstItem);
            if (promptValue != string.Empty)
            {
                string lstrQuery = GlobalFunction.GetQueryById(Constant.Query.GET_EXPENSES_CATEGORY_ID_BY_NAME);
                lstrQuery = string.Format(lstrQuery, Constant.Table_Category_Value.EXPENSES_TRACKER_CATEGORY, cmbcategory.SelectedItem.ToString());
                string Id = DBFunction.FetchScalarFromDatabase(Constant.Common.DATABASE_NAME, lstrQuery);
                lstrQuery = GlobalFunction.GetQueryById(Constant.Query.DELETE_EXPENSES_CATEGORY);
                lstrQuery = string.Format(lstrQuery, Id);
                DBFunction.UpdateTable(Constant.Common.DATABASE_NAME, lstrQuery);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            LoadForm();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            ExpensesAnalysis form = new ExpensesAnalysis();
            form.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            if (Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value) == Constant.Expenses_Tracker.Transaaction_Type_Desc.OUTGOING)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value) == Constant.Expenses_Tracker.Transaaction_Type_Desc.INCOMING)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LimeGreen;
            }
            if (dataGridView1.Rows.Count == (e.RowIndex + 1) || e.RowIndex == 13)
                Sum();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Int32.Parse(txtAmount.Text);
                errorProvider1.SetError(txtAmount, string.Empty);
            }
            catch
            {
                errorProvider1.SetError(txtAmount, GlobalFunction.GetMessageById(Constant.Error.ERROR_11));
            }
        }
        #endregion

        #region Private Method

        private void LoadForm()
        {
            lblExpensesUser.Text = GlobalFunction.GetFullNameById(Login.UserId);
            LoadCategory();
            Sum();
            this.eXPENSES_TRACKER_PROCEDURETableAdapter.Fill(this.expenses_TrackerDataset.EXPENSES_TRACKER_PROCEDURE, Login.UserId);
        }

        /// <summary>
        /// 
        /// </summary>
        private void LoadCategory()
        {

            string lstrQuery = GlobalFunction.GetQueryById(Constant.Query.LOAD_CATEGORY);
            lstrQuery = string.Format(lstrQuery, Constant.Table_Category_Value.EXPENSES_TRACKER_CATEGORY);
            DataTable ldtbTable = DBFunction.FetchDataFromDatabase(Constant.Common.DATABASE_NAME, lstrQuery);
            foreach (DataRow dr in ldtbTable.Rows)
                cmbcategory.Items.Add(Convert.ToString(dr[TableEnum.enmExpenses_Category.EXPENSES_CATEGORY_NAME.ToString()]));
        }

        /// <summary>
        /// 
        /// </summary>
        private void Sum()
        {
            lblValue_Exp.Text = Convert.ToString(dataGridView1.Rows.Cast<DataGridViewRow>().Where(t => Convert.ToString(t.Cells[5].Value) == Constant.Expenses_Tracker.Transaaction_Type_Desc.OUTGOING).Sum(x => Convert.ToInt32(x.Cells[2].Value)));
            lblValue_Amt.Text = Convert.ToString(dataGridView1.Rows.Cast<DataGridViewRow>().Where(t => Convert.ToString(t.Cells[5].Value) == Constant.Expenses_Tracker.Transaaction_Type_Desc.INCOMING).Sum(x => Convert.ToInt32(x.Cells[2].Value)));
            lblValue_Remaining.Text = Convert.ToString(Convert.ToInt32(lblValue_Amt.Text) - Convert.ToInt32(lblValue_Exp.Text));
        }
        #endregion

        private void lnkExpensesBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ExpensesMain expenses = new ExpensesMain();
            expenses.Show();
        }

        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
            string str = GlobalFunction.GetQueryById(Constant.Query.LOG_OFF_QUERY);
            DBFunction.UpdateTable(Constant.Common.DATABASE_NAME, str);
        }
    }
}
