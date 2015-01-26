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
using System.Threading;
using DataLayer;
using DataLayer.XEmployees;
namespace bero_System.EmployeeForms
{
    public partial class FrmEditHolyDay : RadForm
    {
        public FrmEditHolyDay()
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
        private void FrmEditHolyDay_Load(object sender, EventArgs e)
        {
            th = new Thread(FillEmployeeCombo);
            th.Start();


         
            fromDateDateTimePicker.Text =  TargetHolyday.fromDate.ToString () ;
            toDatetimeDateTimePicker .Text = TargetHolyday.ToDatetime.ToString ();
            commintTextBox.Text = TargetHolyday.commint;
            statusComboBox.Text = TargetHolyday.status;



        }

        public HolyDay  TargetHolyday { get; set; }
        private void Savebtn_Click(object sender, EventArgs e)
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

            Operation.BeginOperation(this);
             TargetHolyday.EmployeeID = int.Parse(EmployeeComboBox.SelectedValue.ToString());
             TargetHolyday.  fromDate = fromDateDateTimePicker.Value;
             TargetHolyday.   ToDatetime = toDatetimeDateTimePicker.Value;
             TargetHolyday.  commint = commintTextBox.Text;
             TargetHolyday.status = statusComboBox.Text;
         
            HolyDayCmd.EditHolyDay (TargetHolyday);


            foreach (Control item in radGroupBox1.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
            }

            Operation.EndOperation(this);
            Operation.ShowToustOk("تم الحفظ", this);


        }
    }
}
