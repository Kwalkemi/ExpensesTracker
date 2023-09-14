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
    public partial class TotalFamilyShare : Form
    {
        public TotalFamilyShare()
        {
            InitializeComponent();
        }

        private void TotalFamilyShare_Load(object sender, EventArgs e)
        {
            string lstrbharat5paisa = GetTotalAmountByUserIdAndDematAccountId(1, "PAIS");
            lblBharat5PaisaValue.Text = lstrbharat5paisa;
            lblBharatMotilalOswalValue.Text = GetTotalAmountByUserIdAndDematAccountId(1, "MOTI");
            lblBharatGrowwValue.Text = GetTotalAmountByUserIdAndDematAccountId(1, "GROW");

            lblAnjali5PaisaValue.Text = GetTotalAmountByUserIdAndDematAccountId(2, "PAIS");
            lblAnjaliIIFLValue.Text = GetTotalAmountByUserIdAndDematAccountId(2, "IIFL");
            lblAnjaliGrowwValue.Text = GetTotalAmountByUserIdAndDematAccountId(2, "GROW");

            lblFamilySumValue.Text = Convert.ToString(Convert.ToDecimal(lstrbharat5paisa) + Convert.ToDecimal(lblBharatMotilalOswalValue.Text) + Convert.ToDecimal(lblBharatGrowwValue.Text) +
                Convert.ToDecimal(lblAnjali5PaisaValue.Text) + Convert.ToDecimal(lblAnjaliIIFLValue.Text) + Convert.ToDecimal(lblAnjaliGrowwValue.Text));
        }

        private string GetTotalAmountByUserIdAndDematAccountId(int UserId, string DematAccountValue)
        {
            string lstrReturnValue = string.Empty, lstrFetchQuery = string.Empty;

            lstrFetchQuery = "Select [dbo].[GetProfitByUserIdAndDematAccount](" + UserId + ", '" + DematAccountValue + "')";

            lstrReturnValue = DBFunction.FetchScalarFromDatabase(Constant.Common.DATABASE_NAME, lstrFetchQuery);

            return lstrReturnValue;
        }
    }
}
