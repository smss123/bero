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
using System.IO;
using DataLayer;
using DataLayer.XProject;
using System.Threading;
using System.Diagnostics;
using Telerik.WinControls;
namespace bero_System.ProjectAttachmentForms
{
    public partial class FrmManageProjectAttachment : RadForm
    {
        public FrmManageProjectAttachment()
        {
            InitializeComponent();
        }
        public ProjectProfile  TargetProject{ get; set; }
        void PopulateDgv()
        {

            var q = ProjectAttachmentCommand.GetByProjectProfileID(TargetProject.ID);
            this.Invoke((MethodInvoker)delegate { ProjectAttachmentGridView.DataSource = q; });
        }

        private void FrmManageProjectAttachment_Load(object sender, EventArgs e)
        {
            Thread thh = new Thread(PopulateDgv);
            thh.Start();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmManageProjectAttachment_Load(sender, e);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            FrmAddProjectAttachment frm = new FrmAddProjectAttachment();
            frm.TargetProject = this.TargetProject;
            frm.ShowDialog();
        }

        private void ProjectAttachmentGridView_CommandCellClick(object sender, EventArgs e)
        {
            RadMessageBox.ThemeName = this.ThemeName;
            var col = ProjectAttachmentGridView.CurrentColumn.Index;
            if (col ==3)
            {

                Operation.BeginOperation(this);
                try
                {
                    ProjectAttachment tb = (ProjectAttachment)ProjectAttachmentGridView.CurrentRow.DataBoundItem;
                    Process.Start(tb.FilePath);
                    Operation.EndOperation(this);

                }
                catch (Exception)
                {

                    RadMessageBox.Show("لا يمكن تشغيل الملف حاليا");
                }

               
            }
            if (col == 4)
            {
                if (RadMessageBox.Show("هل تريد الحذف؟","",MessageBoxButtons.YesNo,RadMessageIcon.Question)==System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        Operation.BeginOperation(this);
                        ProjectAttachmentCommand.DeleteProjectAttachment(Guid.Parse(ProjectAttachmentGridView.CurrentRow.Cells[0].Value.ToString()));
                        FrmManageProjectAttachment_Load(sender, e);
                        Operation.EndOperation(this);
                    }
                    catch (Exception)
                    {

                        RadMessageBox.Show("لا يمكن الحذف حاليا");
                    }
                   
                }
               
            }
        }

        private void ProjectAttachmentGridView_Click(object sender, EventArgs e)
        {

        }
    }
}
