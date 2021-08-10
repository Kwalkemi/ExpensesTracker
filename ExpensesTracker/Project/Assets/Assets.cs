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

namespace ExpensesTracker.Project.Assets
{
    public partial class Assets : Form
    {
        public Assets()
        {
            InitializeComponent();
        }

        public int iintUpdateId { get; set; }
        public int iintAssetHdrId { get; set; }

        private void Assets_Load(object sender, EventArgs e)
        {
            string lstrQuery = "SELECT ASSET_HEADER_ID FROM ASSET_HEADER WHERE USER_LOGIN_ID = " + Login.UserId;
            lblFinalAssetValue.Text = string.Empty;
            lblChangeAmtPercValue.Text = string.Empty;
            lblChangeAmtValue.Text = string.Empty;
            iintAssetHdrId = Convert.ToInt32(DBFunction.FetchScalarFromDatabase(Constant.Common.DATABASE_NAME, lstrQuery));
            GetTotalAssetAmt();
            this.aSSET_PROCEDURETableAdapter1.Fill(this.assets1.ASSET_PROCEDURE, Login.UserId);
        }

        private void GetTotalAssetAmt()
        {
            string lstrQuery = "SELECT ASSET_TOTAL_AMOUNT FROM ASSET_HEADER WHERE USER_LOGIN_ID = " + Login.UserId;
            lblFinalAssetValue.Text = Convert.ToString(DBFunction.FetchScalarFromDatabase(Constant.Common.DATABASE_NAME, lstrQuery));

            lstrQuery = "SELECT TOP 2 ASSET_TOTAL_AMOUNT FROM ASSET_HEADER_HISTORY WHERE USER_LOGIN_ID = " + Login.UserId + " ORDER BY ASSET_HEADER_HISTORY_ID DESC";
            DataTable ldtbTable = DBFunction.FetchDataFromDatabase(Constant.Common.DATABASE_NAME, lstrQuery);

            decimal firstnum, secondnum;
            if (ldtbTable != null && ldtbTable.Rows.Count > 0)
            {
                firstnum = ldtbTable.Rows[0]["ASSET_TOTAL_AMOUNT"] != System.DBNull.Value ? Convert.ToDecimal(ldtbTable.Rows[0]["ASSET_TOTAL_AMOUNT"]) : 0m;
                secondnum = ldtbTable.Rows[1]["ASSET_TOTAL_AMOUNT"] != System.DBNull.Value ? Convert.ToDecimal(ldtbTable.Rows[1]["ASSET_TOTAL_AMOUNT"]) : 0m;
                if (secondnum - firstnum > 0 && secondnum != 0)
                {
                    lblChangeAmtValue.Text = Convert.ToString(secondnum - firstnum);
                    lblChangeAmtPercValue.Text = Convert.ToString(Math.Round(Convert.ToDecimal(((secondnum - firstnum) * 100) / secondnum), 2)) + " %";
                }
                else if (firstnum - secondnum > 0 && secondnum != 0)
                {
                    lblChangeAmtValue.Text = Convert.ToString(firstnum - secondnum);
                    lblChangeAmtPercValue.Text = Convert.ToString(Math.Round(Convert.ToDecimal(((firstnum - secondnum) * 100) / secondnum), 2)) + " %";
                }
                else
                {
                    lblChangeAmtValue.Text = "0";
                    lblChangeAmtPercValue.Text = "0 %";
                }
            }
        }

        private void gridViewAsset_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            iintUpdateId = Convert.ToInt32(gridViewAsset.Rows[e.RowIndex].Cells[0].Value);
            iintAssetHdrId = Convert.ToInt32(gridViewAsset.Rows[e.RowIndex].Cells[1].Value);
            txtAssetDesc.Text = Convert.ToString(gridViewAsset.Rows[e.RowIndex].Cells[2].Value);
            txtAssetAmt.Text = Convert.ToString(gridViewAsset.Rows[e.RowIndex].Cells[3].Value);
        }

        private void gridViewAsset_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }

        private void btnAssetInsert_Click(object sender, EventArgs e)
        {
            if (txtAssetDesc.Text == string.Empty)
            {
                errorProvider1.SetError(txtAssetDesc, GlobalFunction.GetMessageById(Constant.Error.ERROR_15));
            }
            else if (txtAssetAmt.Text == string.Empty)
            {
                errorProvider1.SetError(txtAssetAmt, GlobalFunction.GetMessageById(Constant.Error.ERROR_16));
            }
            else
            {
                Dictionary<string, string> ldict = new Dictionary<string, string>();
                ldict.Add(TableEnum.enmAssetDetail.ASSET_DESCIPTION.ToString(), txtAssetDesc.Text);
                ldict.Add(TableEnum.enmAssetDetail.ASSET_AMOUNT.ToString(), txtAssetAmt.Text);
                ldict.Add(TableEnum.enmAssetDetail.ASSET_HEADER_ID.ToString(), iintAssetHdrId.ToString());
                DBFunction.InsertIntoTable(Constant.Common.DATABASE_NAME, TableEnum.enmTableName.ASSET_DETAIL.ToString(), ldict);
                this.aSSET_PROCEDURETableAdapter1.Fill(this.assets1.ASSET_PROCEDURE, Login.UserId);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string lstrAmtQuery = "SELECT SUM(ASSET_AMOUNT) FROM ASSET_DETAIL WHERE ASSET_HEADER_ID = " + iintAssetHdrId;
            string lstrAmt = DBFunction.FetchScalarFromDatabase(Constant.Common.DATABASE_NAME, lstrAmtQuery);

            lstrAmtQuery = "SELECT TOP 1 ASSET_TOTAL_AMOUNT FROM ASSET_HEADER_HISTORY WHERE USER_LOGIN_ID = " + Login.UserId + " ORDER BY ASSET_HEADER_HISTORY_ID DESC";
            string lstrAmtHistory = DBFunction.FetchScalarFromDatabase(Constant.Common.DATABASE_NAME, lstrAmtQuery);

            if (Convert.ToDecimal(lstrAmt) != Convert.ToDecimal(lstrAmtHistory))
            {
                string lstrQuery = "Update ASSET_HEADER Set ASSET_TOTAL_AMOUNT = " + lstrAmt + " Where ASSET_HEADER_ID =" + iintAssetHdrId;
                DBFunction.FetchScalarFromDatabase(Constant.Common.DATABASE_NAME, lstrQuery);
            }
            GetTotalAssetAmt();
        }

        private void btnAssetUpdate_Click(object sender, EventArgs e)
        {
            if (txtAssetDesc.Text == string.Empty)
            {
                errorProvider1.SetError(txtAssetDesc, GlobalFunction.GetMessageById(Constant.Error.ERROR_15));
            }
            else if (txtAssetAmt.Text == string.Empty)
            {
                errorProvider1.SetError(txtAssetAmt, GlobalFunction.GetMessageById(Constant.Error.ERROR_16));
            }
            else
            {
                Dictionary<string, string> ldict = new Dictionary<string, string>();
                string lstrQuery = "Update ASSET_DETAIL Set ASSET_HEADER_ID = " + iintAssetHdrId + ", ASSET_DESCIPTION = '" + txtAssetDesc.Text + "', ASSET_AMOUNT = " + txtAssetAmt.Text + " Where ASSET_DETAIL_ID = " + iintUpdateId;
                DBFunction.UpdateTable(Constant.Common.DATABASE_NAME, lstrQuery);
                this.aSSET_PROCEDURETableAdapter1.Fill(this.assets1.ASSET_PROCEDURE, Login.UserId);
            }
        }

        private void lnkAssetsBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ExpensesMain expenses = new ExpensesMain();
            expenses.Show();
        }
    }
}
