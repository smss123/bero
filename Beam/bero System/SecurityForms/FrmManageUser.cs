using DataLayer;
using DataLayer.Security;
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
using DataLayer;
using DataLayer.Security;
namespace bero_System.SecurityForms
{
    public partial class FrmManageUser : RadForm
    {
        public FrmManageUser()
        {
            InitializeComponent();
        }
        Thread th;
        private void FillDataUser()
        {
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                toolStrip1.Text = "Loading .. ";

            });
            Operation.BeginOperation(this);

            Application.DoEvents();
            var q = UsersCmd.GetAllUsers();
            Application.DoEvents();

            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {
                UserGridView.DataSource = q;
                toolStrip1.Text = "Compelete Load .... ";

            });
        }
        private void FrmManageUser_Load(object sender, EventArgs e)
        {
            th = new Thread(FillDataUser);
            th.Start();
        }

        private void UserGridView_CommandCellClick(object sender, EventArgs e)
        {
            FrmEditUserPermession frm = new FrmEditUserPermession();
            frm.TragetUser = (SystemUser)UserGridView.CurrentRow.DataBoundItem;
            frm.ShowDialog();
        }
    }
}
