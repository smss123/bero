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
    public partial class FrmChangeUSerPassword : RadForm
    {
        public FrmChangeUSerPassword()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
          
            //==========================================================
            if (OldpwdTextBox.Text == "") { _Alert .Warning ("يجب أولا التحقق من كلمة المرور القديمة"); return; }
            if (NewPwdTextBox.Text == "") { _Alert.Warning(" يجب أدخال كلمة المرور الجدييدة أو أغلاق النافذة"); return; }
            if (OldpwdTextBox.Text != LoginInfomation.CurrnetUser.pwd) { _Alert.Error ("كلمة المرور خاصتك غير سليمة"); return; }
            //==========================================================
            // Start Change :
            Operation.BeginOperation(this);

            LoginInfomation.CurrnetUser.pwd = NewPwdTextBox.Text;
            UsersCmd.ChangePassword (LoginInfomation.CurrnetUser);
           
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

        private void FrmChangeUSerPassword_Load(object sender, EventArgs e)
        {
            userNameTextBox.Text = LoginInfomation.CurrnetUser.UserName;
            userNameTextBox.ReadOnly = true;
        }
    }
}
