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
using DataLayer.XProject;
namespace bero_System.projectLevelFroms
{
    public partial class FrmAddprojectLevel : RadForm
    {
        public FrmAddprojectLevel()
        {
            InitializeComponent();
        }
        public ProjectProfile TargetProjectx { get; set; }
        private void AddBtn_Click(object sender, EventArgs e)
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

            projectLevel LevelTable = new projectLevel() {
             LevelName = levelNameTextBox .Text ,
             LevelAmount = Convert.ToDouble (levelAmountTextBox .Text .ToString ()),
             Descripotion = descripotionTextBox .Text ,
             ProjectProfileID = TargetProjectx .ID ,
            AccountID = 4 
            };
            projectLevelCommand.NewprojectLevel(LevelTable);
            //======================================================================================
            AccountDaily actTb1 = new AccountDaily()
            {
                AccountID = TargetProjectx .AccountID ,
                TotalIn = 0f,
                TotalOut = Convert.ToDouble(levelAmountTextBox.Text.ToString()),
                DateOfProcess = DateTime.Now,
                Description = string.Format("come out the project : {0} account an amount of :  {1}", TargetProjectx .ProjectName , levelAmountTextBox.Text.ToString()),
                CommandArg = ""
            };
            DataLayer.XAccountant.AccountDailyCommand.NewAccountDaily(actTb1);

            // ^^^^ 

            AccountDaily actTb2 = new AccountDaily()
            {
                AccountID = 4,
                TotalIn = Convert.ToDouble(levelAmountTextBox.Text.ToString()),
                TotalOut = 0F,
                DateOfProcess = DateTime.Now,
                Description = string.Format("Income In : {0} account an amount of :  {1}", LevelTable.LevelName, levelAmountTextBox.Text.ToString()),
                CommandArg = ""
            };

            DataLayer.XAccountant.AccountDailyCommand.NewAccountDaily(actTb2);
            //====================================================================
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
    }
}
