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
//================================
using DataLayer;
using DataLayer.XAccountant;
namespace bero_System.AccountForms
{
    public partial class FrmAddAccount : RadForm
    {
        public FrmAddAccount()
        {
            InitializeComponent();
        }

        Thread th;
        private void FillCombo()
        {
            //Fill Expensses ComBob
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
        private void FrmAddAccount_Load(object sender, EventArgs e)
        {
            th = new Thread(FillCombo);
            th.Start();

        }

        private void AddBtn_Click(object sender, EventArgs e)
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

            Account tb = new Account() { 
             CategoryID  = int .Parse( CmbCategories .SelectedValue .ToString ()),
             AccountName = txtAccountName .Text ,
             Description = txtDescription .Text 
            };
            AccountCommand.NewAccount(tb);

            Operation.EndOperation(this);

            _Alert.Info("تـــــــم الحــــفظ بنجــــــــاح");

            txtDescription .Text = "";
            txtAccountName .Text = "";
            txtAccountName.Focus();
        }
    }
}
