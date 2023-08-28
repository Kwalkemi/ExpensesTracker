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
    public partial class MutualFundDetail : Form
    {
        public MutualFundDetail()
        {
            InitializeComponent();
        }

        #region Properties
        public int iintUpdateId { get; set; }
        public string istrTransactionType { get; set; }
        #endregion

        private void MutualFundDetail_Load(object sender, EventArgs e)
        {
            this.Size = new Size(754, 470);
            string str = "Select MUTUAL_FUND_NAME from [dbo].[MUTUAL_FUND_HEADER] where MUTUAL_FUND_HEADER_ID = " + MutualFund.MutualFundHeaderId;
            lblMutualFundName.Text = DBFunction.FetchScalarFromDatabase(Constant.Common.DATABASE_NAME, str);

            txtMFCharges.Visible = false;
            txtMFQty.Visible = false;
            txtMFAmt.Visible = false;
            dateMFDate.Visible = false;
            btnUpdateShareDetail.Visible = false;
            lblUpdate.Visible = false;
            txtMFHdrId.Visible = false;
            lblHdr.Visible = false;
            checkHeaderUpdate.Visible = false;
        }
    }
}
