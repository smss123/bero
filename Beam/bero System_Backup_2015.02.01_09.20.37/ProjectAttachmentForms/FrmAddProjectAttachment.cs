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

namespace bero_System.ProjectAttachmentForms
{
    public partial class FrmAddProjectAttachment : RadForm
    {
        public FrmAddProjectAttachment()
        {
            InitializeComponent();
        }

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
        }
    }
}
