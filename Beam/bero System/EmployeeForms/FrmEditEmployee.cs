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

namespace bero_System.EmployeeForms
{
    public partial class FrmEditEmployee : RadForm
    {
        public FrmEditEmployee()
        {
            InitializeComponent();
        }

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
        }
    }
}
