using DataLayer.XBulidItem;
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

using DataLayer.XProject;
using DataLayer;
namespace bero_System.ProjectQuantityForms
{
    public partial class frmAddProjectQuantity : RadForm
    {
        public frmAddProjectQuantity()
        {
            InitializeComponent();
        }
        Thread th;
        private void FillCombo()
        {

            //Fill project Level ComBo
            this.CmbItems.MultiColumnComboBoxElement.DropDownWidth = 550;
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.CmbItems.AutoFilter = true;
                this.CmbItems.ValueMember = "ID";
                this.CmbItems.DisplayMember = "ItemName";
            });


            var q1 = BulidItemCommand.GetAll();
            this.Invoke((MethodInvoker)delegate
            {
                CmbItems.DataSource = q1;
                CompositeFilterDescriptor compositeFilter = new CompositeFilterDescriptor();
                FilterDescriptor LeveName = new FilterDescriptor("ItemName", FilterOperator.Contains, "");
                compositeFilter.FilterDescriptors.Add(LeveName);
                compositeFilter.LogicalOperator = FilterLogicalOperator.Or;
                this.CmbItems.EditorControl.FilterDescriptors.Add(compositeFilter);




            });

            Operation.EndOperation(this);
            th.Abort();
        }
        private void frmAddProjectQuantity_Load(object sender, EventArgs e)
        {
            th = new Thread(FillCombo);
            th.Start();
        }
        public ProjectProfile TargetProject { get; set; }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (CmbItems.SelectedValue == null)
            {

                CmbItems.MultiColumnComboBoxElement.BackColor = Color.OrangeRed;
                CmbItems.Focus();
                errorProvider1.SetError(this.CmbItems, "من فضلك اختر الصنف");
                return;
            }
            else
            {
                CmbItems.MultiColumnComboBoxElement.BackColor = Color.White;
                errorProvider1.Clear();
            }


            if (QtyText.Text == "")
            {

                QtyText.BackColor = Color.OrangeRed;

                QtyText.Focus();
                errorProvider1.SetError(this.QtyText, "من فضلك ادخل الكمية");

                return;
            }
            else
            {
                QtyText.BackColor = Color.White;
                errorProvider1.Clear();

            }
           

            #endregion

            Operation.BeginOperation(this);

            ProjectQuantity Qtb = new ProjectQuantity() {
             ItemID =int .Parse ( CmbItems .SelectedValue .ToString ()),
             ProjectProfileID = this .TargetProject .ID ,
             Qty = this .QtyText .Text 
            };
            ProjectQuantityCommand.NewProjectQuantity(Qtb);

     
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

        private void QtyText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
