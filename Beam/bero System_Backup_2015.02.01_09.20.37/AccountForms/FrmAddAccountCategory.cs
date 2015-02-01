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
//================================
using DataLayer;
using DataLayer.XAccountant;

namespace bero_System.AccountForms
{
    public partial class FrmAddAccountCategory : RadForm
    {
        public FrmAddAccountCategory()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            AccountCategory tb = new AccountCategory() {
                 AccountCategoryName = accountCategoryNameTextBox .Text ,
                  Description = descriptionTextBox .Text 
                 
            };
            AccountCategoryCmd.NewAccountCategory(tb);

            Operation.EndOperation(this);
            Operation.ShowToustOk("تم الحفظ", this);
            accountCategoryNameTextBox.Text = "";
            descriptionTextBox.Text = "";
            accountCategoryNameTextBox.Focus();

        }
    }
}
