using DataLayer;
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

using DataLayer;
using DataLayer.XProject;
using DataLayer.XAccountant;
namespace bero_System.ProjectInstallmentForms
{
    public partial class FrmAddProjectInstallment : RadForm
    {
        public FrmAddProjectInstallment()
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


            var q1 = projectLevelCommand.GetByProjectProfileID(TargetProject.ID);
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
        private void FrmAddProjectInstallment_Load(object sender, EventArgs e)
        {
            th = new Thread(FillCombo);
            th.Start();
        }

        public ProjectProfile TargetProject { get; set; }
     
        private void AddBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (installments_nameTextBox.Text == "")
            {

                installments_nameTextBox.BackColor = Color.OrangeRed;

                installments_nameTextBox.Focus();
                errorProvider1.SetError(this.installments_nameTextBox, "من فضلك ادخل الاسم");

                return;
            }

            else
            {
                installments_nameTextBox.BackColor = Color.White;
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

            if (projectLevelComboBox.SelectedValue == null)
            {

                projectLevelComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                projectLevelComboBox.Focus();
                errorProvider1.SetError(this.projectLevelComboBox, "من فضلك قم باختيار المستوى");
                return;
            }
            else
            {
                projectLevelComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }

            #endregion

            Operation.BeginOperation(this);
            ProjectInstallment InstalmentTb = new ProjectInstallment()
            {
                Installments_name = installments_nameTextBox .Text ,
                ProjectLevelID = int .Parse (projectLevelComboBox.SelectedValue .ToString ()),
                Amount = Convert.ToDouble(amountTextBox .Text ),
                DateOfInstallments = dateOfInstallmentsDateTimePicker.Value ,
                ActiveStatus  = CmbActiveStatus.Text,
                PayBy = payByTextBox .Text ,
                PayDescription = payDescriptionTextBox .Text ,


            };
            ProjectInstallmentCommand.NewProjectInstallment(InstalmentTb);
            //==================================================================
            Customer CurrentCustomer = ProjectProfileCommand.GetAccountNumberForCustomer(int .Parse (CustomerComboBox.SelectedValue .ToString ()));

            // Start Save AT AccountDaily :
            // ^^^  خرج من حساب المشروع __ دائن
            AccountDaily tb = new AccountDaily()
            {
                AccountID = TargetProject .AccountID ,
                DateOfProcess = DateTime.Now,
                TotalIn = 0f,
                TotalOut = Convert.ToDouble(amountTextBox.Text),
                Description = payDescriptionTextBox .Text
            };
            AccountDailyCommand.NewAccountDaily (tb);
            
            // ^^^ دخل في حساب العميل  ___مدين)
            AccountDaily xtb = new AccountDaily()
            {
                AccountID =  CurrentCustomer.AccountID ,
                DateOfProcess = DateTime.Now,
                TotalIn = Convert.ToDouble(amountTextBox.Text),
                TotalOut = 0f,
                Description = payDescriptionTextBox .Text
            };
            AccountDailyCommand.NewAccountDaily(xtb);
            //===================================================================
            foreach (Control item in radGroupBox1.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
            }

            Operation.EndOperation(this);
            Operation.ShowToustOk("تم الحفظ", this);






        }
    }
}
