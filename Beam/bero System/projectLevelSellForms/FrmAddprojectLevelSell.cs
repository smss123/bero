using DataLayer;
using DataLayer.XAccountant;
using DataLayer.XProject;
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

namespace bero_System.projectLevelSellForms
{
    public partial class FrmAddprojectLevelSell : RadForm
    {
        public FrmAddprojectLevelSell()
        {
            InitializeComponent();
        }
        Thread th;
        private void FillCombo()
        {
            
            //Fill project Level ComBo
            this.projectLevelComboBox.MultiColumnComboBoxElement.DropDownWidth = 550;
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.projectLevelComboBox.AutoFilter = true;
                this.projectLevelComboBox.ValueMember = "id";
                this.projectLevelComboBox.DisplayMember = "LevelName";
            });


            var q1 = (from c in projectLevelCommand.GetAll() where c.ProjectProfileID == this.TargetProject.ID select c).ToList();
            this.Invoke((MethodInvoker)delegate
            {
                projectLevelComboBox.DataSource = q1;
                CompositeFilterDescriptor compositeFilter = new CompositeFilterDescriptor();
                FilterDescriptor LeveName = new FilterDescriptor("LevelName", FilterOperator.Contains, "");
                compositeFilter.FilterDescriptors.Add(LeveName);
                compositeFilter.LogicalOperator = FilterLogicalOperator.Or;
                this.projectLevelComboBox.EditorControl.FilterDescriptors.Add(compositeFilter);




            });

            Operation.EndOperation(this);
            th.Abort();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (sell_ItemTextBox.Text == "")
            {

                sell_ItemTextBox.BackColor = Color.OrangeRed;

                sell_ItemTextBox.Focus();
                errorProvider1.SetError(this.sell_ItemTextBox, "من فضلك ادخل اسم المستوى");

                return;
            }
            else
            {
                sell_ItemTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }

            if (amountTextBox.Text == "")
            {

                amountTextBox.BackColor = Color.OrangeRed;

                amountTextBox.Focus();
                errorProvider1.SetError(this.amountTextBox, "من فضلك ادخل الموزانة");

                return;
            }
            else
            {
                amountTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }
            if (projectLevelComboBox.SelectedValue == null)
            {

                projectLevelComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                projectLevelComboBox.Focus();
                errorProvider1.SetError(this.projectLevelComboBox, "من فضلك اختر المستوى");
                return;
            }
            else
            {
                projectLevelComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }


            #endregion
            Operation.BeginOperation(this);


            #region "   ^^^ Check Account Balance     "

            //int Acct = int.Parse(projectLevelComboBox.SelectedValue.ToString());
            //double balance = AccountDailyCommand.GetBalanceByAccountID(Acct);
            //if (Convert.ToDouble(amountTextBox.Text.ToString()) > balance)
            //{
            //    MessageBox.Show("رصيـــــد الحساب غير كافي");
            //    return;

            //}

            #endregion

            projectLevelSell seltb = new projectLevelSell()
            { 
             ProjectLevelID = int.Parse (projectLevelComboBox .SelectedValue .ToString ()),
             Sell_Item = sell_ItemTextBox.Text ,
             Amount = Convert.ToDouble ( amountTextBox .Text) ,
             DateOfSell = radDateTimePicker1 .Value ,
             Description = descriptionTextBox .Text ,
             Status = statusComboBox .Text , 
            };
            projectLevelSellCommand.NewprojectLevelSell(seltb);
            //==========================================================
            var LevelAccount = projectLevelCommand.GetByID(int.Parse(projectLevelComboBox.SelectedValue.ToString()));

            // Start Save AT AccountDaily :
            AccountDaily tb = new AccountDaily()
            {
                AccountID = LevelAccount .AccountID ,
                DateOfProcess = radDateTimePicker1.Value,
                TotalIn = 0f,
                TotalOut = Convert.ToDouble (amountTextBox .Text),
                Description = descriptionTextBox.Text 
            };
            AccountDailyCommand.NewAccountDaily (tb);

          //============================================================
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
        public ProjectProfile TargetProject { get; set; }
        private void FrmAddprojectLevelSell_Load(object sender, EventArgs e)
        {
            th = new Thread(FillCombo);
            th.Start();
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
