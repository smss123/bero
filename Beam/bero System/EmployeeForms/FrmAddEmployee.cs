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
    public partial class FrmAddEmployee : RadForm
    {
        public FrmAddEmployee()
        {
            InitializeComponent();
        }

        private void salaryLabel_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
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

            try
            {
                Employee EmpTb = EmployeesCmd.GetByName(employeeNameTextBox.Text);
                MessageBox.Show("مسجل مســـبقا");
                Operation.EndOperation(this);
                foreach (Control item in radGroupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Clear();
                    }
                }
                employeeNameTextBox.Focus();

                return;
            }
            catch (Exception)
            {
                
           Employee tb = new Employee()
            {
                 EmployeeName = employeeNameTextBox.Text ,
                 nationalty = nationaltyComboBox.Text ,
                 PassportNumber = passportNumberTextBox.Text ,
                 PassportExpierdDate = passportExpierdDateDateTimePicker.Value ,
                 peronaltyNumber = peronaltyNumberTextBox.Text ,
                 personaltyExpiredDate = personaltyExpiredDateDateTimePicker.Value ,
                 Salary =Convert.ToDouble ( salaryTextBox.Text) ,
                 Status = statusComboBox.Text 
            };
            EmployeesCmd.NewEmployee(tb);


            foreach (Control item in radGroupBox1.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
            }
            employeeNameTextBox.Focus();
            Operation.EndOperation(this);
            Operation.ShowToustOk("تم الحفظ", this);
            }
            Operation.EndOperation(this);


        }

        private void FrmAddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void passportNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void peronaltyNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void salaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && salaryTextBox.Text.IndexOf(".") != -1)
            {

                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
