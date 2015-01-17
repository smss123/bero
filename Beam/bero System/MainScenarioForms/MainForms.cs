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
    }
}
