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
//================================
using System.Threading;
using DataLayer;
using DataLayer.XAccountant;
namespace bero_System.AccountForms
{
    public partial class FrmAddExpenssesMovment : RadForm
    {
        public FrmAddExpenssesMovment()
        {
            InitializeComponent();
        }
        Thread th;


        public int ExpenssId { get; set; }
        public Expenss TragetExpensses { get; set; }
              
        private void FrmAddExpenssesMovment_Load(object sender, EventArgs e)
        {
           
        }

        private void AddBtn_Click(object sender, EventArgs e)
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


            Operation.BeginOperation(this);
            ExpenssesMovment tb = new ExpenssesMovment
            {
                ExpenssesID = ExpenssId,
                Amount = double.Parse(amountTextBox.Text),
                DateOfProcess = DateTime.Now,
                Description = descriptionTextBox.Text,


            };

            if (ExpenssesMovmentCommand.NewExpenssesMovment(tb))
            {

                if (AccountDailyCommand.NewAccountDaily(new AccountDaily()
                {
                    AccountID = TragetExpensses.AccountID,
                    DateOfProcess = DateTime.Now,
                    Description = "عبارة عن مبلغ مسحوب لصالح المصروفات ",
                    TotalOut = Convert .ToDouble ( amountTextBox.Text),
                    TotalIn = 0f,
                    CommandArg = "",


                }))
                {
                    _Alert.Info("تـــــــم الحــــفظ بنجــــــــاح");
                    foreach (Control item in radGroupBox1.Controls)
                    {
                        if (item is TextBox)
                        {
                            ((TextBox)item).Clear();
                        }
                        amountTextBox.Focus();
                        Operation.EndOperation(this);
                    }
                }

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
