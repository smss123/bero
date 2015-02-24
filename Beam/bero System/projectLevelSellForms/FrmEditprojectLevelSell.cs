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
    public partial class FrmEditprojectLevelSell : RadForm
    {
        public FrmEditprojectLevelSell()
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


            var q1 = projectLevelCommand.GetAll();
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
        private void SaveBtn_Click(object sender, EventArgs e)
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

            #region "   ^^^ Check Account Balance     "

            int Acct = int.Parse(projectLevelComboBox.SelectedValue.ToString());
            double balance = AccountDailyCommand.GetBalanceByAccountID(Acct);
            if (Convert.ToDouble(amountTextBox.Text.ToString()) > balance)
            {
                MessageBox.Show("رصيـــــد الحساب غير كافي");
                return;
            }

            #endregion
               TargetSelTable. ProjectLevelID = int.Parse(projectLevelComboBox.SelectedValue.ToString());
               TargetSelTable. Sell_Item = sell_ItemTextBox.Text;
               TargetSelTable. Amount = Convert.ToDouble(amountTextBox.Text);
               TargetSelTable. DateOfSell = DateTime.Now;

               TargetSelTable. Description = descriptionTextBox.Text;

               TargetSelTable.Status = statusComboBox.Text;
          
            projectLevelSellCommand.EditprojectLevelSell (TargetSelTable);


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
        public projectLevelSell TargetSelTable { get; set; }
        private void FrmEditprojectLevelSell_Load(object sender, EventArgs e)
        {
          sell_ItemTextBox.Text = TargetSelTable.Sell_Item;

          amountTextBox.Text = TargetSelTable.Amount.ToString(); 

          radDateTimePicker1 .Text =   TargetSelTable.DateOfSell .ToString ();

          descriptionTextBox.Text = TargetSelTable.Description;

          statusComboBox.Text =   TargetSelTable.Status ;
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
