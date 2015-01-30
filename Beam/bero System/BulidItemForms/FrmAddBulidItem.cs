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
using DataLayer.XBulidItem;

namespace bero_System.BulidItemForms
{
    public partial class FrmAddBulidItem : RadForm
    {
        public FrmAddBulidItem()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (itemNameTextBox.Text == "")
            {

                itemNameTextBox.BackColor = Color.OrangeRed;

                itemNameTextBox.Focus();
                errorProvider1.SetError(this.itemNameTextBox, "من فضلك ادخل اسم الصنف");

                return;
            }
            else
            {
                itemNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }

           

            #endregion


            try
            {
             Operation.BeginOperation(this);
             BulidItem xtb = BulidItemCommand.GetBuildItemByItemName(itemNameTextBox.Text);
             MessageBox.Show("موجود مسبقا");
             Operation.EndOperation(this);
             return;

            }
            catch (Exception)
            {
                
             Operation.BeginOperation(this);

            BulidItem tb = new BulidItem() {
             ItemName = itemNameTextBox .Text ,
              ItemDescription = itemDescriptionTextBox .Text ,
             ItemSummery = itemSummeryTextBox.Text 
            };
            BulidItemCommand.NewBulidItem(tb);

            Operation.EndOperation(this);

            Operation.ShowToustOk("تم الحفظ بنجاح", this);
            itemDescriptionTextBox.Text = "";
            itemNameTextBox.Text = "";
            itemSummeryTextBox.Text = "";
            itemNameTextBox.Focus();
            }
        }
    }
}
