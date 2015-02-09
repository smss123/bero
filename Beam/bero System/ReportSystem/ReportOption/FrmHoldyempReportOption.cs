using DataLayer.XEmployees;
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

namespace bero_System.ReportSystem.ReportOption
{
    public partial class FrmHoldyempReportOption : RadForm
    {
        public FrmHoldyempReportOption()
        {
            InitializeComponent();
        }
        Thread th;

        private void FillCombo()
        {

            //Fill project Level ComBo
            this.EmployeeComboBox.MultiColumnComboBoxElement.DropDownWidth = 1000;
            Operation.BeginOperation(this);

            this.Invoke((MethodInvoker)delegate
            {
                this.EmployeeComboBox.AutoFilter = true;
                this.EmployeeComboBox.ValueMember = "id";
                this.EmployeeComboBox.DisplayMember = "EmployeeName";
            });


            var q1 = EmployeesCmd.GetAllEmployees();//(from c in projectLevelCommand.GetAll() where c.ProjectProfileID == this.TargetProject.ID select c).ToList();
            this.Invoke((MethodInvoker)delegate
            {
                EmployeeComboBox.DataSource = q1;
                CompositeFilterDescriptor compositeFilter = new CompositeFilterDescriptor();
                FilterDescriptor LeveName = new FilterDescriptor("EmployeeName", FilterOperator.Contains, "");
                compositeFilter.FilterDescriptors.Add(LeveName);
                compositeFilter.LogicalOperator = FilterLogicalOperator.Or;
                this.EmployeeComboBox.EditorControl.FilterDescriptors.Add(compositeFilter);




            });

            Operation.EndOperation(this);
            th.Abort();
        }
        private void FrmHoldyempReportOption_Load(object sender, EventArgs e)
        {
            th = new Thread(FillCombo);
            th.Start();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
