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
using System.Threading;
using DataLayer;
using DataLayer.XProject;
using bero_System.ProjectExpenssesForms;
using bero_System.projectLevelFroms;
using bero_System.ProjectQuantityForms;
using bero_System.projectLevelSellForms;
using bero_System.ProjectInstallmentForms;
using bero_System.ReportSystem.ReportCommand;



namespace bero_System.MainScenarioForms
{
    public partial class FrmViewProject : RadForm
    {
        public FrmViewProject()
        {
            InitializeComponent();
        }
        public ProjectProfile  TargetProject { get; set; }

        void LoadingProjectData()
        {
            projectNameTextBox.Text = TargetProject.ProjectName;
            projectDescriptionTextBox.Text = TargetProject.ProjectDescription ;
            projectFullAmountTextBox.Text = TargetProject.ProjectFullAmount.ToString ();
            CreatDatetextBox.Text = TargetProject.createdDate.ToString();
            DeliverDatetextBox.Text = TargetProject.DeliverDate.ToString();

        }
        private void FrmViewProject_Load(object sender, EventArgs e)
        {
            LoadingProjectData();
        }
       
        private void ProjectExpensessBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void ProjectLevelsBtn_Click(object sender, EventArgs e)
        {
          
        }

        private void QuantityBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void AddprojectLevelBtn_Click(object sender, EventArgs e)
        {
            FrmAddprojectLevel frm = new FrmAddprojectLevel();
            frm.TargetProjectx = this.TargetProject;
            frm.ShowDialog();
        }

        private void ManageprojectLevelBtn_Click(object sender, EventArgs e)
        {
            FrmManageprojectLevel frm = new FrmManageprojectLevel();
            frm.TargetProjectx = this.TargetProject;
            frm.ShowDialog();
        }

        private void AddprojectLevelSellBtn_Click(object sender, EventArgs e)
        {
            FrmAddprojectLevelSell frm = new FrmAddprojectLevelSell();
            frm.TargetProject = this.TargetProject;
            frm.ShowDialog();
        }

        private void ManageprojectLevelSellBtn_Click(object sender, EventArgs e)
        {
            FrmManageprojectLevelSell frm = new FrmManageprojectLevelSell();
            frm.TargetProject = this.TargetProject;
            frm.ShowDialog();
        }

        private void AddProjectQuantityBtn_Click(object sender, EventArgs e)
        {
            frmAddProjectQuantity frm = new frmAddProjectQuantity();
            frm.TargetProject = this.TargetProject;
            frm.ShowDialog();
        }

        private void ManageProjectQuantityBtn_Click(object sender, EventArgs e)
        {
            frmManageProjectQuantity frm = new frmManageProjectQuantity();
            frm.TargetProject = this.TargetProject;
            frm.ShowDialog();
        }

        private void AddProjectExpenssesBtn_Click(object sender, EventArgs e)
        {
            FrmAddProjectExpensses frm = new FrmAddProjectExpensses();
            frm.TargetProject = this.TargetProject;
            frm.ShowDialog();
        }

        private void ManageProjectExpensses_Click(object sender, EventArgs e)
        {
            FrmManageProjectExpensses frm = new FrmManageProjectExpensses();
            frm.TargetProject = this.TargetProject;
            frm.ShowDialog();
        }

        private void InstalmentsBtb_Click(object sender, EventArgs e)
        {
            FrmManageProjectInstallment frm = new FrmManageProjectInstallment();
            frm.TargetProject = this.TargetProject;
            frm.ShowDialog();

        }

        private void AddInstalmentBtn_Click(object sender, EventArgs e)
        {
            FrmAddProjectInstallment frm = new FrmAddProjectInstallment();
            frm.TargetProject = this.TargetProject;
            frm.ShowDialog();

        }

        private void تقريرالمشروعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            projectLevelCommandRpt cmdrpt = new projectLevelCommandRpt();
            cmdrpt.projectLevelByProId(TargetProject.ID);
        }

        private void تقريرالمشترياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            projectLevelSellCommandRpt CmdRpt = new projectLevelSellCommandRpt();
            CmdRpt.projectLevelSellByProId(TargetProject.ID);
        }

        private void تقريرالكمياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectQuantityCommandRpt Cmdrpt = new ProjectQuantityCommandRpt();
            Cmdrpt.rojectQuantityByProId(TargetProject.ID);

        }

        private void تقريراقساطالمشروعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectInstallmentCommandRpt cmdrpt = new ProjectInstallmentCommandRpt();
            cmdrpt.ProjectInstallmentByProId(TargetProject.ID);
        }

        private void تقريرمصروفاتالمشروعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectExpenssesCommandRpt cmdrpt = new ProjectExpenssesCommandRpt();
            cmdrpt.ProjectExpenssesByProId(TargetProject.ID);
        }


       

      

    }
}
