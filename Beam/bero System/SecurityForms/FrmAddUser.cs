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
using DataLayer.Security;
namespace bero_System.SecurityForms
{
    public partial class FrmAddUser : RadForm
    {
        public FrmAddUser()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
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
            try
            {

                Operation.BeginOperation(this);

                 SystemUser Usr = UsersCmd.GetByName(userNameTextBox.Text);

                 _Alert.Warning("موجــــود مســــــــبقا");
              
                 foreach (Control item in radGroupBox1.Controls)
                 {
                     if (item is TextBox)
                     {
                         ((TextBox)item).Clear();
                     }
                 }

                 Operation.EndOperation(this);
                 return;
            }
            catch (Exception)
            {

                Operation.BeginOperation(this);
                //=================================================
                SystemUser UsrTb = new SystemUser() { UserName = userNameTextBox.Text, pwd = pwdTextBox.Text }; UsersCmd.NewUser(UsrTb);
                //=================================================
                foreach (Control item in radGroupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Clear();
                    }
                }

                Operation.EndOperation(this);
                _Alert.Info("تـــــــم الحــــفظ بنجــــــــاح");
            }

      }
    }
}
