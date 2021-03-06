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
using DataLayer;
using DataLayer.XCustomer;
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


            try
            {
                Customer ChkHim = CustomerCommand.GetCustomerByName(customerNameTextBox.Text);
                _Alert .Warning("موجـــــود مســـــــبقا");
                broom();
            }
            catch (Exception)
            {
               // Start Save
                Customer CustTb = new Customer()
                {
                    CustomerName = customerNameTextBox .Text ,
                    PhoneNumber = phoneNumberTextBox .Text ,
                    
                     Total_Need = 0 
                };
                CustomerCommand.NewCustomer(CustTb);
                _Alert.Info("تــــم الحــــــــفظ بنجـــــاح");
                broom();
                }

        }

        void broom()
        {
            customerNameTextBox.Text = "";
            phoneNumberTextBox.Text = "";
        
            customerNameTextBox.Focus();
        }

        private void FrmAddCustomer_Load(object sender, EventArgs e)
        {
          
          
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
