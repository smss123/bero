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

namespace bero_System.CustomerForms
{
    public partial class FrmAddCustomer : RadForm
    {
        public FrmAddCustomer()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
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
        }
    }
}
