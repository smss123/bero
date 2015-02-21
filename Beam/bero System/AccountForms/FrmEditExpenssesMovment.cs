using DataLayer.XAccountant;
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
using DataLayer.XAccountant;
using Telerik.WinControls;
namespace bero_System.AccountForms
{
    public partial class FrmEditExpenssesMovment : RadForm
    {
        public FrmEditExpenssesMovment()
        {
            InitializeComponent();
        }
        public ExpenssesMovment TrExpMovment { get; set; }
     
        private void FrmEditExpenssesMovment_Load(object sender, EventArgs e)
        {
            ExpensessNameTextBox.Text = TrExpMovment.Expenss.ExpenssesName;
            amountTextBox.Text = TrExpMovment.Amount.ToString();
            descriptionTextBox.Text = TrExpMovment.Description;

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "



          

            if (amountTextBox.Text == "")
            {

                amountTextBox.BackColor = Color.OrangeRed;

                amountTextBox.Focus();
                errorProvider1.SetError(this.amountTextBox, "من فضلك ادخل التكلفة");

                return;
            }
            else
            {

                amountTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }




            #endregion

            if (RadMessageBox.Show(this, "هل تريد حفظ التعديلات", "حفظ التعديلات", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
            {
                Operation.BeginOperation(this);
                TrExpMovment.Amount = double.Parse(amountTextBox.Text);
                TrExpMovment.Description = descriptionTextBox.Text;
                if (ExpenssesMovmentCommand.EditExpenssesMovment(TrExpMovment))
                {
                    if(AccountDailyCommand.NewAccountDaily(new AccountDaily()
                {
                    AccountID = TrExpMovment.Expenss.AccountID,
                    DateOfProcess = DateTime.Now,
                    Description = "تعديل قيد لصالح المصروفات ",
                    TotalOut = 0f,
                    TotalIn = Convert.ToDouble(amountTextBox.Text),
                    CommandArg = "",


                }))
                    {

                    }
                }
                Operation.BeginOperation(this);

                RadMessageBox.Show("تمت عملية التعديل", "نجاح العملية", MessageBoxButtons.OK, RadMessageIcon.Info);
                this.Close();
            }

        }

        private void amountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && amountTextBox.Text.IndexOf(".") != -1)
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
