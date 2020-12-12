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
    public partial class Error : Form
    {
        public Error()
        {
            InitializeComponent();
        }

        public static string Exception_Msg = string.Empty;
        public static string Source = string.Empty;
        public static string Stack_Trace = string.Empty;

        private void Error_Load(object sender, EventArgs e)
        {
            lblExceptionMsgValue.Text = Exception_Msg;
            lblSourceValue.Text = Source;
            lblStackTraceValue.Text = Stack_Trace;
        }
    }
}
