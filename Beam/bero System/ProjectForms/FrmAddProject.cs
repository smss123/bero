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
                  CustomerID = int.Parse (CustomerComboBox.SelectedValue .ToString ()),
                  AccountID = CurrentCustomer.AccountID ,

            };
            ProjectProfileCommand.NewProject(PrjTb);
            Operation.EndOperation(this);
            Operation.ShowToustOk("تـــم الحـــفظ بنجــــاح", this);
           
        }
        
        private void FrmAddProject_Load(object sender, EventArgs e)
        {
            th = new Thread(FillCombo);
            th.Start();
        }
    }
}
