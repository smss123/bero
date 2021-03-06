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
using System.Threading;
using DataLayer.XCustomer;
using DataLayer.XProject;
using bero_System.ReportSystem.ReportCommand;
namespace bero_System.MainScenarioForms
{
    public partial class FrmMainProjectsCustomer : RadForm
    {
        public FrmMainProjectsCustomer()
        {
            InitializeComponent();
        }
        public Customer TargetCustomer { get; set; }
        public ProjectProfile  xproject  { get; set; }

        void GetAllProjectForCurrentCustomer()
        {
            var lst = TargetCustomer.ProjectProfiles.ToList(); //ProjectProfileCommand.GetAllByCustomerId(TargetCustomer.ID);
            this.Invoke((MethodInvoker)delegate {

                customerNameTextBox.Text = TargetCustomer.CustomerName;
               
                phoneNumberTextBox.Text = TargetCustomer.PhoneNumber;

                CreateTextBox.Text = TargetCustomer.CreateDate.ToString();

               
                ProjectGridView.DataSource = lst; 

                
            });

        }
        private void FrmMainProjectsCustomer_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(GetAllProjectForCurrentCustomer);
            th.Start();
            this.Text = string.Format("{0}-{1}", this.Text, TargetCustomer.CustomerName);
        }

        private void ProjectGridView_CommandCellClick(object sender, EventArgs e)
        {
            if (ProjectGridView.Rows.Count != 0)
            {

                var col = ProjectGridView.CurrentColumn.Index;
                if (col == 7)
                {

                    Operation.BeginOperation(this);
                    FrmViewProject frm = new FrmViewProject();

                    ProjectProfile tb = (ProjectProfile)ProjectGridView.CurrentRow.DataBoundItem;
                    frm.TargetProject = tb;

                    frm.ShowDialog();
                    Operation.EndOperation(this);
                }
            }
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {

            CustomerProjectCommand cmdRpt = new CustomerProjectCommand();
            cmdRpt.CustomerProjectByCusId(TargetCustomer.ID);
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
