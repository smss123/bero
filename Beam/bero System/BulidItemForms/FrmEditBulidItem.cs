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
    public partial class FrmEditBulidItem : RadForm
    {
        public FrmEditBulidItem()
        {
            InitializeComponent();
        }


      public BulidItem TargetBuildItem { get; set; }
        

        private void SaveBtn_Click(object sender, EventArgs e)
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

            Operation.BeginOperation(this);

            TargetBuildItem.ItemName = itemNameTextBox.Text;
            TargetBuildItem.ItemDescription = itemDescriptionTextBox.Text;
            TargetBuildItem.ItemSummery = itemSummeryTextBox.Text;
            BulidItemCommand.EditBulidItem(TargetBuildItem);
            Operation.EndOperation(this);

            Operation.ShowToustOk("تم الحفظ بنجاح", this);
            itemDescriptionTextBox.Text = "";
            itemNameTextBox.Text = "";
            itemSummeryTextBox.Text = "";
            itemNameTextBox.Focus();
        }

        private void FrmEditBulidItem_Load(object sender, EventArgs e)
        {
            //
            itemSummeryTextBox.Text = TargetBuildItem.ItemSummery;
            itemNameTextBox.Text = TargetBuildItem.ItemName;
            itemDescriptionTextBox.Text = TargetBuildItem.ItemDescription;
        }
    }
}
