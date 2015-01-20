﻿using DataLayer;
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
namespace bero_System.projectLevelFroms
{
    public partial class FrmManageprojectLevel : RadForm
    {
        public FrmManageprojectLevel()
        {
            InitializeComponent();
        }
      public ProjectProfile TargetProjectx { get; set; }
     
        void PopulateDgv()
        {

            var LstLevels = projectLevelCommand.GetByProjectProfileID(TargetProjectx .ID );

            this.Invoke((MethodInvoker)delegate { projectLevelGridView.DataSource = LstLevels; });
          
        }
        private void FrmManageprojectLevel_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(PopulateDgv);
            th.Start();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            FrmAddprojectLevel frm = new FrmAddprojectLevel();
            frm.TargetProjectx = this.TargetProjectx;
            frm.ShowDialog();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmManageprojectLevel_Load(sender, e);
        }

        private void projectLevelGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = projectLevelGridView.CurrentColumn.Index;
            if (col == 5)
            {

                Operation.BeginOperation(this);
                FrmEditprojectLevel frm = new FrmEditprojectLevel();

                projectLevel tb = (projectLevel)projectLevelGridView.CurrentRow.DataBoundItem;

                frm.TargetLevel = tb;

                frm.ShowDialog();
                Operation.EndOperation(this);
            }
            if (col == 6)
            {

                Operation.BeginOperation(this);

                projectLevelCommand.DeleteprojectLevel (int.Parse(projectLevelGridView.CurrentRow.Cells[0].Value.ToString()));
                FrmManageprojectLevel_Load(sender, e);

                Operation.EndOperation(this);
            }
        }
    }
}
