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
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;

namespace bero_System.AccountForms
{
    public partial class FromPrivatewithdrawals : RadForm
    {
        public FromPrivatewithdrawals()
        {
            InitializeComponent();
        }
        Thread th;
        public void FillCmbo()
        {

            this.CmbFromAccount.MultiColumnComboBoxElement.DropDownWidth = 550;
            this.CmbToAccount.MultiColumnComboBoxElement.DropDownWidth = 550;
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.CmbFromAccount.AutoFilter = true;
                this.CmbFromAccount.ValueMember = "ID";
                this.CmbFromAccount.DisplayMember = "AccountName";

                ////

                this.CmbToAccount.AutoFilter = true;
                this.CmbToAccount.ValueMember = "ID";
                this.CmbToAccount.DisplayMember = "AccountName";
            });


            var q = AccountCommand.GetAll();
            var q1 = AccountCommand.GetAll();
            this.Invoke((MethodInvoker)delegate
            {
                CmbFromAccount.DataSource = q;
                FilterDescriptor filter = new FilterDescriptor();
                filter.PropertyName = this.CmbFromAccount.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                this.CmbFromAccount.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);

                ////
                CmbToAccount.DataSource = q1;
                FilterDescriptor filter1 = new FilterDescriptor();
                filter1.PropertyName = this.CmbToAccount.DisplayMember;
                filter1.Operator = FilterOperator.Contains;
                this.CmbToAccount.EditorControl.MasterTemplate.FilterDescriptors.Add(filter1);




            });
            Operation.EndOperation(this);

            th.Abort();

            lblAvailableAmount.Text = "";
            lblAvailableAmount.Text = AccountCommand.GetFreeBalance(int.Parse(CmbFromAccount.SelectedValue.ToString())).ToString();

        }
        private void FromPrivatewithdrawals_Load(object sender, EventArgs e)
        {
            th = new Thread(FillCmbo);
            th.Start();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

            if (CmbFromAccount.Text == CmbToAccount.Text)
            {
               _Alert .Warning ("لايجــوز الترحيـــل من نفس الحساب");
                return; 
            }

            if (Convert.ToDouble(txtAmount.Text.ToString()) > Convert.ToDouble(lblAvailableAmount.Text.ToString()))
            {
                _Alert .Error ("رصـــــــــيد غيـــر كافي");
                return;
            }

            // Start Save AT AccountDaily :
            AccountDaily tb = new AccountDaily()
            {
                AccountID = int .Parse ( CmbFromAccount .SelectedValue .ToString ()),
                DateOfProcess = DateTime.Now,
                TotalIn = 0f,
                TotalOut = Convert.ToDouble (txtAmount.Text),
                Description = txtDescription.Text.ToString()
            };
            AccountDailyCommand.NewAccountDaily (tb);


            AccountDaily xtb = new AccountDaily()
            {
                AccountID = int .Parse ( CmbToAccount .SelectedValue .ToString ()),
                DateOfProcess = DateTime.Now,
                TotalIn = Convert.ToDouble(txtAmount.Text),
                TotalOut = 0f,
                Description = txtDescription.Text.ToString()
            };
            AccountDailyCommand.NewAccountDaily (xtb);
            _Alert.Info("تـــــــم الحــــفظ بنجــــــــاح");

        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && txtAmount.Text.IndexOf(".") != -1)
            {

                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void CmbFromAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAvailableAmount.Text = "";
            lblAvailableAmount.Text = AccountCommand.GetFreeBalance(int.Parse(CmbFromAccount.SelectedValue.ToString())).ToString ();

        }
    }
}
