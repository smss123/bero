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
using System.Threading;
using Telerik.WinControls;
namespace bero_System.BulidItemForms
{
    public partial class FrmManageBulidItem : RadForm
    {
        public FrmManageBulidItem()
        {
            InitializeComponent();
        }
        void PopulateGrid()
        {
            var LstBuildItemes = BulidItemCommand.GetAll();
            this.Invoke((MethodInvoker)delegate { BulidItemGridView.DataSource = LstBuildItemes; });
        }
        private void FrmManageBulidItem_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(PopulateGrid);
            th.Start();

        }

        private void BulidItemGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = BulidItemGridView.CurrentColumn.Index;
            if (col == 5)
            {
                 
                Operation.BeginOperation(this);
                FrmEditBulidItem frm = new FrmEditBulidItem();

                BulidItem tb  = (BulidItem)BulidItemGridView.CurrentRow.DataBoundItem;
                frm.TargetBuildItem = tb;

                frm.ShowDialog();
                Operation.EndOperation(this);
            }
            if (col == 6)
            {
                Operation.BeginOperation(this);
                RadMessageBox.ThemeName = this.ThemeName;
                if (RadMessageBox.Show("هل تريد حذف العنصر؟", "", MessageBoxButtons.YesNo, RadMessageIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        BulidItemCommand.DeleteBulidItem(int.Parse(BulidItemGridView.CurrentRow.Cells[0].Value.ToString()));
                        FrmManageBulidItem_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("This is not supported"))
                        {
                            RadMessageBox.Show("لا يمكن حذف العنصر لانه مرتبط ببعض العمليات في النظام");
                        }
                        if (ex.Message.Contains("he DELETE statement conflicted with the REFERENCE constraint"))
                        {
                            RadMessageBox.Show("لا يمكن حذف العنصر لانه مرتبط ببعض العمليات في النظام");


                        }
                    }

                }
               

                

                Operation.EndOperation(this);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            FrmAddBulidItem FRM = new FrmAddBulidItem();
            FRM.ShowDialog();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmManageBulidItem_Load(sender, e);
        }
    }
}
