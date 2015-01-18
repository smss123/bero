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
    public partial class FrmManageAccountCategory : RadForm
    {
        public FrmManageAccountCategory()
        {
            InitializeComponent();
        }


        void PopulateGrid()
        {
            Operation.BeginOperation(this);
            var q = AccountCategoryCmd.GetAll();
            this.Invoke((MethodInvoker)delegate { DGVAccountsCategories.DataSource = q; });
            Operation.EndOperation(this);
        }

        private void FrmManageAccountCategory_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(PopulateGrid); th.Start();
        }

        private void DGVAccountsCategories_CommandCellClick(object sender, EventArgs e)
        {
            var col = DGVAccountsCategories.CurrentColumn.Index;
            if (col == 3)
            {
                Operation.BeginOperation(this);
                FrmEditAccountCategory frm = new FrmEditAccountCategory();
                AccountCategory tb = (AccountCategory)DGVAccountsCategories.CurrentRow.DataBoundItem;
                frm.TragetActCategory = tb;
                frm.ShowDialog();
                Operation.EndOperation(this);
            }
        }

    }
}
