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
//================================
using System.Threading;
using DataLayer;
using DataLayer.XAccountant;
namespace bero_System.AccountForms
{
    public partial class frmAccountDailySHow : RadForm
    {
        public frmAccountDailySHow()
        {
            InitializeComponent();
        }

        void PopulateGrid()
        {
            Operation.BeginOperation(this);
            var q = AccountDailyCommand.GetAll ();
            this.Invoke((MethodInvoker)delegate { DGVAccountsDaily.DataSource = q; });
            Operation.EndOperation(this);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmAccountDailySHow_Load(object sender, EventArgs e)
        {

            Thread th = new Thread(PopulateGrid);
            th.Start();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            frmAccountDailySHow_Load( sender,  e);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }

    }
}
