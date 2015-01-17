using bero_System.CustomerForms;
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
using bero_System.ProjectForms;
namespace bero_System.MainScenarioForms
{
    public partial class MainForms : RadForm
    {
        public MainForms()
        {
            InitializeComponent();
        }

        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            FrmAddCustomer Frm = new FrmAddCustomer();
            Frm.ShowDialog();
        }

        private void ManageCustomerBtn_Click(object sender, EventArgs e)
        {
            FrmManageCustomer frm = new FrmManageCustomer();
            frm.Show();
        }


        private void MainForms_Load(object sender, EventArgs e)
        {

        }

        private void ManageProjects_Click(object sender, EventArgs e)
        {
            FrmManageProject frm = new FrmManageProject();
            frm.Show();
        }
    }
}
