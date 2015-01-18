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
using DataLayer.XAccountant;
using DataLayer;
using System.Threading;
namespace bero_System.AccountForms
{
    public partial class FrmManageAccount : RadForm
    {
        public FrmManageAccount()
        {
            InitializeComponent();
        }
        void PopulateDgv()
        {
            var LstAccount = AccountCommand.GetAll();
            this.Invoke((MethodInvoker)delegate { AccountGridView.DataSource = LstAccount; });
        }
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmManageAccount_Load(sender, e);
        }

        private void FrmManageAccount_Load(object sender, EventArgs e)
        {
            Thread Th = new Thread(PopulateDgv);
            Th.Start();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            FrmAddAccount frm = new FrmAddAccount();
            frm.Show();
        }

        private void AccountGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = AccountGridView.CurrentColumn.Index;
            if (col == 5)
            {
                Operation.BeginOperation(this);
                FrmEditAccount frm = new FrmEditAccount();
                Account tb = (Account)AccountGridView.CurrentRow.DataBoundItem;
                frm.TargetAccount = tb;
                frm.CmbCategories.Text = AccountGridView.CurrentRow.Cells[1].Value.ToString();
                frm.ShowDialog();
                Operation.EndOperation(this);
            }
        }
    }
}
