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
    public partial class FrmEditProject : RadForm
    {
        public FrmEditProject()
        {
            InitializeComponent();
       }
        Thread th; 
        private void FillCombo()
        {
            //Fill Expensses ComBob
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
        public ProjectProfile  TargetProject { get; set; }
        private void SaveBtn_Click(object sender, EventArgs e)
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

           // Customer CurrentCustomer = ProjectProfileCommand.GetAccountNumberForCustomer(int.Parse(CustomerComboBox.SelectedValue.ToString()));
            int id = 0;
            int accountID = TargetProject.AccountID.Value  ;
            id = TargetProject.ID;

            TargetProject = new ProjectProfile();
                TargetProject.  ProjectName = projectNameTextBox.Text;
               TargetProject.  ProjectDescription = projectDescriptionTextBox.Text;
               TargetProject. createdDate = DateTime.Now;
              TargetProject.  DeliverDate = DeliverDateText.Value;
               TargetProject. ProjectFullAmount = Convert.ToDouble(projectFullAmountTextBox.Text);
               TargetProject.CustomerID = int.Parse(CustomerComboBox.SelectedValue.ToString());
               TargetProject.No_building = txtBuild.Text;
               TargetProject.No_permissibility = txtpermissibility.Text;
               TargetProject.ID = id;
               TargetProject.AccountID = accountID;
                // AccountID = 
         
            ProjectProfileCommand.EditProject (TargetProject);
            Operation.EndOperation(this);
            _Alert.Info("تـــــــم الحــــفظ بنجــــــــاح");

       
        }

        private void FrmEditProject_Load(object sender, EventArgs e)
        {
            CustomerComboBox.Enabled = true;
            // ^^^ Display Data In TextBoxes :
            projectNameTextBox.Text = TargetProject.ProjectName;
            projectDescriptionTextBox.Text = TargetProject.ProjectDescription;
            DeliverDateText.Text = TargetProject.DeliverDate.ToString ();
            projectFullAmountTextBox.Text = TargetProject.ProjectFullAmount.ToString ();

            //===============================
            th = new Thread(FillCombo);
            th.Start();
        }

        private void projectFullAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && projectFullAmountTextBox.Text.IndexOf(".") != -1)
            {

                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
    }
}
