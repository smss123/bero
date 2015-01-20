using DataLayer;
using DataLayer.XProject;
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

namespace bero_System.projectLevelFroms
{
    public partial class FrmEditprojectLevel : RadForm
    {
        public FrmEditprojectLevel()
        {
            InitializeComponent();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            #region "  CheckFillTextBox "

            if (levelNameTextBox.Text == "")
            {

                levelNameTextBox.BackColor = Color.OrangeRed;

                levelNameTextBox.Focus();
                errorProvider1.SetError(this.levelNameTextBox, "من فضلك ادخل اسم المستوى");

                return;
            }
            else
            {
                levelNameTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }

            if (levelAmountTextBox.Text == "")
            {

                levelAmountTextBox.BackColor = Color.OrangeRed;

                levelAmountTextBox.Focus();
                errorProvider1.SetError(this.levelAmountTextBox, "من فضلك ادخل الموزانة");

                return;
            }
            else
            {
                levelAmountTextBox.BackColor = Color.White;
                errorProvider1.Clear();

            }

            #endregion

            Operation.BeginOperation(this);

        
               TargetLevel. LevelName = levelAmountTextBox.Text;
                TargetLevel.  LevelAmount = Convert.ToDouble(levelAmountTextBox.Text.ToString());
                TargetLevel.  Descripotion = descripotionTextBox.Text;
                TargetLevel.ProjectProfileID = TargetLevel.ProjectProfileID;


            projectLevelCommand.EditprojectLevel (TargetLevel );

            foreach (Control item in radGroupBox1.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
            }

            Operation.EndOperation(this);
            Operation.ShowToustOk("تم الحفظ", this);


        }
        public projectLevel  TargetLevel { get; set; }
        private void FrmEditprojectLevel_Load(object sender, EventArgs e)
        {
            levelNameTextBox.Text = TargetLevel.LevelName.ToString();
            levelAmountTextBox.Text = TargetLevel.LevelAmount.ToString();
            descripotionTextBox.Text = TargetLevel.Descripotion.ToString();

        }
    }
}
