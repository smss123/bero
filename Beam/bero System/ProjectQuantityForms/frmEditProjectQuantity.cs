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

        private void frmEditProjectQuantity_Load(object sender, EventArgs e)
        {
            //this 
        }
    }
}
