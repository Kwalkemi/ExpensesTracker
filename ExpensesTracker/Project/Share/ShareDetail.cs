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
using ExpensesTracker.BusinessObject;

namespace ExpensesTracker.Project.Share
{
    public partial class ShareDetail : Form
    {
        #region Constructor
        public ShareDetail()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties
        public int iintUpdateId { get; set; }
        public string istrTransactionType { get; set; }
        #endregion

        #region Event Method
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShareDetail_Load(object sender, EventArgs e)
        {
            this.Size = new Size(754, 470);
            string str = "Select SHARES_NAME from [dbo].[SHARES_TRACKER_HEADER] where SHARES_TRACKER_HEADER_ID = " + Share.ShareHeaderId;
            lblShareName.Text = DBFunction.FetchScalarFromDatabase(Constant.Common.DATABASE_NAME, str);

            txtShareCharges.Visible = false;
            txtShareQty.Visible = false;
            txtShareAmt.Visible = false;
            dateShareDate.Visible = false;
            btnUpdateShareDetail.Visible = false;
            lblUpdate.Visible = false;
            txtHdrId.Visible = false;
            lblHdr.Visible = false;
            checkHeaderUpdate.Visible = false;

            this.sHARE_DETAIL_PROCEDURETableAdapter.Fill(this.shares_TrackerDataset.SHARE_DETAIL_PROCEDURE, Share.ShareHeaderId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (dataGridView1.Rows.Count == (e.RowIndex + 1) || e.RowIndex == 13)
            {
                lblResultValue.Text = Convert.ToString(Convert.ToDecimal(dataGridView1.Rows.Cast<DataGridViewRow>().Where(x => Convert.ToString(x.Cells[0].Value) == Constant.Shares_Tracker.Buy_Sell.SELL).Sum(x => x.Cells[5].Value is DBNull ? 0 : Convert.ToDecimal(x.Cells[5].Value))) -
                    Convert.ToDecimal(dataGridView1.Rows.Cast<DataGridViewRow>().Where(x => Convert.ToString(x.Cells[0].Value) == Constant.Shares_Tracker.Buy_Sell.BUY).Sum(x => x.Cells[5].Value is DBNull ? 0 : Convert.ToDecimal(x.Cells[5].Value))));

                lblAvgBuyValue.Text = Convert.ToString(Math.Round(Convert.ToDecimal(dataGridView1.Rows.Cast<DataGridViewRow>().Where(x => Convert.ToString(x.Cells[0].Value) == Constant.Shares_Tracker.Buy_Sell.BUY).Sum(x => (x.Cells[2].Value is DBNull ? 0 : Convert.ToDecimal(x.Cells[2].Value)) * (x.Cells[3].Value is DBNull ? 0 : Convert.ToDecimal(x.Cells[3].Value))))
                     / Convert.ToDecimal(dataGridView1.Rows.Cast<DataGridViewRow>().Where(x => Convert.ToString(x.Cells[0].Value) == Constant.Shares_Tracker.Buy_Sell.BUY).Sum(x => x.Cells[3].Value is DBNull ? 0 : Convert.ToDecimal(x.Cells[3].Value))),2 ));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Size = new Size(754, 547);
            iintUpdateId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
            istrTransactionType = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            dateShareDate.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            txtShareAmt.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            txtShareQty.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            txtShareCharges.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
            txtHdrId.Text = Share.ShareHeaderId.ToString();
            txtShareCharges.Visible = true;
            txtShareQty.Visible = true;
            txtShareAmt.Visible = true;
            dateShareDate.Visible = true;
            btnUpdateShareDetail.Visible = true;
            checkHeaderUpdate.Visible = true;
            lblHdr.Visible = true;
            lblUpdate.Visible = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateShareDetail_Click_1(object sender, EventArgs e)
        {
            DBFunction dBFunction = new DBFunction();
            string str = string.Empty;

            string strdate = dateShareDate.Value.ToString("MM/dd/yyyy") + " " + dateShareDate.Value.ToLongTimeString();
            if (istrTransactionType == Constant.Shares_Tracker.Buy_Sell.BUY)
            {
                if (txtShareCharges.Text == string.Empty)
                    str = "Update SHARES_TRACKER_BUY Set SHARES_PRICE_AMT = " + txtShareAmt.Text + ", SHARES_QUANTITY = " + txtShareQty.Text + ", SHARES_BUY_DATE = '" + strdate + "' , SHARES_TRACKER_HEADER_ID = " + txtHdrId.Text + " where SHARES_TRACKER_BUY_ID = " + iintUpdateId;
                else
                    str = "Update SHARES_TRACKER_BUY Set SHARES_PRICE_AMT = " + txtShareAmt.Text + ", SHARES_QUANTITY = " + txtShareQty.Text + ", SHARES_BUY_DATE = '" + strdate + "', SHARES_CHARGES_AMT = " + txtShareCharges.Text + " , SHARES_TRACKER_HEADER_ID = " + txtHdrId.Text + " where SHARES_TRACKER_BUY_ID = " + iintUpdateId;
            }
            else
            {
                if (txtShareCharges.Text == string.Empty)
                    str = "Update SHARES_TRACKER_SELL Set SHARES_PRICE_AMT = " + txtShareAmt.Text + ", SHARES_QUANTITY = " + txtShareQty.Text + ", SHARES_SELL_DATE = '" + strdate + "' , SHARES_TRACKER_HEADER_ID = " + txtHdrId.Text + " where SHARES_TRACKER_SELL_ID = " + iintUpdateId;
                else
                    str = "Update SHARES_TRACKER_SELL Set SHARES_PRICE_AMT = " + txtShareAmt.Text + ", SHARES_QUANTITY = " + txtShareQty.Text + ", SHARES_SELL_DATE = '" + strdate + "', SHARES_CHARGES_AMT = " + txtShareCharges.Text + " , SHARES_TRACKER_HEADER_ID = " + txtHdrId.Text + " where SHARES_TRACKER_SELL_ID = " + iintUpdateId;
            }
            DBFunction.UpdateTable(Constant.Common.DATABASE_NAME, str);
            if (checkHeaderUpdate.Checked)
            {
                Share.ShareHeaderId = Convert.ToInt32(txtHdrId.Text);
            }
            this.sHARE_DETAIL_PROCEDURETableAdapter.Fill(this.shares_TrackerDataset.SHARE_DETAIL_PROCEDURE, Share.ShareHeaderId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkHeaderUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHeaderUpdate.Checked)
            {
                checkHeaderUpdate.Visible = false;
                txtHdrId.Visible = true;
            }
        }
        #endregion
    }
}
