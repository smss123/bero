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
        public Expenss TragetExpenss { get; set; }

        private void FillCombo()
        {
            //Fill Expensses ComBob
            this.expenssesComboBox.MultiColumnComboBoxElement.DropDownWidth = 550;
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.expenssesComboBox.AutoFilter = true;
                this.expenssesComboBox.ValueMember = "ID";
                this.expenssesComboBox.DisplayMember = "ExpenssesName";
            });


            var q = ExpenssesCommand.GetAll();
            this.Invoke((MethodInvoker)delegate
            {
                expenssesComboBox.DataSource = q;
                CompositeFilterDescriptor compositeFilter = new CompositeFilterDescriptor();
                FilterDescriptor ExpName = new FilterDescriptor("ExpenssesName", FilterOperator.Contains, "");
                compositeFilter.FilterDescriptors.Add(ExpName);
                compositeFilter.LogicalOperator = FilterLogicalOperator.Or;
                this.expenssesComboBox.EditorControl.FilterDescriptors.Add(compositeFilter);




            });
            Operation.EndOperation(this);

            th.Abort();
        }
        private void FrmAddExpenssesMovment_Load(object sender, EventArgs e)
        {
            th = new Thread(FillCombo);
            th.Start();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "



            if (expenssesComboBox.SelectedValue == null)
            {

                expenssesComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                expenssesComboBox.Focus();
                errorProvider1.SetError(this.expenssesComboBox, "من فضلك اختر نوع المصروف");
                return;
            }
            else
            {
                expenssesComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }

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
                    AccountID = int .Parse (expenssesComboBox.SelectedValue.ToString()),
                    DateOfProcess = DateTime.Now,
                    Description = "عبارة عن مبلغ مسحوب لصالح المصروفات ",
                    TotalOut = Convert .ToDouble ( amountTextBox.Text),
                    TotalIn = 0f,
                    CommandArg = "",


                }))
                {
                    Operation.ShowToustOk("Expenss Has Been Saved", this);
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
