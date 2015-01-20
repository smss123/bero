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
using DataLayer;
using DataLayer.XProject;
using bero_System.ProjectExpenssesForms;
using bero_System.projectLevelFroms;



namespace bero_System.MainScenarioForms
{
    public partial class FrmViewProject : RadForm
    {
        public FrmViewProject()
        {
            InitializeComponent();
        }
        public ProjectProfile  TargetProject { get; set; }

        void LoadingProjectData()
        {
            projectNameTextBox.Text = TargetProject.ProjectName;
            projectDescriptionTextBox.Text = TargetProject.ProjectDescription ;
            projectFullAmountTextBox.Text = TargetProject.ProjectFullAmount.ToString ();
            CreatDatetextBox.Text = TargetProject.createdDate.ToString();
            DeliverDatetextBox.Text = TargetProject.DeliverDate.ToString();

        }
        private void FrmViewProject_Load(object sender, EventArgs e)
        {
            LoadingProjectData();
        }
       
        private void ProjectExpensessBtn_Click(object sender, EventArgs e)
        {
            FrmManageProjectExpensses frm = new FrmManageProjectExpensses();
            frm.TargetProject = this.TargetProject;
            frm.ShowDialog();
        }

        private void ProjectLevelsBtn_Click(object sender, EventArgs e)
        {
            FrmManageprojectLevel frm = new FrmManageprojectLevel();
            frm.TargetProjectx = this.TargetProject;
            frm.ShowDialog();
        }

      

    }
}
