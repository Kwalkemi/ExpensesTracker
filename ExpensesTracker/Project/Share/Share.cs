﻿using ExpensesTracker.BusinessObject;
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

namespace ExpensesTracker.Project.Share
{
    public partial class Share : Form
    {
        #region Constructor
        public Share()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties

        public int iintUpdateId { get; set; }
        public static int ShareHeaderId = 0;
        public static string DematAccount = string.Empty;

        #endregion

        #region Events Method

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Share_Load(object sender, EventArgs e)
        {
            string lstrQuery = GlobalFunction.GetQueryById(Constant.Query.GET_DEMAT_ACCOUNT_NAME);
            DataTable dataTable = DBFunction.FetchDataFromDatabase(Constant.Common.DATABASE_NAME, lstrQuery);
            MyComboBox myComboBoxMain = new MyComboBox();
            myComboBoxMain.Text = "Select Item";
            myComboBoxMain.Value = "";
            comboBoxDematAccount.Items.Add(myComboBoxMain);
            foreach (DataRow dr in dataTable.Rows)
            {
                MyComboBox myComboBox = new MyComboBox();
                myComboBox.Text = GeneralFunction.GetStringValueFromDataRow(dr, TableEnum.enmCode_Value.CODE_VALUE_DESCRIPTION.ToString());
                myComboBox.Value = GeneralFunction.GetStringValueFromDataRow(dr, TableEnum.enmCode_Value.CODE_VALUE.ToString());
                comboBoxDematAccount.Items.Add(myComboBox);
            }
            comboBoxDematAccount.SelectedIndex = 0;
            lblUserName.Text = GlobalFunction.GetFullNameById(Login.UserId);
            lblBuyId.Text = string.Empty;
            lblSellId.Text = string.Empty;
            lblBuyOption.Text = string.Empty;
            lblSelloption.Text = string.Empty;
            lblExtraChargeIdValue.Text = string.Empty;
            lblTotalValueDelivery.Text = string.Empty;
            lblPayInPayOutValue.Text = string.Empty;
            lblShareHeaderIdValue.Text = string.Empty;
            lblShareDividendIdValue.Text = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShareHeader_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> ldict = new Dictionary<string, string>();

            ldict.Add(TableEnum.enmSharesTrackerHeader.SHARE_TYPE_CODE_ID.ToString(), Constant.Common.CodeId.CODE_ID_5);
            ldict.Add(TableEnum.enmSharesTrackerHeader.DEMAT_ACCOUNT_ID.ToString(), Constant.Common.CodeId.CODE_ID_8);
            ldict.Add(TableEnum.enmSharesTrackerHeader.DEMAT_ACCOUNT_VALUE.ToString(), DematAccount);
            if (DeliveryTab.CanFocus)
            {
                ldict.Add(TableEnum.enmSharesTrackerHeader.SHARE_TYPE_CODE_VALUE.ToString(), Constant.Shares_Tracker.Shares_Type.DELIVERY);
                ldict.Add(TableEnum.enmSharesTrackerHeader.SHARES_NAME.ToString(), txtShareNameDelivery.Text);
                if (chkIsIntraday.Checked)
                    ldict.Add(TableEnum.enmSharesTrackerHeader.IS_INTRADAY.ToString(), Constant.Common.Bit_Value.BIT_1);
                else
                    ldict.Add(TableEnum.enmSharesTrackerHeader.IS_INTRADAY.ToString(), Constant.Common.Bit_Value.BIT_0);
            }
            else if (OptionTab.CanFocus)
            {
                ldict.Add(TableEnum.enmSharesTrackerHeader.SHARE_TYPE_CODE_VALUE.ToString(), Constant.Shares_Tracker.Shares_Type.OPTION);
                ldict.Add(TableEnum.enmSharesTrackerHeader.SHARES_NAME.ToString(), txtShareNameOption.Text);
                ldict.Add(TableEnum.enmSharesTrackerHeader.IS_INTRADAY.ToString(), Constant.Common.Bit_Value.BIT_0);
            }
            ldict.Add(TableEnum.enmSharesTrackerHeader.USER_ID.ToString(), Convert.ToString(Login.UserId));
            ldict.Add(TableEnum.enmSharesTrackerHeader.SERVICE_CODE_ID.ToString(), Constant.Common.CodeId.CODE_ID_7);
            ldict.Add(TableEnum.enmSharesTrackerHeader.SERVICE_CODE_VALUE.ToString(), ((KeyValuePair<string, string>)cmbSeviceDelivery.SelectedItem).Key);

            int id = DBFunction.InsertIntoTable(Constant.Common.DATABASE_NAME, TableEnum.enmTableName.SHARES_TRACKER_HEADER.ToString(), ldict);
            if (id != 0)
            {
                if (DeliveryTab.CanFocus)
                {
                    lblBuyId.Text = Convert.ToString(id);
                    lblSellId.Text = Convert.ToString(id);
                }
                else if (OptionTab.CanFocus)
                {
                    lblBuyOption.Text = Convert.ToString(id);
                    lblSelloption.Text = Convert.ToString(id);
                }
            }
            LoadForm();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateHeader_Click(object sender, EventArgs e)
        {
            string lstrQuery = GlobalFunction.GetQueryById(Constant.Query.UPDATE_SHARE_HEADER);
            lstrQuery = string.Format(lstrQuery, txtShareNameDelivery.Text, ((KeyValuePair<string, string>)cmbSeviceDelivery.SelectedItem).Key, iintUpdateId);
            DBFunction.UpdateTable(Constant.Common.DATABASE_NAME, lstrQuery);
            LoadForm();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShareBuyAdd_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> ldict = new Dictionary<string, string>();
            if (DeliveryTab.CanFocus)
            {
                if (lblBuyId.Text != string.Empty)
                {
                    ldict.Add(TableEnum.enmSharesTrackerBuy.SHARES_TRACKER_HEADER_ID.ToString(), lblBuyId.Text);
                    ldict.Add(TableEnum.enmSharesTrackerBuy.SHARES_PRICE_AMT.ToString(), txtBuyPrice.Text);
                    ldict.Add(TableEnum.enmSharesTrackerBuy.SHARES_QUANTITY.ToString(), txtBuyQty.Text);
                    ldict.Add(TableEnum.enmSharesTrackerBuy.SHARES_BUY_DATE.ToString(), Convert.ToDateTime(dateBuy.Text).ToString(Constant.Common.DATE_FORMAT_yyyy_MM_dd));
                    if (txtBuyCharges.Text != string.Empty)
                        ldict.Add(TableEnum.enmSharesTrackerBuy.SHARES_CHARGES_AMT.ToString(), txtBuyCharges.Text);
                    DBFunction.InsertIntoTable(Constant.Common.DATABASE_NAME, TableEnum.enmTableName.SHARES_TRACKER_BUY.ToString(), ldict);
                }
                else
                {
                    errorProvider1.SetError(panelbuy, GlobalFunction.GetMessageById(Constant.Error.ERROR_14));
                }
            }
            else if (OptionTab.CanFocus)
            {
                if (lblBuyOption.Text != string.Empty)
                {
                    ldict.Add(TableEnum.enmSharesTrackerBuy.SHARES_TRACKER_HEADER_ID.ToString(), lblBuyOption.Text);
                    ldict.Add(TableEnum.enmSharesTrackerBuy.SHARES_PRICE_AMT.ToString(), txtBuyPriceOptn.Text);
                    ldict.Add(TableEnum.enmSharesTrackerBuy.SHARES_QUANTITY.ToString(), txtBuyQtyOptn.Text);
                    ldict.Add(TableEnum.enmSharesTrackerBuy.SHARES_BUY_DATE.ToString(), Convert.ToDateTime(dateBuyOptn.Text).ToString(Constant.Common.DATE_FORMAT_yyyy_MM_dd));
                    if (txtBuyChargesOptn.Text != string.Empty)
                        ldict.Add(TableEnum.enmSharesTrackerBuy.SHARES_CHARGES_AMT.ToString(), txtBuyChargesOptn.Text);
                    DBFunction.InsertIntoTable(Constant.Common.DATABASE_NAME, TableEnum.enmTableName.SHARES_TRACKER_BUY.ToString(), ldict);
                }
                else
                {
                    errorProvider1.SetError(panelbuyOptn, GlobalFunction.GetMessageById(Constant.Error.ERROR_14));
                }
            }
            LoadForm();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShareSellAdd_Click(object sender, EventArgs e)
        {
            if (DeliveryTab.CanFocus)
            {
                if (lblSellId.Text != string.Empty)
                {
                    Dictionary<string, string> ldict = new Dictionary<string, string>();
                    ldict.Add(TableEnum.enmSharesTrackerSell.SHARES_TRACKER_HEADER_ID.ToString(), lblSellId.Text);
                    ldict.Add(TableEnum.enmSharesTrackerSell.SHARES_PRICE_AMT.ToString(), txtSellPrice.Text);
                    ldict.Add(TableEnum.enmSharesTrackerSell.SHARES_QUANTITY.ToString(), txtSellQty.Text);
                    ldict.Add(TableEnum.enmSharesTrackerSell.SHARES_SELL_DATE.ToString(), Convert.ToDateTime(dateSell.Text).ToString(Constant.Common.DATE_FORMAT_yyyy_MM_dd));
                    if (txtSellCharges.Text != string.Empty)
                        ldict.Add(TableEnum.enmSharesTrackerSell.SHARES_CHARGES_AMT.ToString(), txtSellCharges.Text);
                    DBFunction.InsertIntoTable(Constant.Common.DATABASE_NAME, TableEnum.enmTableName.SHARES_TRACKER_SELL.ToString(), ldict);
                }
                else
                {
                    errorProvider1.SetError(panelSell, GlobalFunction.GetMessageById(Constant.Error.ERROR_14));
                }
            }
            else if (OptionTab.CanFocus)
            {
                if (lblSelloption.Text != string.Empty)
                {
                    Dictionary<string, string> ldict = new Dictionary<string, string>();
                    ldict.Add(TableEnum.enmSharesTrackerSell.SHARES_TRACKER_HEADER_ID.ToString(), lblSelloption.Text);
                    ldict.Add(TableEnum.enmSharesTrackerSell.SHARES_PRICE_AMT.ToString(), txtSellPriceOptn.Text);
                    ldict.Add(TableEnum.enmSharesTrackerSell.SHARES_QUANTITY.ToString(), txtSellQtyOptn.Text);
                    ldict.Add(TableEnum.enmSharesTrackerSell.SHARES_SELL_DATE.ToString(), Convert.ToDateTime(dateSellOptn.Text).ToString(Constant.Common.DATE_FORMAT_yyyy_MM_dd));
                    if (txtSellChargesOptn.Text != string.Empty)
                        ldict.Add(TableEnum.enmSharesTrackerSell.SHARES_CHARGES_AMT.ToString(), txtSellChargesOptn.Text);
                    DBFunction.InsertIntoTable(Constant.Common.DATABASE_NAME, TableEnum.enmTableName.SHARES_TRACKER_SELL.ToString(), ldict);
                }
                else
                {
                    errorProvider1.SetError(panelSellOptn, GlobalFunction.GetMessageById(Constant.Error.ERROR_14));
                }
            }
            LoadForm();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewDelivery_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewDelivery.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();

            if (Convert.ToString(dataGridViewDelivery.Rows[e.RowIndex].Cells[4].Value) == Constant.Shares_Tracker.Profit_Loss.LOSS)
                dataGridViewDelivery.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 128);
            else if (Convert.ToString(dataGridViewDelivery.Rows[e.RowIndex].Cells[4].Value) == Constant.Shares_Tracker.Profit_Loss.PROFIT)
                dataGridViewDelivery.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LimeGreen;

            if (dataGridViewDelivery.Rows.Count == (e.RowIndex + 1) || e.RowIndex == 13)
                Sum();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewDelivery_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDelivery.Rows[e.RowIndex].Cells[7].Selected)
            {
                ShareHeaderId = Convert.ToInt32(dataGridViewDelivery.Rows[e.RowIndex].Cells[5].Value);
                ShareDetail shareDetail = new ShareDetail();
                shareDetail.Show();
            }
            iintUpdateId = Convert.ToInt32(dataGridViewDelivery.Rows[e.RowIndex].Cells[5].Value);
            txtShareNameDelivery.Text = Convert.ToString(dataGridViewDelivery.Rows[e.RowIndex].Cells[1].Value);
            //cmbSeviceDelivery.SelectedItem = 
            lblBuyId.Text = iintUpdateId.ToString();
            lblSellId.Text = iintUpdateId.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewOption_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewOption.Rows[e.RowIndex].Cells[5].Selected)
            {
                ShareHeaderId = Convert.ToInt32(dataGridViewOption.Rows[e.RowIndex].Cells[4].Value);
                ShareDetail shareDetail = new ShareDetail();
                shareDetail.Show();
            }
            iintUpdateId = Convert.ToInt32(dataGridViewOption.Rows[e.RowIndex].Cells[4].Value);
            txtShareNameOption.Text = Convert.ToString(dataGridViewOption.Rows[e.RowIndex].Cells[1].Value);
            lblBuyOption.Text = iintUpdateId.ToString();
            lblSelloption.Text = iintUpdateId.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewOption_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewOption.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            if (Convert.ToString(dataGridViewOption.Rows[e.RowIndex].Cells[3].Value) == Constant.Shares_Tracker.Profit_Loss.LOSS)
                dataGridViewOption.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 128);
            else if (Convert.ToString(dataGridViewOption.Rows[e.RowIndex].Cells[3].Value) == Constant.Shares_Tracker.Profit_Loss.PROFIT)
                dataGridViewOption.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LimeGreen;

            if (dataGridViewOption.Rows.Count == (e.RowIndex + 1) || e.RowIndex == 13)
                Sum();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            LoadForm();

            LoadDematAccount();

            //comboBoxDematAccount.SelectedIndex = 0;

            if (OptionTab.CanFocus)
            {
                tabControl1.SelectedIndex = 1;
            }
            else
            {
                LoadForm();
            }
            lblBuyId.Text = string.Empty;
            lblSellId.Text = string.Empty;
            lblBuyOption.Text = string.Empty;
            lblSelloption.Text = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
            string str = GlobalFunction.GetQueryById(Constant.Query.LOG_OFF_QUERY);
            DBFunction.UpdateTable(Constant.Common.DATABASE_NAME, str);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Share.DematAccount = string.Empty;
            this.Hide();
            ExpensesMain expenses = new ExpensesMain();
            expenses.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewMaintainence_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtExtraChargeAmt.Text = Convert.ToString(dataGridViewMaintainence.Rows[e.RowIndex].Cells[2].Value);
            txtExtraChargeName.Text = Convert.ToString(dataGridViewMaintainence.Rows[e.RowIndex].Cells[1].Value);
            dateExtraCharge.Text = Convert.ToString(dataGridViewMaintainence.Rows[e.RowIndex].Cells[3].Value);
            lblShareHeaderIdValue.Text = Convert.ToString(dataGridViewMaintainence.Rows[e.RowIndex].Cells[5].Value);
            iintUpdateId = Convert.ToInt32(dataGridViewMaintainence.Rows[e.RowIndex].Cells[7].Value);
            lblExtraChargeIdValue.Text = Convert.ToString(iintUpdateId);
            if (Convert.ToByte(dataGridViewMaintainence.Rows[e.RowIndex].Cells[6].Value) == 1)
                CheckIsConsider.Checked = true;
            else
                CheckIsConsider.Checked = false;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddMaint_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> ldict = new Dictionary<string, string>();
            ldict.Add(TableEnum.enmSharesTrackerExtraCharges.SHARES_EXTRA_CHARGES_AMT.ToString(), txtExtraChargeAmt.Text);
            ldict.Add(TableEnum.enmSharesTrackerExtraCharges.SHARES_EXTRA_CHARGES_DESCRIPTION.ToString(), txtExtraChargeName.Text);
            ldict.Add(TableEnum.enmSharesTrackerExtraCharges.DEMAT_ACCOUNT_ID.ToString(), Constant.Common.CodeId.CODE_ID_8);
            ldict.Add(TableEnum.enmSharesTrackerExtraCharges.DEMAT_ACCOUNT_VALUE.ToString(), DematAccount);
            ldict.Add(TableEnum.enmSharesTrackerExtraCharges.SHARES_CHARGES_DATE.ToString(), Convert.ToDateTime(dateExtraCharge.Text).ToString(Constant.Common.DATE_FORMAT_yyyy_MM_dd));
            if (CheckIsConsider.Checked)
                ldict.Add(TableEnum.enmSharesTrackerExtraCharges.IS_CONSIDER.ToString(), Constant.Common.Bit_Value.BIT_1);
            else
                ldict.Add(TableEnum.enmSharesTrackerExtraCharges.IS_CONSIDER.ToString(), Constant.Common.Bit_Value.BIT_0);
            ldict.Add(TableEnum.enmSharesTrackerExtraCharges.USER_ID.ToString(), Login.UserId.ToString());
            string strdate = dateExtraCharge.Value.ToString(Constant.Common.DATE_FORMAT) + Constant.Common.SPACE + dateExtraCharge.Value.ToLongTimeString();
            DBFunction.InsertIntoTable(Constant.Common.DATABASE_NAME, TableEnum.enmTableName.SHARES_TRACKER_EXTRA_CHARGES.ToString(), ldict);
            LoadForm();
            Sum();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateMaint_Click(object sender, EventArgs e)
        {
            string strdate = dateExtraCharge.Value.ToString(Constant.Common.DATE_FORMAT) + Constant.Common.SPACE + dateExtraCharge.Value.ToLongTimeString();
            string bit = CheckIsConsider.Checked ? Constant.Common.Bit_Value.BIT_1 : Constant.Common.Bit_Value.BIT_0;
            string str = "Update [SHARES_TRACKER_EXTRA_CHARGES] SET SHARES_EXTRA_CHARGES_AMT = " + Convert.ToDecimal(txtExtraChargeAmt.Text) + ", SHARES_EXTRA_CHARGES_DESCRIPTION = '" + txtExtraChargeName.Text + "', SHARES_CHARGES_DATE = '" + strdate + "', Is_Consider = " + bit + " where SHARES_TRACKER_EXTRA_CHARGES_ID = " + iintUpdateId;
            DBFunction.UpdateTable(Constant.Common.DATABASE_NAME, str);
            LoadForm();
            Sum();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewMaintainence_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewMaintainence.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            if (Convert.ToByte(dataGridViewMaintainence.Rows[e.RowIndex].Cells[6].Value) == 1)
            {
                dataGridViewMaintainence.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LimeGreen;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewPayInPayOut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtShareAmount.Text = Convert.ToString(dataGridViewPayInPayOut.Rows[e.RowIndex].Cells[2].Value);
            cmbTransaction.Text = Convert.ToString(dataGridViewPayInPayOut.Rows[e.RowIndex].Cells[1].Value);
            if (cmbTransaction.Text == Constant.Shares_Tracker.Code_Value_PayIn_PayOut.PAYIN)
                cmbTransaction.SelectedItem = Constant.Shares_Tracker.PayIn_PayOut.PAYIN;
            else if (cmbTransaction.Text == Constant.Shares_Tracker.Code_Value_PayIn_PayOut.PAYOUT)
                cmbTransaction.SelectedItem = Constant.Shares_Tracker.PayIn_PayOut.PAYOUT;
            dateTransactiondate.Text = Convert.ToString(dataGridViewPayInPayOut.Rows[e.RowIndex].Cells[3].Value);
            lblPayInPayOutValue.Text = Convert.ToString(dataGridViewPayInPayOut.Rows[e.RowIndex].Cells[4].Value);
            iintUpdateId = Convert.ToInt32(dataGridViewPayInPayOut.Rows[e.RowIndex].Cells[4].Value);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewPayInPayOut_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewPayInPayOut.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
            if (Convert.ToString(dataGridViewPayInPayOut.Rows[e.RowIndex].Cells[1].Value) == Constant.Shares_Tracker.Code_Value_PayIn_PayOut.PAYIN)
                dataGridViewPayInPayOut.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 128);
            else if (Convert.ToString(dataGridViewPayInPayOut.Rows[e.RowIndex].Cells[1].Value) == Constant.Shares_Tracker.Code_Value_PayIn_PayOut.PAYOUT)
                dataGridViewPayInPayOut.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LimeGreen;

            if (dataGridViewPayInPayOut.Rows.Count == (e.RowIndex + 1) || e.RowIndex == 13)
                Sum();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPay_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> ldict = new Dictionary<string, string>();
            ldict.Add(TableEnum.enmSharesPayInPayOut.SHARES_TRANSACTION_CODE_ID.ToString(), Constant.Common.CodeId.CODE_ID_5);
            ldict.Add(TableEnum.enmSharesPayInPayOut.DEMAT_ACCOUNT_ID.ToString(), Constant.Common.CodeId.CODE_ID_8);
            ldict.Add(TableEnum.enmSharesPayInPayOut.DEMAT_ACCOUNT_VALUE.ToString(), DematAccount);
            if (Convert.ToString(cmbTransaction.SelectedItem) == Constant.Shares_Tracker.PayIn_PayOut.PAYIN)
                ldict.Add(TableEnum.enmSharesPayInPayOut.SHARES_TRANSACTION_CODE_VALUE.ToString(), Constant.Shares_Tracker.Code_Value_PayIn_PayOut.PAYIN);
            else if (Convert.ToString(cmbTransaction.SelectedItem) == Constant.Shares_Tracker.PayIn_PayOut.PAYOUT)
                ldict.Add(TableEnum.enmSharesPayInPayOut.SHARES_TRANSACTION_CODE_VALUE.ToString(), Constant.Shares_Tracker.Code_Value_PayIn_PayOut.PAYOUT);
            ldict.Add(TableEnum.enmSharesPayInPayOut.SHARES_TRANSACTION_AMT.ToString(), txtShareAmount.Text);
            string str = dateTransactiondate.Value.ToString(Constant.Common.DATE_FORMAT) + Constant.Common.SPACE + dateTransactiondate.Value.ToLongTimeString();
            ldict.Add(TableEnum.enmSharesPayInPayOut.SHARES_TRANSACTION_DATE.ToString(), str);
            ldict.Add(TableEnum.enmSharesPayInPayOut.USER_ID.ToString(), Login.UserId.ToString());
            DBFunction.InsertIntoTable(Constant.Common.DATABASE_NAME, TableEnum.enmTableName.SHARES_PAYIN_PAYOUT.ToString(), ldict);
            LoadForm();
            Sum();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdatePay_Click(object sender, EventArgs e)
        {
            string lstrPayInOut = string.Empty;
            if (Convert.ToString(cmbTransaction.SelectedItem) == Constant.Shares_Tracker.PayIn_PayOut.PAYIN)
                lstrPayInOut = Constant.Shares_Tracker.Code_Value_PayIn_PayOut.PAYIN;
            else if (Convert.ToString(cmbTransaction.SelectedItem) == Constant.Shares_Tracker.PayIn_PayOut.PAYOUT)
                lstrPayInOut = Constant.Shares_Tracker.Code_Value_PayIn_PayOut.PAYOUT;
            string strdate = dateTransactiondate.Value.ToString(Constant.Common.DATE_FORMAT) + Constant.Common.SPACE + dateTransactiondate.Value.ToLongTimeString();
            string str = "Update SHARES_PAYIN_PAYOUT SET SHARES_TRANSACTION_AMT = " + Convert.ToDecimal(txtShareAmount.Text) + ", SHARES_TRANSACTION_DATE = '" + strdate + "', SHARES_TRANSACTION_CODE_VALUE = '" + lstrPayInOut + "' Where SHARES_TRANSACTION_ID = " + iintUpdateId;
            DBFunction.UpdateTable(Constant.Common.DATABASE_NAME, str);
            LoadForm();
            Sum();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddDividend_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> ldict = new Dictionary<string, string>();
            if (txtHeaderIdDividend.Text != string.Empty)
                ldict.Add(TableEnum.enmShareDividend.SHARES_TRACKER_HEADER_ID.ToString(), txtHeaderIdDividend.Text);
            if (txtShareDividendDesc.Text != string.Empty)
                ldict.Add(TableEnum.enmShareDividend.SHARE_DESCRIPTION.ToString(), txtShareDividendDesc.Text);
            ldict.Add(TableEnum.enmShareDividend.USER_ID.ToString(), Login.UserId.ToString());
            ldict.Add(TableEnum.enmShareDividend.SHARES_PRICE_AMT.ToString(), txtShareAmountDividend.Text);
            ldict.Add(TableEnum.enmShareDividend.DEMAT_ACCOUNT_ID.ToString(), Constant.Common.CodeId.CODE_ID_8);
            ldict.Add(TableEnum.enmShareDividend.DEMAT_ACCOUNT_VALUE.ToString(), DematAccount);
            if (chkIsBankAccount.Checked)
                ldict.Add(TableEnum.enmShareDividend.IS_BANK_ACCOUNT.ToString(), Constant.Common.Bit_Value.BIT_1);
            else
                ldict.Add(TableEnum.enmShareDividend.IS_BANK_ACCOUNT.ToString(), Constant.Common.Bit_Value.BIT_0);
            string str = dateTimePickerDividend.Value.ToString(Constant.Common.DATE_FORMAT) + Constant.Common.SPACE + dateTimePickerDividend.Value.ToLongTimeString();
            ldict.Add(TableEnum.enmShareDividend.DIVIDEND_DATE.ToString(), str);
            DBFunction.InsertIntoTable(Constant.Common.DATABASE_NAME, TableEnum.enmTableName.SHARE_DIVIDEND.ToString(), ldict);
            LoadForm();
            Sum();
        }

        /// <summary>
        /// Tracker - Button Trigger of Extra Incoming and Outgoing of Demat Acccount
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExtraOutgIncmAdd_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> ldict = new Dictionary<string, string>();
            ldict.Add(TableEnum.enmExtraIncomingOutgoing.AMOUNT.ToString(), txtExtraOutgIncmAmt.Text);
            ldict.Add(TableEnum.enmExtraIncomingOutgoing.INCOMING_OUTGOING_CODE_ID.ToString(), Constant.Common.CodeId.CODE_ID_3);
            ldict.Add(TableEnum.enmExtraIncomingOutgoing.DEMAT_ACCOUNT_ID.ToString(), Constant.Common.CodeId.CODE_ID_8);
            ldict.Add(TableEnum.enmExtraIncomingOutgoing.DEMAT_ACCOUNT_VALUE.ToString(), DematAccount);
            if (rdoIncoming.Checked)
                ldict.Add(TableEnum.enmExtraIncomingOutgoing.INCOMING_OUTGOING_CODE_VALUE.ToString(), Constant.Shares_Tracker.Incoming_Outgoing.INCOMING);
            else if (rdoOutgoing.Checked)
                ldict.Add(TableEnum.enmExtraIncomingOutgoing.INCOMING_OUTGOING_CODE_VALUE.ToString(), Constant.Shares_Tracker.Incoming_Outgoing.OUTGOING);
            ldict.Add(TableEnum.enmExtraIncomingOutgoing.USER_ID.ToString(), Login.UserId.ToString());
            ldict.Add(TableEnum.enmExtraIncomingOutgoing.INCOMING_OUTGOING_DESCRIPTION.ToString(), txtExtraOutgIncmDesc.Text);
            string str = dateExtraOutgIncmDate.Value.ToString(Constant.Common.DATE_FORMAT) + Constant.Common.SPACE + dateExtraOutgIncmDate.Value.ToLongTimeString();
            ldict.Add(TableEnum.enmExtraIncomingOutgoing.INCOMING_OUTGOING_DATE.ToString(), str);
            DBFunction.InsertIntoTable(Constant.Common.DATABASE_NAME, TableEnum.enmTableName.EXTRA_INCOMING_OUTGOING.ToString(), ldict);
            LoadForm();
            Sum();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMonthEarningAnalysis_Click(object sender, EventArgs e)
        {
            if (Share.DematAccount != string.Empty)
            {
                ShareMonthlyAnalysis shareMonthlyAnalysis = new ShareMonthlyAnalysis(Share.DematAccount);
                shareMonthlyAnalysis.Show();
            }
            else
            {
                errorProvider1.SetError(btnMonthEarningAnalysis, GlobalFunction.GetMessageById(Constant.Error.ERROR_17));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnServiceAnalysis_Click(object sender, EventArgs e)
        {
            ShareServiceAnalysis shareServiceAnalysis = new ShareServiceAnalysis();
            shareServiceAnalysis.Show();
        }

        #endregion

        #region Private Method

        /// <summary>
        /// 
        /// </summary>
        private void LoadForm()
        {
            lblUserName.Text = GlobalFunction.GetFullNameById(Login.UserId);
            this.sHARE_TRACKER_PROCEDURE_DELIVERYTableAdapter.Fill(this.shares_TrackerDataset.SHARE_TRACKER_PROCEDURE_DELIVERY, Login.UserId, Share.DematAccount);
            this.sHARE_TRACKER_PROCEDURE_OPTIONTableAdapter.Fill(this.shares_TrackerDataset.SHARE_TRACKER_PROCEDURE_OPTION, Login.UserId, Share.DematAccount);
            this.sHARE_TRACKER_PROCEDURE_EXTRA_CHARGESTableAdapter.Fill(this.shares_TrackerDataset.SHARE_TRACKER_PROCEDURE_EXTRA_CHARGES, Login.UserId, Share.DematAccount);
            this.sHARE_TRACKER_PROCEDURE_PAYIN_PAYOUTTableAdapter.Fill(this.shares_TrackerDataset.SHARE_TRACKER_PROCEDURE_PAYIN_PAYOUT, Login.UserId, Share.DematAccount);
            this.sHARE_TRACKER_PROCEDURE_DIVIDENDTableAdapter.Fill(this.shares_TrackerDataset.SHARE_TRACKER_PROCEDURE_DIVIDEND, Login.UserId, Share.DematAccount);
            this.sHARE_TRACKER_PROCEDURE_EXTRA_INCOMING_OUTGOINGTableAdapter.Fill(this.shares_TrackerDataset.SHARE_TRACKER_PROCEDURE_EXTRA_INCOMING_OUTGOING, Login.UserId, Share.DematAccount);
            this.cURRENT_SHARE_PROCEDURETableAdapter.Fill(this.shares_TrackerDataset.CURRENT_SHARE_PROCEDURE, Login.UserId, Share.DematAccount);
            string lstrQuery = GlobalFunction.GetQueryById(Constant.Query.GET_LAST_DATE);
            lstrQuery = string.Format(lstrQuery, Login.UserId, Share.DematAccount);
            string Tilldate = DBFunction.FetchScalarFromDatabase(Constant.Common.DATABASE_NAME, lstrQuery);

            Dictionary<string, string> servicesCombo = new Dictionary<string, string>();
            lstrQuery = GlobalFunction.GetQueryById(Constant.Query.GET_SERVICE_NAMES);
            DataTable ldtbService = DBFunction.FetchDataFromDatabase(Constant.Common.DATABASE_NAME, lstrQuery);
            foreach (DataRow dr in ldtbService.Rows)
                servicesCombo.Add(dr[TableEnum.enmCode_Value.CODE_VALUE.ToString()].ToString(), dr[TableEnum.enmCode_Value.CODE_VALUE_DESCRIPTION.ToString()].ToString());

            cmbSeviceDelivery.DataSource = new BindingSource(servicesCombo, null);
            cmbSeviceDelivery.DisplayMember = "Value";
            cmbSeviceDelivery.ValueMember = "Key";

            DateTime dateTime;
            if (comboBoxDematAccount.Text != "Select Item" && DateTime.TryParse(Tilldate, out dateTime))
            {
                lblTillDate.Text = "Your profile is updated till " + dateTime.ToShortDateString() + " date";
                lblTillDate.Visible = true;
            }
            else
            {
                lblTillDate.Visible = false;
            }
        }

        /// <summary>
        /// This Method calculates the sum of all the transaction values
        /// </summary>
        private void Sum()
        {
            lblTotalValueDelivery.Text = Convert.ToString(dataGridViewDelivery.Rows.Cast<DataGridViewRow>().Sum(x => x.Cells[2].Value is DBNull ? 0 : Convert.ToDecimal(x.Cells[2].Value)));
            lblResultOption.Text = Convert.ToString(dataGridViewOption.Rows.Cast<DataGridViewRow>().Sum(x => x.Cells[2].Value is DBNull ? 0 : Convert.ToDecimal(x.Cells[2].Value)));
            lblResultValueMaint.Text = Convert.ToString(dataGridViewMaintainence.Rows.Cast<DataGridViewRow>().Where(x => Convert.ToByte(x.Cells[6].Value) == 1).Sum(x => x.Cells[2].Value is DBNull ? 0 : Convert.ToDecimal(x.Cells[2].Value)));
            lblTotalDividendValue.Text = Convert.ToString(dataGridViewDividend.Rows.Cast<DataGridViewRow>().Sum(x => x.Cells[2].Value is DBNull ? 0 : Convert.ToDecimal(x.Cells[2].Value)));
            string lstrTotalDividendValueInsideThePlatform = Convert.ToString(dataGridViewDividend.Rows.Cast<DataGridViewRow>().Where(x => Convert.ToBoolean(x.Cells[4].Value) == false).Sum(x => x.Cells[2].Value is DBNull ? 0 : Convert.ToDecimal(x.Cells[2].Value)));
            string lstrTotalDividendValueOutsideThePlatform = Convert.ToString(dataGridViewDividend.Rows.Cast<DataGridViewRow>().Where(x => Convert.ToBoolean(x.Cells[4].Value) == true).Sum(x => x.Cells[2].Value is DBNull ? 0 : Convert.ToDecimal(x.Cells[2].Value)));
            lblResultPayValue.Text = Convert.ToString(dataGridViewPayInPayOut.Rows.Cast<DataGridViewRow>().Where(x => Convert.ToString(x.Cells[1].Value) == Constant.Shares_Tracker.Code_Value_PayIn_PayOut.PAYOUT).Sum(x => x.Cells[2].Value is DBNull ? 0 : Convert.ToDecimal(x.Cells[2].Value))
                - dataGridViewPayInPayOut.Rows.Cast<DataGridViewRow>().Where(x => Convert.ToString(x.Cells[1].Value) == Constant.Shares_Tracker.Code_Value_PayIn_PayOut.PAYIN).Sum(x => x.Cells[2].Value is DBNull ? 0 : Convert.ToDecimal(x.Cells[2].Value))
                );
            lblTotalValueExtraIncmValue.Text = Convert.ToString(dataGridViewIncmOutg.Rows.Cast<DataGridViewRow>().Where(x => Convert.ToString(x.Cells[4].Value) == Constant.Expenses_Tracker.Transaaction_Type.INCOMING).Sum(x => x.Cells[2].Value is DBNull ? 0 : Convert.ToDecimal(x.Cells[2].Value))
                - dataGridViewIncmOutg.Rows.Cast<DataGridViewRow>().Where(x => Convert.ToString(x.Cells[4].Value) == Constant.Expenses_Tracker.Transaaction_Type.OUTGOING).Sum(x => x.Cells[2].Value is DBNull ? 0 : Convert.ToDecimal(x.Cells[2].Value))
                );
            lblTotalIncomingSummaryValue.Text = Convert.ToString(Convert.ToDecimal(lblTotalValueExtraIncmValue.Text) + Convert.ToDecimal(lstrTotalDividendValueOutsideThePlatform));
            decimal ldecTotalCurrentShare = dataGridViewCurrent.Rows.Cast<DataGridViewRow>().Sum(x => x.Cells[1].Value is DBNull ? 0 : Convert.ToDecimal(x.Cells[1].Value));
            lblTotalCurrentShare.Text = Convert.ToString(ldecTotalCurrentShare);
            lblSummary1Value.Text = Convert.ToString(Math.Abs(Convert.ToDecimal(lblResultPayValue.Text)));
            lblSummary2Result.Text = Convert.ToString(Convert.ToDecimal(lblTotalValueDelivery.Text) + Convert.ToDecimal(lblResultOption.Text) + Convert.ToDecimal(lstrTotalDividendValueInsideThePlatform) - Convert.ToDecimal(lblResultValueMaint.Text));
            lblFinalResultValue.Text = Convert.ToString(Convert.ToDecimal(lblSummary2Result.Text) + Convert.ToDecimal(lblTotalIncomingSummaryValue.Text));
            if (Convert.ToDecimal(lblResultPayValue.Text) < 0)
            {
                decimal Rst = Convert.ToDecimal(lblSummary1Value.Text) + Convert.ToDecimal(lblSummary2Result.Text) - ldecTotalCurrentShare;
                lblSummary4Value.Text = "You should have " + Rst + " in your Demat Account";
            }
            else
            {
                decimal Rst =  Convert.ToDecimal(lblSummary2Result.Text) - Convert.ToDecimal(lblSummary1Value.Text) - ldecTotalCurrentShare;
                lblSummary4Value.Text = "You should have " + Rst + " in your Demat Account";
            }
            decimal temp;
            if (dataGridViewDelivery.Rows.Count > 0)
            {
                string lstrHighestProfit = Convert.ToString(dataGridViewDelivery.Rows.Cast<DataGridViewRow>().Max(x => decimal.TryParse(x.Cells[2].Value.ToString(), out temp) ? temp : 0));
                string lstrHighestShareName = Convert.ToString(dataGridViewDelivery.Rows.Cast<DataGridViewRow>().Max(x => decimal.TryParse(x.Cells[2].Value.ToString(), out temp) ? temp : 0));
                lblHighestProfitTransaction.Text = "You have highest profit transaction Amount is " + lstrHighestProfit + " Rs";
            }
            SetContractNotePassword();
        }

        #endregion

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage page = tabControl1.TabPages[e.Index];
            Color col = e.Index == 0 ? Color.Aqua : Color.Yellow;
            e.Graphics.FillRectangle(new SolidBrush(col), e.Bounds);

            Rectangle paddedBounds = e.Bounds;
            int yOffset = (e.State == DrawItemState.Selected) ? -2 : 1;
            paddedBounds.Offset(1, yOffset);
            TextRenderer.DrawText(e.Graphics, page.Text, Font, paddedBounds, page.ForeColor);
        }

        private void LoadDematAccount()
        {
            string lstrQuery = GlobalFunction.GetQueryById(Constant.Query.GET_DEMAT_ACCOUNT_NAME);
            DataTable dataTable = DBFunction.FetchDataFromDatabase(Constant.Common.DATABASE_NAME, lstrQuery);
            MyComboBox myComboBoxMain = new MyComboBox();
            myComboBoxMain.Text = "Select Item";
            myComboBoxMain.Value = "";
            comboBoxDematAccount.Items.Add(myComboBoxMain);
            foreach (DataRow dr in dataTable.Rows)
            {
                MyComboBox myComboBox = new MyComboBox();
                myComboBox.Text = GeneralFunction.GetStringValueFromDataRow(dr, TableEnum.enmCode_Value.CODE_VALUE_DESCRIPTION.ToString());
                myComboBox.Value = GeneralFunction.GetStringValueFromDataRow(dr, TableEnum.enmCode_Value.CODE_VALUE.ToString());
                comboBoxDematAccount.Items.Add(myComboBox);
            }

            for (int i = 0; i < comboBoxDematAccount.Items.Count; i++)
            {
                if (Convert.ToString(((MyComboBox)comboBoxDematAccount.Items[i]).Value) == DematAccount)
                {
                    comboBoxDematAccount.SelectedIndex = i;
                    break;
                }
            }
        }

        private void comboBoxDematAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lstrDematAccount = Convert.ToString(((MyComboBox)comboBoxDematAccount.SelectedItem).Value);
            if (lstrDematAccount.IsNotNullOrEmpty())
                DematAccount = lstrDematAccount;
            else
            {
                DematAccount = string.Empty;
            }
            LoadForm();
            Sum();
        }

        private void dataGridViewDividend_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtShareAmountDividend.Text = Convert.ToString(dataGridViewDividend.Rows[e.RowIndex].Cells[2].Value);
            txtShareDividendDesc.Text = Convert.ToString(dataGridViewDividend.Rows[e.RowIndex].Cells[1].Value);
            dateTimePickerDividend.Value = Convert.ToDateTime(dataGridViewDividend.Rows[e.RowIndex].Cells[3].Value);
            if (Convert.ToBoolean(dataGridViewDividend.Rows[e.RowIndex].Cells[4].Value) == true)
                chkIsBankAccount.Checked = true;
            else
                chkIsBankAccount.Checked = false;
            iintUpdateId = Convert.ToInt32(dataGridViewDividend.Rows[e.RowIndex].Cells[0].Value);
        }

        private void btnDividendUpdate_Click(object sender, EventArgs e)
        {
            string lstrbool = chkIsBankAccount.Checked == true ? "1" : "0";
            string strdate = dateTimePickerDividend.Value.ToString(Constant.Common.DATE_FORMAT) + Constant.Common.SPACE + dateTransactiondate.Value.ToLongTimeString();
            string str = "UPDATE SHARE_DIVIDEND SET SHARES_PRICE_AMT = " + txtShareAmountDividend.Text + ", SHARE_DESCRIPTION = '" + txtShareDividendDesc.Text + "', DIVIDEND_DATE = '" + strdate + "', IS_BANK_ACCOUNT = " + lstrbool + " where SHARE_DIVIDEND_ID = " + iintUpdateId;
            DBFunction.UpdateTable(Constant.Common.DATABASE_NAME, str);
            LoadForm();
            Sum();
        }

        private void btnFamilyTotalShare_Click(object sender, EventArgs e)
        {
            TotalFamilyShare totalFamilyShare = new TotalFamilyShare();
            totalFamilyShare.Show();
        }

        private void SetContractNotePassword()
        {
            string lstrDematAccount = Convert.ToString(((ExpensesTracker.BusinessObject.MyComboBox)comboBoxDematAccount.SelectedItem).Value);
            if (comboBoxDematAccount.Text != "Select Item")
            {
                if (Login.UserId == 1 && lstrDematAccount == "PAIS")
                    lblContractNotePassValue.Text = "ANSPT8584D";
                if (Login.UserId == 1 && lstrDematAccount == "GROW")
                    lblContractNotePassValue.Text = "ANSPT8584D";
                if (Login.UserId == 1 && lstrDematAccount == "MOTI")
                    lblContractNotePassValue.Text = "ANSPT8584D";

                if (Login.UserId == 2 && lstrDematAccount == "PAIS")
                    lblContractNotePassValue.Text = "BCOPC166F";
                if (Login.UserId == 2 && lstrDematAccount == "GROW")
                    lblContractNotePassValue.Text = "ANSPT8584D";
                if (Login.UserId == 2 && lstrDematAccount == "IIFL")
                    lblContractNotePassValue.Text = "83587384";
            }
        }

        private void btnShareWiseAnalysis_Click(object sender, EventArgs e)
        {
            ShareStockNameWiseAnalysis shareStockNameWiseAnalysis = new ShareStockNameWiseAnalysis();
            shareStockNameWiseAnalysis.Show();
        }
    }
}
