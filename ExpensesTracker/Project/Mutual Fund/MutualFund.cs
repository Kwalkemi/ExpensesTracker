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

namespace ExpensesTracker.Project.Mutual_Fund
{
    public partial class MutualFund : Form
    {
        public MutualFund()
        {
            InitializeComponent();
        }

        #region Properties

        public int iintUpdateId { get; set; }
        public static int MutualFundHeaderId = 0;
        public static string DematAccount = string.Empty;

        #endregion


        private void btnAddMutualFundHeader_Click(object sender, EventArgs e)
        {
            if (MutualFund.DematAccount.IsNotNullOrEmpty() && txtMutualFundName.Text.IsNotNullOrEmpty())
            {
                Dictionary<string, string> ldict = new Dictionary<string, string>();

                ldict.Add(TableEnum.enmMutualFundHeader.DEMAT_ACCOUNT_ID.ToString(), Constant.Common.CodeId.CODE_ID_8);
                ldict.Add(TableEnum.enmMutualFundHeader.DEMAT_ACCOUNT_VALUE.ToString(), DematAccount);

                ldict.Add(TableEnum.enmMutualFundHeader.MUTUAL_FUND_NAME.ToString(), txtMutualFundName.Text);
                ldict.Add(TableEnum.enmMutualFundHeader.USER_ID.ToString(), Convert.ToString(Login.UserId));
                ldict.Add(TableEnum.enmMutualFundHeader.EXIT_LOAD.ToString(), txtboxExitLoad.Text);

                string str = dateStartDateMutual.Value.ToString(Constant.Common.DATE_FORMAT) + Constant.Common.SPACE + dateStartDateMutual.Value.ToLongTimeString();
                ldict.Add(TableEnum.enmMutualFundHeader.MUTUAL_FUND_CREATED_DATE.ToString(), str);
                if (checkBoxIsSip.Checked)
                    ldict.Add(TableEnum.enmMutualFundHeader.IS_SIP.ToString(), "1");
                else
                    ldict.Add(TableEnum.enmMutualFundHeader.IS_SIP.ToString(), "0");
                int id = DBFunction.InsertIntoTable(Constant.Common.DATABASE_NAME, TableEnum.enmTableName.MUTUAL_FUND_HEADER.ToString(), ldict);
            }
            if(MutualFund.DematAccount.IsNullOrEmpty())
            {
                errorProvidermutual.SetError(btnAddMutualFundHeader, GlobalFunction.GetMessageById(Constant.Error.ERROR_17));
            }
            if (txtMutualFundName.Text.IsNullOrEmpty())
            {
                errorProvidermutual.SetError(txtMutualFundName, GlobalFunction.GetMessageById(Constant.Error.ERROR_18));
            }
            LoadForm();
        }

        private void MutualFund_Load(object sender, EventArgs e)
        {
            string lstrQuery = GlobalFunction.GetQueryById(Constant.Query.GET_DEMAT_ACCOUNT_NAME);
            DataTable dataTable = DBFunction.FetchDataFromDatabase(Constant.Common.DATABASE_NAME, lstrQuery);
            MyComboBox myComboBoxMain = new MyComboBox();
            myComboBoxMain.Text = "Select Item";
            myComboBoxMain.Value = "";
            cmbDematAccountMutual.Items.Add(myComboBoxMain);
            foreach (DataRow dr in dataTable.Rows)
            {
                MyComboBox myComboBox = new MyComboBox();
                myComboBox.Text = GeneralFunction.GetStringValueFromDataRow(dr, TableEnum.enmCode_Value.CODE_VALUE_DESCRIPTION.ToString());
                myComboBox.Value = GeneralFunction.GetStringValueFromDataRow(dr, TableEnum.enmCode_Value.CODE_VALUE.ToString());
                cmbDematAccountMutual.Items.Add(myComboBox);
            }
            cmbDematAccountMutual.SelectedIndex = 0;
            lblUserName.Text = GlobalFunction.GetFullNameById(Login.UserId);
        }

        private void cmbDematAccountMutual_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lstrDematAccount = Convert.ToString(((MyComboBox)cmbDematAccountMutual.SelectedItem).Value);
            if (lstrDematAccount.IsNotNullOrEmpty())
                DematAccount = lstrDematAccount;
            else
            {
                DematAccount = string.Empty;
            }
            LoadForm();
        }


        private void LoadForm()
        {
            lblUserName.Text = GlobalFunction.GetFullNameById(Login.UserId);
            this.mUTUAL_FUND_HEADER_PROCEDURETableAdapter.Fill(this.mutual_FundDataSet.MUTUAL_FUND_HEADER_PROCEDURE, Login.UserId, MutualFund.DematAccount);
        }

        private void btnUpdateDelivery_Click(object sender, EventArgs e)
        {
            string lstrQuery = GlobalFunction.GetQueryById(Constant.Query.UPDATE_MUTUAL_FUND_HEADER);
            string lstrIsSip = checkBoxIsSip.Checked == true ? "1" : "0";
            string strDate = dateStartDateMutual.Value.ToString(Constant.Common.DATE_FORMAT) + Constant.Common.SPACE + dateStartDateMutual.Value.ToLongTimeString();

            lstrQuery = string.Format(lstrQuery, txtMutualFundName.Text, strDate, txtboxExitLoad.Text, lstrIsSip ,iintUpdateId);
            DBFunction.UpdateTable(Constant.Common.DATABASE_NAME, lstrQuery);
            LoadForm();
        }

        private void dataGridViewMutualFund_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMutualFund.Rows[e.RowIndex].Cells[7].Selected)
            {
                MutualFundHeaderId = Convert.ToInt32(dataGridViewMutualFund.Rows[e.RowIndex].Cells[0].Value);
                MutualFundDetail mutualFundDetail = new MutualFundDetail();
                mutualFundDetail.Show();
            }
            iintUpdateId = Convert.ToInt32(dataGridViewMutualFund.Rows[e.RowIndex].Cells[0].Value);
            txtboxExitLoad.Text = Convert.ToString(dataGridViewMutualFund.Rows[e.RowIndex].Cells[4].Value);
            txtMutualFundName.Text = Convert.ToString(dataGridViewMutualFund.Rows[e.RowIndex].Cells[1].Value);
            if (Convert.ToBoolean(dataGridViewMutualFund.Rows[e.RowIndex].Cells[5].Value) == true)
                checkBoxIsSip.Checked = true;
            else
                checkBoxIsSip.Checked = false;
            dateStartDateMutual.Value = Convert.ToDateTime(dataGridViewMutualFund.Rows[e.RowIndex].Cells[6].Value);
            lblBuyId.Text = lblSellId.Text = iintUpdateId.ToString();
        }

        private void lnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MutualFund.DematAccount = string.Empty;
            this.Hide();
            ExpensesMain expenses = new ExpensesMain();
            expenses.Show();
        }

        private void btnMutualFundAdd_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> ldict = new Dictionary<string, string>();
            if (lblBuyId.Text != string.Empty)
            {
                ldict.Add(TableEnum.enmMutualFundBuy.MUTUAL_FUND_HEADER_ID.ToString(), lblBuyId.Text);
                ldict.Add(TableEnum.enmMutualFundBuy.MUTUAL_FUND_AMOUNT.ToString(), txtBuyPrice.Text);
                ldict.Add(TableEnum.enmMutualFundBuy.MUTUAL_FUND_QUANTITY.ToString(), txtBuyQty.Text);
                ldict.Add(TableEnum.enmMutualFundBuy.MUTUAL_FUND_DATE.ToString(), Convert.ToDateTime(dateBuyMF.Text).ToString(Constant.Common.DATE_FORMAT_yyyy_MM_dd));
                if (txtBuyCharges.Text != string.Empty)
                    ldict.Add(TableEnum.enmMutualFundBuy.MUTUAL_FUND_CHARGES.ToString(), txtBuyCharges.Text);
                DBFunction.InsertIntoTable(Constant.Common.DATABASE_NAME, TableEnum.enmTableName.MUTUAL_FUND_BUY.ToString(), ldict);
            }
            else
            {
                errorProvidermutual.SetError(panelbuy, GlobalFunction.GetMessageById(Constant.Error.ERROR_14));
            }
            LoadForm();
        }
    }
}
