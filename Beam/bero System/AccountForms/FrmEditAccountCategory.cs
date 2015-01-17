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

namespace bero_System.AccountForms
{
    public partial class FrmEditAccountCategory : RadForm
    {
        public FrmEditAccountCategory()
        {
            InitializeComponent();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (accountCategoryNameTextBox.Text == "")
            {

                accountCategoryNameTextBox.BackColor = Color.OrangeRed;

                accountCategoryNameTextBox.Focus();
                errorProvider1.SetError(this.accountCategoryNameTextBox, "من فضلك ادخل تصنيف الحساب");

                return;
            }
            else
            {
                accountCategoryNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }



            #endregion
        }
    }
}
