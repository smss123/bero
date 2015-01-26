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
using DataLayer;
using DataLayer.XProject;
namespace bero_System.ProjectExpenssesForms
{
    public partial class FrmAddProjectExpensses : RadForm
    {
        public FrmAddProjectExpensses()
        {
            InitializeComponent();
        }
        Thread th;
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

            //Fill project Level ComBo
            this.projectLevelComboBox.MultiColumnComboBoxElement.DropDownWidth = 550;
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.projectLevelComboBox.AutoFilter = true;
                this.projectLevelComboBox.ValueMember = "id";
                this.projectLevelComboBox.DisplayMember = "LevelName";
            });


            var q1 = ( from c in projectLevelCommand.GetAll() where c.ProjectProfileID == TargetProject .ID select c ) .ToList ();
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
        public ProjectProfile TargetProject { get; set; }
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
                projectLevelComboBox.BackColor = Color.White;
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
            Operation.BeginOperation (this);

            ProjectExpenss ExpTb = new ProjectExpenss() {
             ExpenssesID =int.Parse ( expenssesComboBox .SelectedValue .ToString ()),
             Amount = Convert.ToDouble (amountTextBox.Text) ,
             Description = descriptionTextBox .Text ,
              dateOfExpensses = DateProcessBox .Value ,
               ProjectLevelID =int .Parse ( projectLevelComboBox.SelectedValue .ToString ())
            };
            ProjectExpenssesCommand.NewProjectExpenss(ExpTb);
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

        private void FrmAddProjectExpensses_Load(object sender, EventArgs e)
        {
            th = new Thread(FillCombo);
            th.Start();
        }
    }
}
