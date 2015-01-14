using DataLayer.XBulidItem;
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

namespace bero_System.ProjectQuantityForms
{
    public partial class frmAddProjectQuantity : RadForm
    {
        public frmAddProjectQuantity()
        {
            InitializeComponent();
        }
        Thread th;
        private void FillCombo()
        {

            //Fill project Level ComBo
            this.ItemComboBox.MultiColumnComboBoxElement.DropDownWidth = 550;
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.ItemComboBox.AutoFilter = true;
                this.ItemComboBox.ValueMember = "id";
                this.ItemComboBox.DisplayMember = "LevelName";
            });


            var q1 = BulidItemCommand.GetAll();
            this.Invoke((MethodInvoker)delegate
            {
                ItemComboBox.DataSource = q1;
                CompositeFilterDescriptor compositeFilter = new CompositeFilterDescriptor();
                FilterDescriptor LeveName = new FilterDescriptor("LevelName", FilterOperator.Contains, "");
                compositeFilter.FilterDescriptors.Add(LeveName);
                compositeFilter.LogicalOperator = FilterLogicalOperator.Or;
                this.ItemComboBox.EditorControl.FilterDescriptors.Add(compositeFilter);




            });

            Operation.EndOperation(this);
            th.Abort();
        }
        private void frmAddProjectQuantity_Load(object sender, EventArgs e)
        {
            th = new Thread(FillCombo);
            th.Start();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (ItemComboBox.SelectedValue == null)
            {

                ItemComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                ItemComboBox.Focus();
                errorProvider1.SetError(this.ItemComboBox, "من فضلك اختر الصنف");
                return;
            }
            else
            {
                ItemComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }


            if (qtyTextBox.Text == "")
            {

                qtyTextBox.BackColor = Color.OrangeRed;

                qtyTextBox.Focus();
                errorProvider1.SetError(this.qtyTextBox, "من فضلك ادخل الكمية");

                return;
            }
            else
            {
                qtyTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }
           

            #endregion
        }
    }
}
