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
using DataLayer.XProject;
namespace bero_System.ProjectQuantityForms
{
    public partial class frmManageProjectQuantity : RadForm
    {
        public frmManageProjectQuantity()
        {
            InitializeComponent();
        }
        public ProjectProfile TargetProject { get; set; }
        void PopulateDgv()
        {
            var LstQuantity = ProjectQuantityCommand.GetByPojectProfileID(TargetProject.ID);
            this.Invoke((MethodInvoker)delegate { ProjectQuantityGridView.DataSource = LstQuantity; });

        }
        private void frmManageProjectQuantity_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(PopulateDgv);
            th.Start();
        }

        private void ProjectQuantityGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = ProjectQuantityGridView.CurrentColumn.Index;
            if (col == 4)
            {

                Operation.BeginOperation(this);
                frmEditProjectQuantity frm = new frmEditProjectQuantity();

                ProjectQuantity tb = (ProjectQuantity)ProjectQuantityGridView.CurrentRow.DataBoundItem;

                frm.TargetProject = tb;

                frm.ShowDialog();
                Operation.EndOperation(this);
            }
            if (col == 5)
            {

                Operation.BeginOperation(this);

                ProjectQuantityCommand .DeleteProjectQuantity (int.Parse(ProjectQuantityGridView.CurrentRow.Cells[0].Value.ToString()));
                frmManageProjectQuantity_Load(sender, e);

                Operation.EndOperation(this);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            frmAddProjectQuantity frm = new frmAddProjectQuantity();
            frm.ShowDialog();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            frmManageProjectQuantity_Load(sender, e);
        }
    }
}
