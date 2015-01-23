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
            this.Invoke((MethodInvoker)delegate
            {
                CmbFromAccount.DataSource = q;
                FilterDescriptor filter = new FilterDescriptor();
                filter.PropertyName = this.CmbFromAccount.DisplayMember;
                filter.Operator = FilterOperator.Contains;
                this.CmbFromAccount.EditorControl.MasterTemplate.FilterDescriptors.Add(filter);

                ////
                CmbToAccount.DataSource = q;
                FilterDescriptor filter1 = new FilterDescriptor();
                filter1.PropertyName = this.CmbToAccount.DisplayMember;
                filter1.Operator = FilterOperator.Contains;
                this.CmbToAccount.EditorControl.MasterTemplate.FilterDescriptors.Add(filter1);




            });
            Operation.EndOperation(this);

            th.Abort();
        }
        private void FromPrivatewithdrawals_Load(object sender, EventArgs e)
        {
            th = new Thread(FillCmbo);
            th.Start();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
