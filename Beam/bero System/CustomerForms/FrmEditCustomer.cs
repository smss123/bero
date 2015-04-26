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
using DataLayer;
using DataLayer.XCustomer;
namespace bero_System.CustomerForms
{
    public partial class FrmEditCustomer : RadForm
    {
        public FrmEditCustomer()
        {
            InitializeComponent();
        }

        public Customer TargetRecord { get; set; }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (customerNameTextBox.Text == "")
            {

                customerNameTextBox.BackColor = Color.OrangeRed;

                customerNameTextBox.Focus();
                errorProvider1.SetError(this.customerNameTextBox, "من فضلك ادخل اسم العميل");

                return;
            }
            else
            {
                customerNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }



            #endregion

            TargetRecord.CustomerName = this.customerNameTextBox.Text;
            TargetRecord.PhoneNumber = this.phoneNumberTextBox.Text;
            TargetRecord.CustomerEmail = this.txtEmail.Text;
           // TargetRecord.Total_Need = 0;
            CustomerCommand.EditCustomer(TargetRecord);
            this.Hide();
        }

        private void FrmEditCustomer_Load(object sender, EventArgs e)
        {
            this.customerNameTextBox.Text = this.TargetRecord.CustomerName;
            this.phoneNumberTextBox.Text = this.TargetRecord.PhoneNumber;
            txtEmail.Text = TargetRecord.CustomerEmail;

        }

        private void phoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
