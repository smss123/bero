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
using DataLayer.XAccountant;
namespace bero_System.AccountForms
{
    public partial class FrmEditExpensses : RadForm
    {
        public FrmEditExpensses()
        {
            InitializeComponent();
        }

        public Expenss TragetExpenss  { get; set; }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (expenssesNameTextBox.Text == "")
            {

                expenssesNameTextBox.BackColor = Color.OrangeRed;

                expenssesNameTextBox.Focus();
                errorProvider1.SetError(this.expenssesNameTextBox, "من فضلك ادخل نوع المصروف");

                return;
            }
            else
            {
                expenssesNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }



            #endregion

            TragetExpenss.ExpenssesName = expenssesNameTextBox.Text;
            TragetExpenss.Description = descriptionTextBox.Text;
            ExpenssesCommand.EditExpensses(TragetExpenss);

        }

        private void FrmEditExpensses_Load(object sender, EventArgs e)
        {
            expenssesNameTextBox.Text = TragetExpenss.ExpenssesName;
            descriptionTextBox.Text = TragetExpenss.Description;
        }
    }
}
