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
using bero_System.AccountForms;
using bero_System.EmployeeForms;
using bero_System.SecurityForms;

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

        private void ManageAccountCategory_Click(object sender, EventArgs e)
        {
            FrmManageAccountCategory frm = new FrmManageAccountCategory();
            frm.ShowDialog();
        }

        private void ManageAccount_Click(object sender, EventArgs e)
        {
            FrmManageAccount frm = new FrmManageAccount();
            frm.ShowDialog();
        }

        private void AccountDailySHow_Click(object sender, EventArgs e)
        {
            frmAccountDailySHow frm = new frmAccountDailySHow();
            frm.ShowDialog();
        }

        private void ManageExpensses_Click(object sender, EventArgs e)
        {
            FrmManageExpensses frm = new FrmManageExpensses();
            frm.ShowDialog();
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            FrmAddBulidItem frm = new FrmAddBulidItem();
            frm.ShowDialog();
        }

        private void ManageItem_Click(object sender, EventArgs e)
        {
            FrmManageBulidItem frm = new FrmManageBulidItem();
            frm.ShowDialog();
        }

        private void AddEmpployeeBtn_Click(object sender, EventArgs e)
        {
            FrmAddEmployee frm = new FrmAddEmployee();
            frm.ShowDialog();
        }

        private void EditEmployeebtn_Click(object sender, EventArgs e)
        {
            FrmManageEmployee frm = new FrmManageEmployee();
            frm.ShowDialog();
        }

        private void AddProjectBtn_Click(object sender, EventArgs e)
        {
            FrmAddProject frm = new FrmAddProject();
            frm.ShowDialog();
        }

        private void ManageProjectBtn_Click(object sender, EventArgs e)
        {
            FrmManageProject frm=new FrmManageProject();
            frm.ShowDialog();
        }

        private void AccountsTreeBtn_Click(object sender, EventArgs e)
        {
            frmAccountTree frm = new frmAccountTree();
            frm.ShowDialog();
        }

        private void AddHolyDayBtn_Click(object sender, EventArgs e)
        {
            FrmAddHolyDay frm = new FrmAddHolyDay();
            frm.ShowDialog();

        }

        private void ManageHolyDayBtn_Click(object sender, EventArgs e)
        {
            FrmManageHolyDay frm = new FrmManageHolyDay();
            frm.ShowDialog();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            FrmAddUser frm = new FrmAddUser();
            frm.ShowDialog();
        }

        private void EditUser_Click(object sender, EventArgs e)
        {
            FrmManageUser frm = new FrmManageUser();
            frm.ShowDialog();
        }

 
        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            FrmChangeUSerPassword frm = new FrmChangeUSerPassword();
            frm.ShowDialog();
        }

   

    }
}
