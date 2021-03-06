﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

using DataLayer;
using DataLayer.XEmployees;
using System.Threading;
using Telerik.WinControls;
namespace bero_System.EmployeeForms
{
    public partial class FrmManageEmployee : RadForm
    {
        public FrmManageEmployee()
        {
            InitializeComponent();
        }
        void populateGrd()
        {
            var Lst = EmployeesCmd.GetAllEmployees();
            this.Invoke((MethodInvoker)delegate { EmployeeGridView.DataSource = Lst; });
        }
        private void FrmManageEmployee_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(populateGrd);
            th.Start();
        }

        private void EmployeeGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = EmployeeGridView.CurrentColumn.Index;
            if (col == 9)
            {

                Operation.BeginOperation(this);
                FrmEditEmployee frm = new FrmEditEmployee();

                Employee  tb = (Employee)EmployeeGridView.CurrentRow.DataBoundItem;
                frm.TargetEmployee = tb;

                frm.ShowDialog();
                Operation.EndOperation(this);
            }
            if (col == 10)
            {

            Operation.BeginOperation(this);
            RadMessageBox.ThemeName = this.ThemeName;
               if( RadMessageBox.Show("هل تريد حذف الموظف؟","",MessageBoxButtons.YesNo,RadMessageIcon.Question)==System.Windows.Forms.DialogResult.Yes)
               {
                   try
                   {
                       EmployeesCmd.DeleteEmployee(int.Parse(EmployeeGridView.CurrentRow.Cells[0].Value.ToString()));
                       FrmManageEmployee_Load(sender, e);
                   }
                   catch (Exception ex)
                   {
                      // MessageBox.Show(ex.Message);
                       if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint "))
                       {
                           RadMessageBox.Show("لا يمكن حذف الموظف لانه مرتبط ببعض العمليات في النظام");
                       }
                   }
                   

                   
               }
               Operation.EndOperation(this);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            FrmAddEmployee frm = new FrmAddEmployee();
            frm.Show();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmManageEmployee_Load(null, null);
        }
    }
}
