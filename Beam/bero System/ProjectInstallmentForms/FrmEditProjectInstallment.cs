﻿using bero_System.ReportSystem.ReportCommand;
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

namespace bero_System.ProjectInstallmentForms
{
    public partial class FrmEditProjectInstallment : RadForm
    {
        public FrmEditProjectInstallment()
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

                projectLevelComboBox.SelectedValue = TargetInstalment.ProjectLevelID;


            });

            Operation.EndOperation(this);
            th.Abort();
        }
        private void FrmEditProjectInstallment_Load(object sender, EventArgs e)
        {
            //=============================================

            installments_nameTextBox.Text = TargetInstalment.Installments_name;
            projectLevelComboBox.Text = TargetInstalment.ProjectLevelID.ToString(); 
            amountTextBox.Text =   TargetInstalment.Amount.ToString () ;
            dateOfInstallmentsDateTimePicker.Text = TargetInstalment.DateOfInstallments.ToString();
            comboBox1.Text = TargetInstalment.ActiveStatus ;
            payByTextBox.Text = TargetInstalment.PayBy ;
            payDescriptionTextBox.Text = TargetInstalment.PayDescription ;
            projectLevelComboBox.SelectedValue = TargetInstalment.ProjectLevelID;

            //==============================================
             th = new Thread(FillCombo);
            th.Start();
        }
        public ProjectProfile TargetProject { get; set; }
        public ProjectInstallment TargetInstalment { get; set; }
        private void SaveBtn_Click(object sender, EventArgs e)
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

            int id = TargetInstalment.id;
            TargetInstalment = new ProjectInstallment();
            TargetInstalment.id = id;
            TargetInstalment.Installments_name = installments_nameTextBox.Text;
             TargetInstalment.ProjectLevelID = int .Parse (projectLevelComboBox.SelectedValue .ToString ());
             TargetInstalment.Amount = Convert.ToDouble(amountTextBox .Text );
              TargetInstalment.DateOfInstallments = dateOfInstallmentsDateTimePicker.Value ;
              TargetInstalment.ActiveStatus = comboBox1.Text;
               TargetInstalment.PayBy = payByTextBox .Text ;
               TargetInstalment.PayDescription = payDescriptionTextBox .Text ;
          
               ProjectInstallmentCommand.EditProjectInstallment (TargetInstalment);
            
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

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            dbDataContext db = new dbDataContext(Properties.Settings.Default.constr);
            if (TargetInstalment.projectLevel==null)
            {
                try
                {
                     TargetInstalment.projectLevel = db.projectLevels.Where(p => p.id == TargetInstalment.ProjectLevelID).SingleOrDefault();
                }
                catch (Exception ex)
                {

                    TargetInstalment.projectLevel = db.projectLevels.Where(p => p.id == TargetInstalment.ProjectLevelID).ToList()[0];
                }
            }
            var q = ProjectProfileCommand.GetAll().Where(p=>p.ID== TargetInstalment.projectLevel.ProjectProfile.ID && TargetInstalment.projectLevel!=null).SingleOrDefault();
            ProjectInstallmentCommandRpt.xCustomerName = q.Customer.CustomerName;
            ProjectInstallmentCommandRpt.xProject = q.ProjectName;

            ProjectInstallmentCommandRpt RepCmd = new ProjectInstallmentCommandRpt();
            RepCmd.PrintCurrentInstallment(TargetInstalment .id );
        }
      
    }
}
