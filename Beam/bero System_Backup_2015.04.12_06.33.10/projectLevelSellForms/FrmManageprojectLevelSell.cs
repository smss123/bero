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

using System.Threading;
using DataLayer;
using DataLayer.XProject;
using Telerik.WinControls;
namespace bero_System.projectLevelSellForms
{
    public partial class FrmManageprojectLevelSell : RadForm
    {
        public FrmManageprojectLevelSell()
        {
            InitializeComponent();
        }

        void PopulateDgv()
        {
            var q = projectLevelSellCommand.GetAllByProjectId(TargetProject.ID);
            this.Invoke((MethodInvoker)delegate { projectLevelSellGridView.DataSource = q; });
        }
        public ProjectProfile TargetProject { get; set; }
        private void FrmManageprojectLevelSell_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(PopulateDgv);
            th.Start();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            FrmAddprojectLevelSell frm = new FrmAddprojectLevelSell();
            frm.TargetProject = this.TargetProject;

            frm.ShowDialog();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmManageprojectLevelSell_Load(sender, e);
        }

        private void projectLevelSellGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = projectLevelSellGridView.CurrentColumn.Index;
            if (col == 7)
            {

                Operation.BeginOperation(this);

                FrmEditprojectLevelSell frm = new FrmEditprojectLevelSell();

                projectLevelSell tb = (projectLevelSell)projectLevelSellGridView.CurrentRow.DataBoundItem;
                frm.ProjectID = TargetProject.ID;
                frm.projectLevelComboBox.Text = projectLevelSellGridView.CurrentRow.Cells[6].Value.ToString();

                frm.TargetSelTable = tb;

                frm.ShowDialog();

                Operation.EndOperation(this);
            }
            if (col == 8)
            {

                try
                {
                    RadMessageBox.ThemeName = this.ThemeName;
                    if (RadMessageBox.Show("هل تريد الحذف؟","",MessageBoxButtons.YesNo,RadMessageIcon.Question)== System.Windows.Forms.DialogResult.Yes)
                    {
                        Operation.BeginOperation(this);

                        projectLevelSellCommand.DeleteprojectLevelSell(int.Parse(projectLevelSellGridView.CurrentRow.Cells[0].Value.ToString()));

                        FrmManageprojectLevelSell_Load(sender, e);

                        Operation.EndOperation(this);
                    }
                    
                }
                catch (Exception ex)
                {
                    RadMessageBox.Show(ex.Message);
                    
                }
               
            }
        }
    }
}
