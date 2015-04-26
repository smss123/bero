using DataLayer;
using DataLayer.XAccountant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace bero_System.AccountForms
{
    public partial class FrmManageExpenssesMovment : RadForm
    {
        public Expenss TragetExpenss { get; set; }
        public FrmManageExpenssesMovment()
        {
            InitializeComponent();
        }
        Thread th;
        private void filldata()
        {

            statusStrip1.Invoke((MethodInvoker)delegate
            {

                toolStripStatusLabel1.Text = "جاري الانتظار.... ";

            });
            Operation.BeginOperation(this);

            Application.DoEvents();
            var q = ExpenssesMovmentCommand.GetAllExpenssesMovmentByExpID(TragetExpenss.ID);
            Application.DoEvents();

            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                ExpenssesMovmentGridView.DataSource = q;
                toolStripStatusLabel1.Text = "";

            });

            th.Abort();
          

        }
        private void FrmManageExpenssesMovment_Load(object sender, EventArgs e)
        {
            th = new Thread(filldata);
            th.Start();
            this.Text = string.Format("{0}-{1}", this.Text, TragetExpenss.ExpenssesName);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            FrmAddExpenssesMovment frm = new FrmAddExpenssesMovment();
            frm.ExpenssId = TragetExpenss.ID;
            frm.TragetExpensses = TragetExpenss;
            frm.ExpensessNameTextBox.Text = TragetExpenss.ExpenssesName;

            frm.ShowDialog();
            
        }

        private void ExpenssesMovmentGridView_CommandCellClick(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);

            FrmEditExpenssesMovment frm = new FrmEditExpenssesMovment();
            ExpenssesMovment tb = (ExpenssesMovment)ExpenssesMovmentGridView.CurrentRow.DataBoundItem;
            frm.TrExpMovment = tb;
            frm.ShowDialog();

            Operation.EndOperation(this);
        }
    }
}
