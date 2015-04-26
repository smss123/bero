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
using bero_System;
using System.Threading;
using DataLayer;
using DataLayer.XProject;
using Telerik.WinControls;
namespace bero_System.ProjectForms
{
    public partial class FrmManageProject : RadForm
    {
        public FrmManageProject()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            FrmAddProject frm = new FrmAddProject();
            frm.Show();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmManageProject_Load(sender, e);

        }
        void PopulateDgv()
        {
            var LstProjects = ProjectProfileCommand.GetAll();
            this.Invoke((MethodInvoker)delegate { DGVProducts.DataSource = LstProjects; });

        }
        private void FrmManageProject_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(PopulateDgv);
            th.Start();
        }

        private void DGVProducts_CommandCellClick(object sender, EventArgs e)
        {
            if (DGVProducts.Rows.Count != 0)
            {
                var col = DGVProducts.CurrentColumn.Index;
                if (col == 8)
                {
                   
                    Operation.BeginOperation(this);
                    FrmEditProject frm = new FrmEditProject();

                    ProjectProfile tb = (ProjectProfile)DGVProducts.CurrentRow.DataBoundItem;
                    frm.TargetProject = tb;
                    frm.CustomerComboBox.Text = DGVProducts.CurrentRow.Cells[6].Value.ToString();
                    frm.ShowDialog();
                    Operation.EndOperation(this);
                }
                if (col == 9)
                {
                    Operation.BeginOperation(this);
                    RadMessageBox.ThemeName = this.ThemeName;
                    if (RadMessageBox.Show("هل تريد حذف المشروع؟", "", MessageBoxButtons.YesNo, RadMessageIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        try
                        {
                            ProjectProfileCommand.DeleteProject(int.Parse(DGVProducts.CurrentRow.Cells[0].Value.ToString()));
                            FrmManageProject_Load(sender, e);
                        }
                        catch (Exception ex)
                        {
                            // MessageBox.Show(ex.Message);
                            if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint "))
                            {
                                RadMessageBox.Show("لا يمكن حذف المشروع لانه مرتبط ببعض العمليات في النظام");
                            }
                        }



                    }

                   

                   

                    Operation.EndOperation(this);
                }
            }
        }
    }
}
