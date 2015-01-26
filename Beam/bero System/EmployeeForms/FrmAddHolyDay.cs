using DataLayer.XEmployees;
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

namespace bero_System.EmployeeForms
{
    public partial class FrmAddHolyDay : RadForm
    {

        public FrmAddHolyDay()
        {
            InitializeComponent();
        }
        Thread th;
        private void FillEmployeeCombo()
        {


            this.Invoke((MethodInvoker)delegate
            {
                this.EmployeeComboBox.MultiColumnComboBoxElement.DropDownWidth = 1000;

                this.EmployeeComboBox.AutoFilter = true;
                this.EmployeeComboBox.ValueMember = "id";
                this.EmployeeComboBox.DisplayMember = "EmployeeName";
            });
            Operation.BeginOperation(this);
            var q = EmployeesCmd.GetAllEmployees();
            Operation.EndOperation(this);
            this.Invoke((MethodInvoker)delegate
            {
                EmployeeComboBox.DataSource = q;
                this.EmployeeComboBox.AutoFilter = true;
                CompositeFilterDescriptor compositeFilter = new CompositeFilterDescriptor();
                FilterDescriptor empname = new FilterDescriptor("EmployeeName", FilterOperator.Contains, "");
              
                compositeFilter.FilterDescriptors.Add(empname);
              
                compositeFilter.LogicalOperator = FilterLogicalOperator.Or;

                this.EmployeeComboBox.EditorControl.FilterDescriptors.Add(compositeFilter);
                ///
            
            });
            //fillText



            th.Abort();



        }

        private void FrmAddHolyDay_Load(object sender, EventArgs e)
        {
            th = new Thread(FillEmployeeCombo);
            th.Start();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "



            if (EmployeeComboBox.SelectedValue == null)
            {

                EmployeeComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                EmployeeComboBox.Focus();
                errorProvider1.SetError(this.EmployeeComboBox, "من فضلك قم باختيار الموظف");
                return;
            }
            else
            {
                EmployeeComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }

            #endregion
        }
    }
}
