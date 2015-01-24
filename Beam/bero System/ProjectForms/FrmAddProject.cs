using DataLayer.XCustomer;
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
using System.Windows.Forms;
using System.Drawing;
using DataLayer;
using DataLayer.XProject;
using bero_System.ProjectForms;

namespace bero_System.ProjectForms
{
    public partial class FrmAddProject : RadForm
    {
        public FrmAddProject()
        {
            InitializeComponent();
          
        }
        Thread th;
        #region "^^^ Fill CUstomersCmb"
        private void FillCombo()
        {
            
            this.CustomerComboBox.MultiColumnComboBoxElement.DropDownWidth = 550;
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.CustomerComboBox.AutoFilter = true;
                this.CustomerComboBox.ValueMember = "ID";
                this.CustomerComboBox.DisplayMember = "CustomerName";
            });


            var q = CustomerCommand.GetAll();
            this.Invoke((MethodInvoker)delegate
            {
                CustomerComboBox.DataSource = q;
                CompositeFilterDescriptor compositeFilter = new CompositeFilterDescriptor();
                FilterDescriptor CusName = new FilterDescriptor("CustomerName", FilterOperator.Contains, "");
                FilterDescriptor CusPhone = new FilterDescriptor("PhoneNumber", FilterOperator.Contains, "");

                compositeFilter.FilterDescriptors.Add(CusName);
                compositeFilter.FilterDescriptors.Add(CusPhone);

                compositeFilter.LogicalOperator = FilterLogicalOperator.Or;
                this.CustomerComboBox.EditorControl.FilterDescriptors.Add(compositeFilter);




            });
            Operation.EndOperation(this);

          
            th.Abort();
        }
        #endregion

      
        int PrjID = 0;
        private void AddBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (projectNameTextBox.Text == "")
            {

                projectNameTextBox.BackColor = Color.OrangeRed;

                projectNameTextBox.Focus();
                errorProvider1.SetError(this.projectNameTextBox, "من فضلك ادخل اسم المشروع");

                return;
            }

            else
            {
                projectNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();
                
            }

            if (projectFullAmountTextBox.Text == "")
            {

                projectFullAmountTextBox.BackColor = Color.OrangeRed;

                projectFullAmountTextBox.Focus();
                errorProvider1.SetError(this.projectFullAmountTextBox, "من فضلك ادخل الموزانة");

                return;
            }
            else
            {
                projectFullAmountTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }

            if (CustomerComboBox.SelectedValue == null)
            {

                CustomerComboBox.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                CustomerComboBox.Focus();
                errorProvider1.SetError(this.CustomerComboBox, "من فضلك قم باختيار العميل");
                return;
            }
            else
            {
                CustomerComboBox.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }

            #endregion
            Operation.BeginOperation(this);


            Customer CurrentCustomer = ProjectProfileCommand.GetAccountNumberForCustomer(int .Parse (CustomerComboBox.SelectedValue .ToString ()));

            ProjectProfile PrjTb = new ProjectProfile() {
                  ProjectName = projectNameTextBox .Text ,
                  ProjectDescription = projectDescriptionTextBox.Text ,
                  createdDate = DateTime .Now ,
                  DeliverDate =  DeliverDateText .Value ,
                  ProjectFullAmount =   Convert.ToDouble ( projectFullAmountTextBox .Text) ,
                  CustomerID = int.Parse (CustomerComboBox.SelectedValue .ToString ())  
                 
            };
            ProjectProfileCommand.NewProject(PrjTb);
            //===================================================================
          
           
             var CurrentProject = ProjectProfileCommand.GetByProjId(PrjTb.ID);
             PrjID = CurrentProject.ID;
            //====================================================================
            // بعد الاتفاق على سعر المشروع
            // يصبح الزبون مدين للمشروع بكامل المبلغ لانه لم يدفع حتى الان

            // ^^^ [حساب العميل \ مدين]
            AccountDaily actTb2 = new AccountDaily()
            {
                AccountID = CurrentCustomer.AccountID,
                TotalIn = Convert.ToDouble(projectFullAmountTextBox.Text),
                TotalOut = 0f,
                DateOfProcess = DateTime.Now,
                Description = string.Format("inCame in of the customer's {0} account and the amount of {1}", CurrentCustomer.CustomerName, projectFullAmountTextBox.Text),
                CommandArg = ""
            };
            DataLayer.XAccountant.AccountDailyCommand.NewAccountDaily(actTb2);


            ProjectProfile GetProject = ProjectProfileCommand.GetByProjId(PrjID);
            // ^^^ [حساب المشروع \ دائن]
            AccountDaily actTb1 = new AccountDaily()
            {
                AccountID = GetProject.AccountID,
                TotalIn = 0f,
                TotalOut = Convert.ToDouble(projectFullAmountTextBox.Text),
                DateOfProcess = DateTime.Now,
                Description = string.Format("come out the project : {0} account an amount of :  {1}", GetProject.ProjectName, projectFullAmountTextBox.Text),
                CommandArg = ""
            };
            DataLayer.XAccountant.AccountDailyCommand.NewAccountDaily(actTb1);

          
            //========================================================================================================
            Operation.EndOperation(this);
            Operation.ShowToustOk("تـــم الحـــفظ بنجــــاح", this);
           
        }
        
        private void FrmAddProject_Load(object sender, EventArgs e)
        {
            th = new Thread(FillCombo);
            th.Start();
        }
   
        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
       
    }
}
