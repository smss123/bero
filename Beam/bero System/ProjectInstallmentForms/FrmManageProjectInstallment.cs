using DataLayer;
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

using DataLayer.XProject;
using DataLayer;
using System.Threading;
using bero_System.ReportSystem.ReportOBj;
using bero_System.ReportSystem.ReportCommand;
using Telerik.WinControls;

namespace bero_System.ProjectInstallmentForms
{
    public partial class FrmManageProjectInstallment : RadForm
    {
        public FrmManageProjectInstallment()
        {
            InitializeComponent();
        }
        public ProjectProfile TargetProject { get; set; }

        void PopulateDgv()
        {
            var q = ProjectInstallmentCommand.GetAllProjectInstallmentByProjectId(TargetProject.ID);
            this.Invoke((MethodInvoker)delegate { DGVInstalments.DataSource = q; });

        }
        private void FrmManageProjectInstallment_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(PopulateDgv);
            th.Start();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            FrmAddProjectInstallment frm = new FrmAddProjectInstallment();
            frm.TargetProject = this.TargetProject;
            frm.ShowDialog();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmManageProjectInstallment_Load(sender, e);
        }

        private void DGVInstalments_CommandCellClick(object sender, EventArgs e)
        {
            var col = DGVInstalments.CurrentColumn.Index;
            if (col == 8)
            {

                Operation.BeginOperation(this);

                FrmEditProjectInstallment frm = new FrmEditProjectInstallment();

                ProjectInstallment tb = (ProjectInstallment)DGVInstalments.CurrentRow.DataBoundItem;

               // frm.projectLevelComboBox.Text = DGVInstalments.CurrentRow.Cells[7].Value.ToString();

                frm.TargetInstalment = tb;

                frm.ShowDialog();

                Operation.EndOperation(this);
            }
            if (col == 9)
            {

                Operation.BeginOperation(this);
                RadMessageBox.ThemeName = this.ThemeName;
                if (RadMessageBox.Show("هل تريد الحذف؟")==System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        ProjectInstallmentCommand.DeleteprojectInstallment(int.Parse(DGVInstalments.CurrentRow.Cells[0].Value.ToString()));

                        FrmManageProjectInstallment_Load(sender, e);
                    }
                    catch (Exception EX)
                    {

                        RadMessageBox.Show("لا بمكن الحذف لانه قد يكون العنصر مربوط مع عناصر اخرى");

                    }
                   

                  
                }

                Operation.EndOperation(this);
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ProjectInstallmentObj cmd = new ProjectInstallmentObj();
            cmd.CustomerName = TargetProject.Customer.CustomerName;
            cmd.ProjectName = TargetProject.ProjectName;

            ProjectInstallmentCommandRpt RepCmd = new ProjectInstallmentCommandRpt();
            RepCmd.ProjectInstallmentByProId(TargetProject.ID);
        }

        private void DGVInstalments_Click(object sender, EventArgs e)
        {

        }
    }
}
