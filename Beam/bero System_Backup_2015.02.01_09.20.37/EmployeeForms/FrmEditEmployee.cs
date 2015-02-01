using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using DataLayer;
using DataLayer.XEmployees;
namespace bero_System.EmployeeForms
{
    public partial class FrmEditEmployee : RadForm
    {
        public FrmEditEmployee()
        {
            InitializeComponent();
        }

        public Employee  TargetEmployee { get; set; }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "




            if (employeeNameTextBox.Text == "")
            {

                employeeNameTextBox.BackColor = Color.OrangeRed;

                employeeNameTextBox.Focus();
                errorProvider1.SetError(this.employeeNameTextBox, "من فضلك ادخل اسم الموظف");

                return;
            }
            else
            {

                employeeNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }




            #endregion


            Operation.BeginOperation(this);

        
               TargetEmployee. EmployeeName = employeeNameTextBox.Text;
                TargetEmployee. nationalty = nationaltyComboBox.Text;
                TargetEmployee. PassportNumber = passportNumberTextBox.Text;
                TargetEmployee. PassportExpierdDate = passportExpierdDateDateTimePicker.Value;
                TargetEmployee. peronaltyNumber = peronaltyNumberTextBox.Text;
               TargetEmployee.  personaltyExpiredDate = personaltyExpiredDateDateTimePicker.Value;
                TargetEmployee. Salary = Convert.ToDouble(salaryTextBox.Text);
                TargetEmployee.Status = statusComboBox.Text;

                EmployeesCmd.EditEmployee(TargetEmployee);


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

        private void FrmEditEmployee_Load(object sender, EventArgs e)
        {
            employeeNameTextBox.Text=  TargetEmployee.EmployeeName ;
            nationaltyComboBox.Text=  TargetEmployee.nationalty ;
            passportNumberTextBox.Text= TargetEmployee.PassportNumber ;
            passportExpierdDateDateTimePicker.Value=  TargetEmployee.PassportExpierdDate.Value ;
            peronaltyNumberTextBox.Text= TargetEmployee.peronaltyNumber;
            personaltyExpiredDateDateTimePicker.Value=TargetEmployee.personaltyExpiredDate.Value ;
            salaryTextBox.Text = TargetEmployee.Salary.ToString();
           statusComboBox.Text = TargetEmployee.Status ;
        }
    }
}
