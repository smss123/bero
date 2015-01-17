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
    public partial class FrmEditExpenssesMovment : RadForm
    {
        public FrmEditExpenssesMovment()
        {
            InitializeComponent();
        }
        Thread th;
        private void FillCombo()
        {
            //Fill Expensses ComBob
            this.expenssesComboBox.MultiColumnComboBoxElement.DropDownWidth = 550;
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.expenssesComboBox.AutoFilter = true;
                this.expenssesComboBox.ValueMember = "ID";
                this.expenssesComboBox.DisplayMember = "ExpenssesName";
            });


            var q = ExpenssesCommand.GetAll();
            this.Invoke((MethodInvoker)delegate
            {
                expenssesComboBox.DataSource = q;
                CompositeFilterDescriptor compositeFilter = new CompositeFilterDescriptor();
                FilterDescriptor ExpName = new FilterDescriptor("ExpenssesName", FilterOperator.Contains, "");
                compositeFilter.FilterDescriptors.Add(ExpName);
                compositeFilter.LogicalOperator = FilterLogicalOperator.Or;
                this.expenssesComboBox.EditorControl.FilterDescriptors.Add(compositeFilter);




            });
            Operation.EndOperation(this);

            th.Abort();
        }
        private void FrmEditExpenssesMovment_Load(object sender, EventArgs e)
        {
            th = new Thread(FillCombo);
            th.Start();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "



            if (expenssesComboBox.SelectedValue == null)
            {

                expenssesComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                expenssesComboBox.Focus();
                errorProvider1.SetError(this.expenssesComboBox, "من فضلك اختر نوع المصروف");
                return;
            }
            else
            {
                expenssesComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }

            if (amountTextBox.Text == "")
            {

                amountTextBox.BackColor = Color.OrangeRed;

                amountTextBox.Focus();
                errorProvider1.SetError(this.amountTextBox, "من فضلك ادخل التكلفة");

                return;
            }
            else
            {

                amountTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }




            #endregion
        }
    }
}
