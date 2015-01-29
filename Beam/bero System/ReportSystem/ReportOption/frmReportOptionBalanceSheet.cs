using bero_System.ReportSystem.ReportCommand;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace bero_System.ReportSystem.ReportOption
{
    public partial class frmReportOptionBalanceSheet : RadForm
    {
        public frmReportOptionBalanceSheet()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (AllYearcheckBox.Checked)
            {
                BalanceSheetCommandRpt cmd = new BalanceSheetCommandRpt();
                cmd.GetBalanceSheet();
            }
            else
            {
                //--
            }
        }
    }
}
