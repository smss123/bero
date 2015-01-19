using bero_System.CustomerForms;
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
using bero_System.ProjectForms;
using System.Threading;
using DataLayer.XCustomer;
using bero_System.BulidItemForms;
using DataLayer;
namespace bero_System.MainScenarioForms
{
    public partial class MainForms : RadForm
    {
        public MainForms()
        {
            InitializeComponent();
        }

        void LoadingAllCustomers()
        {
            var LstCustomers = CustomerCommand.GetAll();
            this.Invoke((MethodInvoker)delegate { CustomerGridView.DataSource = LstCustomers; });
        }
        private void MainForms_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(LoadingAllCustomers);
            th.Start();
        }

        #region " ^^^ Open Forms"
        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            FrmAddCustomer Frm = new FrmAddCustomer();
            Frm.ShowDialog();
        }

        private void ManageCustomerBtn_Click(object sender, EventArgs e)
        {
            FrmManageCustomer frm = new FrmManageCustomer();
            frm.Show();
        }


    

        private void ManageProjects_Click(object sender, EventArgs e)
        {
            FrmManageProject FRM = new FrmManageProject();
            FRM.Show();
        }

        

        private void toolStripDropDownButton4_Click(object sender, EventArgs e)
        {
            FrmManageBulidItem FRM = new FrmManageBulidItem();
            FRM.Show();

        }
        #endregion 

        private void CustomerGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = CustomerGridView.CurrentColumn.Index;
            if (col == 7)
            {

                Operation.BeginOperation(this);
                FrmMainProjectsCustomer frm = new FrmMainProjectsCustomer();

                Customer tb = (Customer)CustomerGridView.CurrentRow.DataBoundItem;
                frm.TargetCustomer = tb;

                frm.ShowDialog();
                Operation.EndOperation(this);
            }
        }

    }
}
