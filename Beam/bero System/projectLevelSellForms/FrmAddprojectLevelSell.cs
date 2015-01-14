using DataLayer.XProject;
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

namespace bero_System.projectLevelSellForms
{
    public partial class FrmAddprojectLevelSell : RadForm
    {
        public FrmAddprojectLevelSell()
        {
            InitializeComponent();
        }
        Thread th;
        private void FillCombo()
        {
            
            //Fill project Level ComBo
            this.projectLevelComboBox.MultiColumnComboBoxElement.DropDownWidth = 550;
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.projectLevelComboBox.AutoFilter = true;
                this.projectLevelComboBox.ValueMember = "id";
                this.projectLevelComboBox.DisplayMember = "LevelName";
            });


            var q1 = projectLevelCommand.GetAll();
            this.Invoke((MethodInvoker)delegate
            {
                projectLevelComboBox.DataSource = q1;
                CompositeFilterDescriptor compositeFilter = new CompositeFilterDescriptor();
                FilterDescriptor LeveName = new FilterDescriptor("LevelName", FilterOperator.Contains, "");
                compositeFilter.FilterDescriptors.Add(LeveName);
                compositeFilter.LogicalOperator = FilterLogicalOperator.Or;
                this.projectLevelComboBox.EditorControl.FilterDescriptors.Add(compositeFilter);




            });

            Operation.EndOperation(this);
            th.Abort();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (sell_ItemTextBox.Text == "")
            {

                sell_ItemTextBox.BackColor = Color.OrangeRed;

                sell_ItemTextBox.Focus();
                errorProvider1.SetError(this.sell_ItemTextBox, "من فضلك ادخل اسم المستوى");

                return;
            }
            else
            {
                sell_ItemTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }

            if (amountTextBox.Text == "")
            {

                amountTextBox.BackColor = Color.OrangeRed;

                amountTextBox.Focus();
                errorProvider1.SetError(this.amountTextBox, "من فضلك ادخل الموزانة");

                return;
            }
            else
            {
                amountTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }
            if (projectLevelComboBox.SelectedValue == null)
            {

                projectLevelComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                projectLevelComboBox.Focus();
                errorProvider1.SetError(this.projectLevelComboBox, "من فضلك اختر المستوى");
                return;
            }
            else
            {
                projectLevelComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }


            #endregion
        }

        private void FrmAddprojectLevelSell_Load(object sender, EventArgs e)
        {
            th = new Thread(FillCombo);
            th.Start();
        }
    }
}
