using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Threading;
using DataLayer.XProject;
using DataLayer;
namespace bero_System.ProjectQuantityForms
{
    public partial class frmEditProjectQuantity : RadForm
    {
        public frmEditProjectQuantity()
        {
            InitializeComponent();
        }
       
        public  ProjectQuantity TargetProject { get; set; }
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
        private void frmEditProjectQuantity_Load(object sender, EventArgs e)
        {
            th = new Thread(FillCombo);
            th.Start();

            QtyText.Text = TargetProject.Qty.ToString();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);


            TargetProject. ItemID = int.Parse(CmbItems.SelectedValue.ToString());
            TargetProject .Qty = this.QtyText.Text;

            ProjectQuantityCommand.EditProjectQuantity(TargetProject);


            foreach (Control item in radGroupBox1.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
            }

            Operation.EndOperation(this);
            Operation.ShowToustOk("تم الحفظ", this);
            this.Hide();
        }
    }
}
