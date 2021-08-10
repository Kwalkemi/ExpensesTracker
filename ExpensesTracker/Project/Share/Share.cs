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

        #endregion

        #region Events Method

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Share_Load(object sender, EventArgs e)
        {
            LoadForm();
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
                    ldict.Add(TableEnum.enmSharesTrackerBuy.SHARES_BUY_DATE.ToString(), Convert.ToDateTime(dateBuy.Text).ToString("yyyy-MM-dd"));
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
                    ldict.Add(TableEnum.enmSharesTrackerBuy.SHARES_BUY_DATE.ToString(), Convert.ToDateTime(dateBuyOptn.Text).ToString("yyyy-MM-dd"));
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
                    ldict.Add(TableEnum.enmSharesTrackerSell.SHARES_SELL_DATE.ToString(), Convert.ToDateTime(dateSell.Text).ToString("yyyy-MM-dd"));
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
                    ldict.Add(TableEnum.enmSharesTrackerSell.SHARES_SELL_DATE.ToString(), Convert.ToDateTime(dateSellOptn.Text).ToString("yyyy-MM-dd"));
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
            if (dataGridViewDelivery.Rows[e.RowIndex].Cells[6].Selected)
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
            if (OptionTab.CanFocus)
            {
                this.Controls.Clear();
                this.InitializeComponent();
                LoadForm();
                tabControl1.SelectedIndex = 1;
            }
            else
            {
                this.Controls.Clear();
                this.InitializeComponent();
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
            ldict.Add(TableEnum.enmSharesTrackerExtraCharges.SHARES_CHARGES_DATE.ToString(), Convert.ToDateTime(dateExtraCharge.Text).ToString("yyyy-MM-dd"));
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
            dateTransactiondate.Text = Convert.ToString(dataGridViewPayInPayOut.Rows[e.RowIndex].Cells[3].Value);
            lblPayInPayOutValue.Text = Convert.ToString(dataGridViewPayInPayOut.Rows[e.RowIndex].Cells[4].Value);
            iintUpdateId = Convert.ToInt32(dataGridViewMaintainence.Rows[e.RowIndex].Cells[4].Value);
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
            ldict.Add(TableEnum.enmSharesPayInPayOut.SHARES_TRANSACTION_CODE_ID.ToString(), "5");
            if (Convert.ToString(cmbTransaction.SelectedItem) == Constant.Shares_Tracker.PayIn_PayOut.PAYIN)
                ldict.Add(TableEnum.enmSharesPayInPayOut.SHARES_TRANSACTION_CODE_VALUE.ToString(), Constant.Shares_Tracker.Code_Value_PayIn_PayOut.PAYIN);
            else if (Convert.ToString(cmbTransaction.SelectedItem) == Constant.Shares_Tracker.PayIn_PayOut.PAYOUT)
                ldict.Add(TableEnum.enmSharesPayInPayOut.SHARES_TRANSACTION_CODE_VALUE.ToString(), Constant.Shares_Tracker.Code_Value_PayIn_PayOut.PAYOUT);
            ldict.Add(TableEnum.enmSharesPayInPayOut.SHARES_TRANSACTION_AMT.ToString(), txtShareAmount.Text);
            string str = dateTransactiondate.Value.ToString(Constant.Common.DATE_FORMAT) + Constant.Common.SPACE + dateTransactiondate.Value.ToLongTimeString();
            ldict.Add(TableEnum.enmSharesPayInPayOut.SHARES_TRANSACTION_DATE.ToString(), str);
            ldict.Add("USER_ID", Login.UserId.ToString());
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
            string strdate = dateTransactiondate.Value.ToString(Constant.Common.DATE_FORMAT) + Constant.Common.SPACE + dateTransactiondate.Value.ToLongTimeString();
            string str = "Update SHARES_PAYIN_PAYOUT SET SHARES_EXTRA_CHARGES_AMT = " + Convert.ToDecimal(txtExtraChargeAmt.Text) + ", SHARES_EXTRA_CHARGES_DESCRIPTION = '" + txtExtraChargeName.Text + "', SHARES_CHARGES_DATE = '" + strdate + "' Where SHARES_TRANSACTION_ID = " + iintUpdateId;
            DBFunction.UpdateTable(Constant.Common.DATABASE_NAME, str);
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExtraOutgIncmAdd_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> ldict = new Dictionary<string, string>();
            ldict.Add(TableEnum.enmExtraIncomingOutgoing.AMOUNT.ToString(), txtExtraOutgIncmAmt.Text);
            ldict.Add(TableEnum.enmExtraIncomingOutgoing.INCOMING_OUTGOING_CODE_ID.ToString(), "3");
            if (rdoIncoming.Checked)
                ldict.Add(TableEnum.enmExtraIncomingOutgoing.INCOMING_OUTGOING_CODE_VALUE.ToString(), Constant.Shares_Tracker.Incoming_Outgoing.INCOMING);
            else if (rdoOutgoing.Checked)
                ldict.Add(TableEnum.enmExtraIncomingOutgoing.INCOMING_OUTGOING_CODE_VALUE.ToString(), Constant.Shares_Tracker.Incoming_Outgoing.OUTGOING);
            ldict.Add("USER_ID", Login.UserId.ToString());
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
            ShareMonthlyAnalysis shareMonthlyAnalysis = new ShareMonthlyAnalysis();
            shareMonthlyAnalysis.Show();
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
            this.sHARE_TRACKER_PROCEDURE_DELIVERYTableAdapter.Fill(this.shares_TrackerDataset.SHARE_TRACKER_PROCEDURE_DELIVERY, Login.UserId);
            this.sHARE_TRACKER_PROCEDURE_OPTIONTableAdapter.Fill(this.shares_TrackerDataset.SHARE_TRACKER_PROCEDURE_OPTION, Login.UserId);
            this.sHARE_TRACKER_PROCEDURE_EXTRA_CHARGESTableAdapter.Fill(this.shares_TrackerDataset.SHARE_TRACKER_PROCEDURE_EXTRA_CHARGES, Login.UserId);
            this.sHARE_TRACKER_PROCEDURE_PAYIN_PAYOUTTableAdapter.Fill(this.shares_TrackerDataset.SHARE_TRACKER_PROCEDURE_PAYIN_PAYOUT, Login.UserId);
            this.sHARE_TRACKER_PROCEDURE_DIVIDENDTableAdapter.Fill(this.shares_TrackerDataset.SHARE_TRACKER_PROCEDURE_DIVIDEND, Login.UserId);
            this.sHARE_TRACKER_PROCEDURE_EXTRA_INCOMING_OUTGOINGTableAdapter.Fill(this.shares_TrackerDataset.SHARE_TRACKER_PROCEDURE_EXTRA_INCOMING_OUTGOING, Login.UserId);
            this.cURRENT_SHARE_PROCEDURETableAdapter.Fill(this.shares_TrackerDataset.CURRENT_SHARE_PROCEDURE, Login.UserId);
            string lstrQuery = GlobalFunction.GetQueryById(Constant.Query.GET_LAST_DATE);
            lstrQuery = string.Format(lstrQuery, Login.UserId);
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
            if (DateTime.TryParse(Tilldate, out dateTime))
                lblTillDate.Text = "Your profile is updated till " + dateTime.ToShortDateString() + " date";
        }

        /// <summary>
        /// 
        /// </summary>
        private void Sum()
        {
            lblTotalValueDelivery.Text = Convert.ToString(dataGridViewDelivery.Rows.Cast<DataGridViewRow>().Sum(x => x.Cells[2].Value is DBNull ? 0 : Convert.ToDecimal(x.Cells[2].Value)));
            lblResultOption.Text = Convert.ToString(dataGridViewOption.Rows.Cast<DataGridViewRow>().Sum(x => x.Cells[2].Value is DBNull ? 0 : Convert.ToDecimal(x.Cells[2].Value)));
            lblResultValueMaint.Text = Convert.ToString(dataGridViewMaintainence.Rows.Cast<DataGridViewRow>().Where(x => Convert.ToByte(x.Cells[6].Value) == 1).Sum(x => x.Cells[2].Value is DBNull ? 0 : Convert.ToDecimal(x.Cells[2].Value)));
            lblTotalDividendValue.Text = Convert.ToString(dataGridViewDividend.Rows.Cast<DataGridViewRow>().Sum(x => x.Cells[2].Value is DBNull ? 0 : Convert.ToDecimal(x.Cells[2].Value)));
            lblResultPayValue.Text = Convert.ToString(dataGridViewPayInPayOut.Rows.Cast<DataGridViewRow>().Where(x => Convert.ToString(x.Cells[1].Value) == "PAYO").Sum(x => x.Cells[2].Value is DBNull ? 0 : Convert.ToDecimal(x.Cells[2].Value))
                - dataGridViewPayInPayOut.Rows.Cast<DataGridViewRow>().Where(x => Convert.ToString(x.Cells[1].Value) == "PAYI").Sum(x => x.Cells[2].Value is DBNull ? 0 : Convert.ToDecimal(x.Cells[2].Value))
                );
            lblTotalValueExtraIncmValue.Text = Convert.ToString(dataGridViewIncmOutg.Rows.Cast<DataGridViewRow>().Where(x => Convert.ToString(x.Cells[4].Value) == "INCM").Sum(x => x.Cells[2].Value is DBNull ? 0 : Convert.ToDecimal(x.Cells[2].Value))
                - dataGridViewIncmOutg.Rows.Cast<DataGridViewRow>().Where(x => Convert.ToString(x.Cells[4].Value) == "OUTG").Sum(x => x.Cells[2].Value is DBNull ? 0 : Convert.ToDecimal(x.Cells[2].Value))
                );
            lblTotalIncomingSummaryValue.Text = lblTotalValueExtraIncmValue.Text;
            decimal ldecTotalCurrentShare = dataGridViewCurrent.Rows.Cast<DataGridViewRow>().Sum(x => x.Cells[1].Value is DBNull ? 0 : Convert.ToDecimal(x.Cells[1].Value));
            lblTotalCurrentShare.Text = Convert.ToString(ldecTotalCurrentShare);
            lblSummary1Value.Text = Convert.ToString(Math.Abs(Convert.ToDecimal(lblResultPayValue.Text)));
            lblSummary2Result.Text = Convert.ToString(Convert.ToDecimal(lblTotalValueDelivery.Text) + Convert.ToDecimal(lblResultOption.Text) + Convert.ToDecimal(lblTotalDividendValue.Text) - Convert.ToDecimal(lblResultValueMaint.Text));
            lblFinalResultValue.Text = Convert.ToString(Convert.ToDecimal(lblSummary2Result.Text) + Convert.ToDecimal(lblTotalValueExtraIncmValue.Text));
            if (Convert.ToDecimal(lblResultPayValue.Text) < 0)
            {
                decimal Rst = Convert.ToDecimal(lblSummary1Value.Text) + Convert.ToDecimal(lblSummary2Result.Text) - ldecTotalCurrentShare;
                lblSummary4Value.Text = "You should have " + Rst + " in your Demat Account";
            }
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


    }
}
