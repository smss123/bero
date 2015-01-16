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
using DataLayer.XCustomer;
using DataLayer;
using System.Threading;
namespace bero_System.CustomerForms
{
    public partial class FrmManageCustomer : RadForm
    {
        public FrmManageCustomer()
        {
            InitializeComponent();
        }
        #region "^^^^ Populate Grid"
       public  void PopulateDgv()
        {
            var LstCustomers= CustomerCommand.GetAll();
            this.Invoke((MethodInvoker)delegate { DGVCustomers.DataSource = LstCustomers; });
           
        }

        #endregion 

        private void FrmManageCustomer_Load(object sender, EventArgs e)
        {
            Thread CustomersThread = new Thread(PopulateDgv);
            CustomersThread.Start();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            FrmAddCustomer frm = new FrmAddCustomer();
            frm.Show();
            this.Hide();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmManageCustomer_Load(sender, e);
        }

        private void DGVCustomers_CommandCellClick(object sender, EventArgs e)
        {
            var col = DGVCustomers.CurrentColumn.Index;
            if (col == 7)
            {
               
                Operation.BeginOperation(this);
                FrmEditCustomer frm = new FrmEditCustomer();

                Customer tb = (Customer)DGVCustomers.CurrentRow.DataBoundItem;
                frm.TargetRecord = tb;

                frm.ShowDialog();
                Operation.EndOperation(this);
            }
            if (col == 8)
            {

                Operation.BeginOperation(this);

                CustomerCommand .DeleteCustomer (int.Parse(DGVCustomers.CurrentRow.Cells[0].Value.ToString()));
                FrmManageCustomer_Load(sender, e);

                Operation.EndOperation(this);
            }
        }
    }
}
