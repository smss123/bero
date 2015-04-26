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
using DataLayer.XAccountant;
using DataLayer;
using System.Threading;
namespace bero_System.AccountForms
{
    public partial class FrmEditAccount : RadForm
    {
        public FrmEditAccount()
        {
            InitializeComponent();
        }

        Thread th;
        private void FillCombo()
        {
          
            this.CmbCategories.MultiColumnComboBoxElement.DropDownWidth = 550;
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.CmbCategories.AutoFilter = true;
                this.CmbCategories.ValueMember = "ID";
                this.CmbCategories.DisplayMember = "AccountCategoryName";
            });


            var q = AccountCategoryCmd.GetAll();
            this.Invoke((MethodInvoker)delegate
            {
                CmbCategories.DataSource = q;
                CompositeFilterDescriptor compositeFilter = new CompositeFilterDescriptor();
                FilterDescriptor ExpName = new FilterDescriptor("AccountCategoryName", FilterOperator.Contains, "");
                compositeFilter.FilterDescriptors.Add(ExpName);
                compositeFilter.LogicalOperator = FilterLogicalOperator.Or;
                this.CmbCategories.EditorControl.FilterDescriptors.Add(compositeFilter);




            });
            Operation.EndOperation(this);

            th.Abort();
        }
        public Account  TargetAccount { get; set; }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "



            if (CmbCategories.SelectedValue == null)
            {

                CmbCategories.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                CmbCategories.Focus();
                errorProvider1.SetError(this.CmbCategories, "من فضلك اختر تصنيف الحساب");
                return;
            }
            else
            {
                CmbCategories.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }

            if (txtAccountName.Text == "")
            {

                txtAccountName.BackColor = Color.OrangeRed;

                txtAccountName.Focus();
                errorProvider1.SetError(this.txtAccountName, "من فضلك ادخل اسم الحساب");

                return;
            }
            else
            {

                txtAccountName.BackColor = Color.White;
                errorProvider1.Clear();

            }




            #endregion

            Operation.BeginOperation(this);
            TargetAccount.Description = txtDescription.Text;
            TargetAccount.AccountName = txtAccountName.Text;
            TargetAccount.CategoryID = int .Parse ( CmbCategories.SelectedValue.ToString());
            AccountCommand.EditAccount(TargetAccount);
            Operation.EndOperation(this);
            _Alert.Info("تـــــــم الحــــفظ بنجــــــــاح");
            txtAccountName.Text = "";
            txtAccountName.Text = "";
            this.Hide();
        }

        private void FrmEditAccount_Load(object sender, EventArgs e)
        {
            txtAccountName.Text = TargetAccount.AccountName;
            txtDescription.Text = TargetAccount.Description;

            th = new Thread(FillCombo);
            th.Start();
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
