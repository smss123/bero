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
using Telerik.WinControls;
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
            this.Invoke((MethodInvoker)delegate { BulidItemGridView.DataSource = LstCustomers; });
           
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
            frm.ShowDialog();
           
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmManageCustomer_Load(sender, e);
        }

        private void BulidItemGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = BulidItemGridView.CurrentColumn.Index;
            if (col == 4)
            {
               
                Operation.BeginOperation(this);
                FrmEditCustomer frm = new FrmEditCustomer();

                Customer tb = (Customer)BulidItemGridView.CurrentRow.DataBoundItem;
                frm.TargetRecord = tb;

                frm.ShowDialog();
                Operation.EndOperation(this);
            }
            if (col == 5)
            {

                Operation.BeginOperation(this);
                 RadMessageBox.ThemeName = this.ThemeName;
                 if (RadMessageBox.Show("هل تريد حذف العميل؟", "", MessageBoxButtons.YesNo, RadMessageIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                 {
                     try
                     {
                         CustomerCommand.DeleteCustomer(int.Parse(BulidItemGridView.CurrentRow.Cells[0].Value.ToString()));
                         FrmManageCustomer_Load(sender, e);
                     }
                     catch (Exception ex)
                     {
                         if (ex.Message.Contains("This is not supported"))
                         {
                             RadMessageBox.Show("لا يمكن حذف العميل لانه مرتبط ببعض العمليات في النظام");
                         }
                         if (ex.Message.Contains("he DELETE statement conflicted with the REFERENCE constraint"))
                         {
                             RadMessageBox.Show("لا يمكن حذف العميل لانه مرتبط ببعض العمليات في النظام");


                         }
                     }
                     
                 }
                Operation.EndOperation(this);
            }
        }
    }
}
