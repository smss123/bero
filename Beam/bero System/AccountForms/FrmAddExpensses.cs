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
//================================
using System.Threading;
using DataLayer;
using DataLayer.XAccountant;
namespace bero_System.AccountForms
{
    public partial class FrmAddExpensses : RadForm
    {
        public FrmAddExpensses()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
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

            Operation.BeginOperation(this);
            Expenss extb = new Expenss() 
            { 
                ExpenssesName = expenssesNameTextBox.Text,
                Description = descriptionTextBox.Text 
            };
            ExpenssesCommand.NewExpensses(extb); 

   
                        
                foreach (Control item in radGroupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Clear();
                    }
                }

            Operation.EndOperation(this);
            _Alert.Info("تـــــــم الحــــفظ بنجــــــــاح");

            expenssesNameTextBox.Focus();


        }
    }
}
