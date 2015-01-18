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
using DataLayer.XAccountant;
namespace bero_System.AccountForms
{
    public partial class FrmManageExpensses : RadForm
    {
        public FrmManageExpensses()
        {
            InitializeComponent();
        }

        private void FillData()
        {

            statusStrip1.Invoke((MethodInvoker)delegate
            {

                toolStrip1.Text = "Loading .. ";

            });
            Operation.BeginOperation(this);

            Application.DoEvents();

            var q = ExpenssesCommand.GetAll();
            Application.DoEvents();

            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                ExpenssesGridView.DataSource = q;
                toolStrip1.Text = "Compelete Load .... ";

            });
        }

        private void FrmManageExpensses_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(FillData);
            th.Start();
        }

        private void ExpenssesGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = ExpenssesGridView.CurrentColumn.Index;
            if (col == 4)
            {
                Operation.BeginOperation(this);
                FrmEditExpensses frm = new FrmEditExpensses();
                Expenss tb = (Expenss)ExpenssesGridView.CurrentRow.DataBoundItem;
                frm.TragetExpenss = tb;
                frm.ShowDialog();
                Operation.EndOperation(this);
            }

            //if (col == 5)
            //{


            //    Operation.BeginOperation(this);
          

            //    Operation.EndOperation(this);

            //}
        }


    }
}
