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
using System.IO;
using DataLayer;
using DataLayer.XProject;
namespace bero_System.ProjectAttachmentForms
{
    public partial class FrmAddProjectAttachment : RadForm
    {
        public FrmAddProjectAttachment()
        {
            InitializeComponent();
        }
        public ProjectProfile  TargetProject { get; set; }
        private void radButton1_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (pathtextBox.Text == "")
            {

                pathtextBox.BackColor = Color.OrangeRed;

                pathtextBox.Focus();
                errorProvider1.SetError(this.pathtextBox, "من فضلك قم باختيار الملف");

                return;
            }
            else
            {
                pathtextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }



            #endregion
            Operation.BeginOperation(this);
            ProjectAttachment th = new ProjectAttachment() {
            FileName = Op.SafeFileName ,
             FilePath = pathtextBox .Text ,
            // FileContent =  Op.FileName ,
             ProjectProfileID = TargetProject .ID 
            };
            ProjectAttachmentCommand.NewProjectAttachment(th);
            
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
        OpenFileDialog Op = new OpenFileDialog();
        private void BwrsBtn_Click(object sender, EventArgs e)
        {
           Op = new OpenFileDialog();
           if (Op.ShowDialog() == DialogResult.OK)
           {

               pathtextBox.Text = Op.FileName;


           }
        


        }

        private void FrmAddProjectAttachment_Load(object sender, EventArgs e)
        {
            //if (Directory.Exists(Application.StartupPath + "\\BermFiles") == false)
            //{
            //    Directory.CreateDirectory(Application.StartupPath + "\\BermFiles");
            //}
            
        
        }
    }
}
