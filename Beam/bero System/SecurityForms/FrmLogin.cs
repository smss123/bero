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

namespace bero_System.SecurityForms
{
    public partial class FrmLogin : RadForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (userNameTextBox.Text == "")
            {

                userNameTextBox.BackColor = Color.OrangeRed;

                userNameTextBox.Focus();
                errorProvider1.SetError(this.userNameTextBox, "من فضلك ادخل اسم المستخدم");

                return;
            }
            else
            {
                userNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }

            if (pwdTextBox.Text == "")
            {

                pwdTextBox.BackColor = Color.OrangeRed;

                pwdTextBox.Focus();
                errorProvider1.SetError(this.pwdTextBox, "من فضلك ادخل كلمة المرور");

                return;
            }
            else
            {
                pwdTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }

            #endregion
        }
    }
}
