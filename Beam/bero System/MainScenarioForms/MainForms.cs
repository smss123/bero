using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DataLayer;
using DataLayer.Security;
using DataLayer.XCustomer;
using Telerik.WinControls.UI;
using bero_System.AccountForms;
using bero_System.BulidItemForms;
using bero_System.CustomerForms;
using bero_System.EmployeeForms;
using bero_System.ProjectForms;
using bero_System.SecurityForms;
using bero_System.ReportSystem.ReportOption;
using bero_System.ProjectOffers;
using System.Drawing;

namespace bero_System.MainScenarioForms
{
    public partial class MainForms : RadForm
    {


        private void SetBalloonTip()
        {
          

            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.BalloonTipTitle = "Berm";
            notifyIcon1.BalloonTipText = "Powered By : Xprema Software Systems Company  2015";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(3000);
        }

        public MainForms()
        {
            InitializeComponent();
            if (Convert.ToBoolean(LoginInfomation.CurrnetUser.UserPermessions[0].PermessionValue) == false) { this.ManageProjects.Enabled = false; }
            if (Convert.ToBoolean(LoginInfomation.CurrnetUser.UserPermessions[1].PermessionValue) == false) { this.CustomersManager.Enabled = false; }
            if (Convert.ToBoolean(LoginInfomation.CurrnetUser.UserPermessions[2].PermessionValue) == false) { this.UsersManager.Enabled = false; }
            if (Convert.ToBoolean(LoginInfomation.CurrnetUser.UserPermessions[3].PermessionValue) == false) { this.EmployeesManager.Enabled = false; }
            if (Convert.ToBoolean(LoginInfomation.CurrnetUser.UserPermessions[4].PermessionValue) == false) { this.ItemsManager.Enabled = false; }
            if (Convert.ToBoolean(LoginInfomation.CurrnetUser.UserPermessions[5].PermessionValue) == false) { this.AccountsManager.Enabled = false; }

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
            SetBalloonTip();


            bool checkprojects = IsEndOfMonth();
            if (checkprojects == true)
            {
                FrmAlertExpireProjects frm = new FrmAlertExpireProjects();
                frm.Show();
            }

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
           

        }
        #endregion 

        private void CustomerGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = CustomerGridView.CurrentColumn.Index;
            if (col == 5)
            {

                Operation.BeginOperation(this);
                FrmMainProjectsCustomer frm = new FrmMainProjectsCustomer();

                Customer tb = (Customer)CustomerGridView.CurrentRow.DataBoundItem;
              
                frm.TargetCustomer = tb;

                frm.ShowDialog();
                Operation.EndOperation(this);
            }
        }
        public static bool IsEndOfMonth()
        {
            int day = DateTime.Now.Day;
            bool status = false;
            if (day == DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month))
            {
                status = true;
            }
            return status;
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

        private void MainForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TrialbalanceBtn_Click(object sender, EventArgs e)
        {
            FrmAllStatistices frm = new FrmAllStatistices();
            frm.ShowDialog();
        }

        private void empReportBtn_Click(object sender, EventArgs e)
        {
            EmployeeReportOption frm = new EmployeeReportOption();
            frm.ShowDialog();
        }

        private void ProjectOffersBtn_Click(object sender, EventArgs e)
        {
            FrmProjectOffers frm = new FrmProjectOffers();
            frm.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void تقاريرالاجازاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHoldyempReportOption frm = new FrmHoldyempReportOption();
            frm.ShowDialog();
        }

        private void CustomerGridView_Click(object sender, EventArgs e)
        {

        }

   

    }
}
