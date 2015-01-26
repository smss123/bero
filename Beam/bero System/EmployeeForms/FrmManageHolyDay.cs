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
using DataLayer.XEmployees;

namespace bero_System.EmployeeForms
{
    public partial class FrmManageHolyDay : RadForm
    {
        public FrmManageHolyDay()
        {
            InitializeComponent();
        }
        void PopulateDgv()
        {
            var q = HolyDayCmd.GetAllHolyDays();
            this.Invoke((MethodInvoker)delegate { DGVHolydays.DataSource = q; });

        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmManageHolyDay_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(PopulateDgv);
            th.Start();
        }

        private void DGVHolydays_CommandCellClick(object sender, EventArgs e)
        {
            var col = DGVHolydays.CurrentColumn.Index;
            if (col == 6)
            {

                Operation.BeginOperation(this);
                FrmEditHolyDay frm = new FrmEditHolyDay();

                HolyDay  tb = (HolyDay)DGVHolydays.CurrentRow.DataBoundItem;
                frm.EmployeeComboBox.Text = DGVHolydays.CurrentRow.Cells[1].Value.ToString();
                frm.TargetHolyday = tb;

                frm.ShowDialog();
                Operation.EndOperation(this);
            }
            if (col == 7)
            {

                Operation.BeginOperation(this);

               HolyDayCmd .DeleteHolyDay (int.Parse(DGVHolydays.CurrentRow.Cells[0].Value.ToString()));
                FrmManageHolyDay_Load(sender, e);

                Operation.EndOperation(this);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            FrmManageHolyDay_Load(sender, e);
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmAddHolyDay frm = new FrmAddHolyDay();
            frm.ShowDialog();
        }

    }
}
