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

namespace ExpensesTracker.Project.HusbandWife
{
    /// <summary>
    /// 
    /// </summary>
    public partial class HusbandWife : Form
    {
        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        public HusbandWife()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        public int iintResult { get; set; }
        public int iintUpdateId { get; set; }
        #endregion

        #region Private Methods

        /// <summary>
        /// 
        /// </summary>
        private void LoadForm()
        {
            this.hUSBANDWIFEPROCEDURETableAdapter.Fill(this.husband_WifeDataSet.HUSBANDWIFEPROCEDURE);
            lblHusbandWifeUser.Text = GlobalFunction.GetFullNameById(Login.UserId);

            LoadCategory();
            Sum();
            Result();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="astrType"></param>
        /// <param name="astrAmt"></param>
        /// <param name="adttime"></param>
        /// <param name="aintCategoryId"></param>
        private void AddAmount(string astrType, string astrAmt, string adttime, string aintCategoryId)
        {
            Dictionary<string, string> ldict = new Dictionary<string, string>();
            ldict.Add(TableEnum.enmHusband_Wife.HUSBAND_WIFE_TYPE_VALUE.ToString(), astrType);
            ldict.Add(TableEnum.enmHusband_Wife.HUSBAND_WIFE_AMT.ToString(), astrAmt);
            ldict.Add(TableEnum.enmHusband_Wife.HUSBAND_WIFE_DATE.ToString(), adttime);
            ldict.Add(TableEnum.enmHusband_Wife.EXPENSES_CATEGORY_ID.ToString(), aintCategoryId);
            ldict.Add(TableEnum.enmHusband_Wife.HUSBAND_WIFE_TYPE_ID.ToString(), Constant.Common.CodeId.CODE_ID_2);
            DBFunction.InsertIntoTable(Constant.Common.DATABASE_NAME, TableEnum.enmTableName.HUSBAND_WIFE.ToString(), ldict);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="aintId"></param>
        /// <param name="astrAmt"></param>
        /// <param name="adttime"></param>
        /// <param name="ExpenseCtgryId"></param>
        private void UpdateAmount(int aintId, string astrAmt, string adttime, int? ExpenseCtgryId)
        {
            string lstrQuery = "Update Husband_Wife Set Husband_Wife_Amt = " + Convert.ToInt32(astrAmt) + " , Husband_Wife_Date = '" + adttime + "' , EXPENSES_CATEGORY_ID = " + ExpenseCtgryId + " Where Husband_Wife_Id = " + aintId;
            DBFunction.UpdateTable(Constant.Common.DATABASE_NAME, lstrQuery);
        }

        /// <summary>
        /// 
        /// </summary>
        private void Result()
        {
            string Message = string.Empty;
            if (iintResult > 0)
            {
                Message = GlobalFunction.GetMessageById(Constant.Message.HUSBAND_GIVE);
                string.Format(Message, iintResult);
                lblResult.Text = "Husband will give " + iintResult + " Rs to Wife.";
            }
            else if (iintResult < 0)
            {
                Message = GlobalFunction.GetMessageById(Constant.Message.WIFE_EXTRA);
                string.Format(Message, iintResult);
                lblResult.Text = "Wife have " + iintResult + " extra Rs";
            }
            else if (iintResult == 0)
            {
                lblResult.Text = GlobalFunction.GetMessageById(Constant.Message.ALL_CLEAR);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void LoadCategory()
        {
            string lstrQuery = GlobalFunction.GetQueryById(Constant.Query.LOAD_HUSBAND_WIFE_CATEGORY);
            DataTable ldtbTable = DBFunction.FetchDataFromDatabase(Constant.Common.DATABASE_NAME, lstrQuery);
            foreach (DataRow dr in ldtbTable.Rows)
                cmbcategory.Items.Add(Convert.ToString(dr[TableEnum.enmExpenses_Category.EXPENSES_CATEGORY_NAME.ToString()]));
        }

        /// <summary>
        /// 
        /// </summary>
        private void Sum()
        {
            iintResult = dataGridView1.Rows.Cast<DataGridViewRow>().Where(t => Convert.ToString(t.Cells[2].Value) == Constant.Husband_Wife.Record_Type.WIFE).Sum(x => Convert.ToInt32(x.Cells[3].Value))
                - dataGridView1.Rows.Cast<DataGridViewRow>().Where(t => Convert.ToString(t.Cells[2].Value) == Constant.Husband_Wife.Record_Type.HUSBAND).Sum(x => Convert.ToInt32(x.Cells[3].Value));
            iintResult = Math.Abs(iintResult);
        }

        #endregion

        #region Events Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HusbandWife_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            if (Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value) == Constant.Husband_Wife.Record_Type.WIFE)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value) == Constant.Husband_Wife.Record_Type.HUSBAND)
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LimeGreen;
            }
            if (dataGridView1.Rows.Count == (e.RowIndex + 1) || e.RowIndex == 13)
                Result();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWife_Click(object sender, EventArgs e)
        {
            if (txtwifespend.Text == string.Empty)
            {
                errorProvider1.SetError(txtwifespend, GlobalFunction.GetMessageById(Constant.Error.ERROR_11));
            }
            else
            {
                string categoryId = GlobalFunction.GetQueryById(Constant.Query.GET_EXPENSES_CATEGORY_ID_BY_NAME);
                categoryId = string.Format(categoryId, cmbcategory.SelectedItem.ToString());
                string lstrId = DBFunction.FetchScalarFromDatabase(Constant.Common.DATABASE_NAME, categoryId);
                AddAmount(Constant.Husband_Wife.Record_Type.WIFE, txtwifespend.Text, dateTimePickerwife.Text, lstrId);
                this.hUSBANDWIFEPROCEDURETableAdapter.Fill(this.husband_WifeDataSet.HUSBANDWIFEPROCEDURE);
            }
            Sum();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHusband_Click(object sender, EventArgs e)
        {
            if (txthusband.Text == string.Empty)
            {
                errorProvider1.SetError(txthusband, GlobalFunction.GetMessageById(Constant.Error.ERROR_11));
            }
            else if (errorProvider1.GetError(txthusband) == string.Empty)
            {
                AddAmount(Constant.Husband_Wife.Record_Type.HUSBAND, txthusband.Text, Convert.ToString(dateTimePickerhusb.Value), "24");
                this.hUSBANDWIFEPROCEDURETableAdapter.Fill(this.husband_WifeDataSet.HUSBANDWIFEPROCEDURE);
            }
            Sum();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtwifespend_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Int32.Parse(txtwifespend.Text);
                errorProvider1.SetError(txtwifespend, string.Empty);
            }
            catch
            {
                errorProvider1.SetError(txtwifespend, GlobalFunction.GetMessageById(Constant.Error.ERROR_10));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txthusband_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = Int32.Parse(txthusband.Text);
                errorProvider1.SetError(txthusband, string.Empty);
            }
            catch
            {
                errorProvider1.SetError(txthusband, GlobalFunction.GetMessageById(Constant.Error.ERROR_10));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateWife_Click(object sender, EventArgs e)
        {
            if (txtwifespend.Text == string.Empty)
            {
                errorProvider1.SetError(txtwifespend, GlobalFunction.GetMessageById(Constant.Error.ERROR_11));
            }
            else
            {
                DBFunction lDBFunction = new DBFunction();
                string lstrQuery = GlobalFunction.GetQueryById(Constant.Query.GET_EXPENSES_CATEGORY_ID_BY_NAME);
                lstrQuery = string.Format(lstrQuery, cmbcategory.SelectedItem.ToString());
                string Id = DBFunction.FetchScalarFromDatabase(Constant.Common.DATABASE_NAME, lstrQuery);
                UpdateAmount(iintUpdateId, txtwifespend.Text, dateTimePickerwife.Text, Convert.ToInt32(Id));
                this.hUSBANDWIFEPROCEDURETableAdapter.Fill(this.husband_WifeDataSet.HUSBANDWIFEPROCEDURE);
            }
            Sum();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateHusb_Click(object sender, EventArgs e)
        {
            if (txtwifespend.Text == string.Empty)
            {
                errorProvider1.SetError(txthusband, GlobalFunction.GetMessageById(Constant.Error.ERROR_11));
            }
            else if (errorProvider1.GetError(txthusband) == string.Empty)
            {
                UpdateAmount(iintUpdateId, txthusband.Text, Convert.ToString(dateTimePickerhusb.Value), null);
                this.hUSBANDWIFEPROCEDURETableAdapter.Fill(this.husband_WifeDataSet.HUSBANDWIFEPROCEDURE);
            }
            Sum();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iintUpdateId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            if (Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value) == Constant.Husband_Wife.Record_Type.HUSBAND)
            {
                txthusband.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                dateTimePickerhusb.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            }
            else if (Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value) == Constant.Husband_Wife.Record_Type.WIFE)
            {
                txtwifespend.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                dateTimePickerwife.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                cmbcategory.SelectedItem = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCtgry_Click(object sender, EventArgs e)
        {
            DBFunction lDBFunction = new DBFunction();
            Dictionary<string, string> ldict = new Dictionary<string, string>();
            ldict.Add(TableEnum.enmExpenses_Category.EXPENSES_CATEGORY_TABLE_ID.ToString(), Constant.Common.CodeId.CODE_ID_3);
            ldict.Add(TableEnum.enmExpenses_Category.EXPENSES_CATEGORY_TABLE_VALUE.ToString(), Constant.Table_Category_Value.HUSBAND_WIFE_CATEGORY);
            string promptValue = GlobalFunction.ShowAddCategoryDialog("Category Add Box");
            if (promptValue != string.Empty)
            {
                ldict.Add(TableEnum.enmExpenses_Category.EXPENSES_CATEGORY_NAME.ToString(), promptValue);
                DBFunction.InsertIntoTable(Constant.Common.DATABASE_NAME, TableEnum.enmTableName.HUSBAND_WIFE.ToString(), ldict);
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
            string promptValue = GlobalFunction.ShowRemoveCategoryDialog("Category Remove Box", lstItem);
            if (promptValue != string.Empty)
            {
                string lstrQuery = GlobalFunction.GetQueryById(Constant.Query.GET_EXPENSES_CATEGORY_ID_BY_NAME);
                string.Format(lstrQuery, promptValue);
                string Id = DBFunction.FetchScalarFromDatabase(Constant.Common.DATABASE_NAME, lstrQuery);
                lstrQuery = GlobalFunction.GetQueryById(Constant.Query.DELETE_EXPENSES_CATEGORY);
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
            //ExpensesAnalysis form = new ExpensesAnalysis();
            //form.ShowDialog();
        }

        #endregion
    }
}
