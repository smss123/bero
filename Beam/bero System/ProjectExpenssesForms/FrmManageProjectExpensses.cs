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
using DataLayer;
using DataLayer.XProject;
using System.Threading;

namespace bero_System.ProjectExpenssesForms
{
    public partial class FrmManageProjectExpensses : RadForm
    {
        public FrmManageProjectExpensses()
        {
            InitializeComponent();
        }


        void PopulateGrd()
        {
            var q = ProjectExpenssesCommand.GetAll();
            this.Invoke((MethodInvoker)delegate { DGVExpensses.DataSource = q; });
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            FrmAddProjectExpensses frm = new FrmAddProjectExpensses();
            frm.Show();
        }

        private void FrmManageProjectExpensses_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(PopulateGrd);
            th.Start();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmManageProjectExpensses_Load(sender, e);
        }

        private void DGVExpensses_CommandCellClick(object sender, EventArgs e)
        {
            var col = DGVExpensses.CurrentColumn.Index;
            if (col == 7)
            {
                
                Operation.BeginOperation(this);
                FrmEditProjectExpensses frm = new FrmEditProjectExpensses();

                ProjectExpenss tb = (ProjectExpenss)DGVExpensses.CurrentRow.DataBoundItem;
                frm.TargetExp = tb;
                frm.expenssesComboBox.Text = this.DGVExpensses.CurrentRow.Cells[4].Value.ToString();
                frm.projectLevelComboBox.Text = this.DGVExpensses.CurrentRow.Cells[5].Value.ToString();


                frm.ShowDialog();
                Operation.EndOperation(this);
            }
            if (col == 8)
            {

                Operation.BeginOperation(this);

                ProjectExpenssesCommand.DeleteProjectExpenss (int.Parse(DGVExpensses.CurrentRow.Cells[0].Value.ToString()));
                FrmManageProjectExpensses_Load(sender, e);

                Operation.EndOperation(this);
            }
        }
    }
}
