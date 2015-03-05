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
using bero_System.MainScenarioForms;
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


            Operation.BeginOperation(this);
            var q =  LoginInfomation .Login (userNameTextBox .Text ,pwdTextBox.Text);
            if (q != null)
            {
                timer1.Enabled = false;
                LoginInfomation.CurrnetUser = q;
                this.Text = LoginInfomation.CurrnetUser .UserName ;
                MainForms frm = new MainForms();
                frm.Show();
                this.Hide();
                Operation.EndOperation(this);

            }
            else
            {
                Operation.EndOperation(this);
                _Alert .Error (" كـــلمة المـــــــرور خــــــاطئة");
                userNameTextBox.Text = "";
                pwdTextBox.Text = "";
                userNameTextBox.Focus();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lblTimeLogIn.Text = "";
            userNameTextBox.Text = "";
            pwdTextBox.Text = "";
        }

        int TimeLogIn = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLogIn -= 1;
            lblTimeLogIn.Text = TimeLogIn.ToString();
            if (TimeLogIn == 0)
            {
                timer1.Enabled = false;
                Application.Exit();
            }
        }
    }
}
