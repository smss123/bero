﻿using DataLayer.XAccountant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace bero_System.AccountForms
{
    public partial class frmAccountTree : RadForm
    {
        public frmAccountTree()
        {
            InitializeComponent();
        }
        int Indx = 0;
        void PopulateTreeAccounts()
        {
            Operation.BeginOperation(this);
            var acctCategories = AccountCategoryCmd.GetAll();


            this.Invoke((MethodInvoker)delegate
            {

                foreach (var item in acctCategories)
                {

                    TreeAccounts.Nodes[0].Nodes.Add("", item.AccountCategoryName, 1).ForeColor = Color .Blue ;
                    var Accts = AccountCommand.GetAccountByCategoryID(item.ID);
                   
                    foreach (var Actitem in Accts)
                    {
                        TreeAccounts.Nodes[0].Nodes[Indx].Nodes.Add("", Actitem.AccountName, 2).ForeColor = Color.Goldenrod;
                    }
                    Indx++;
                }



            });
            Operation.EndOperation(this);
        }

        private void frmAccountTree_Load(object sender, EventArgs e)
        {
            TreeAccounts.Nodes.Clear();
            TreeAccounts.ImageList = imageList1;
            TreeAccounts.Nodes.Add("AbuEhab", "شجرة الحسابات", 0).ForeColor = Color .Red ;
            TreeAccounts .Nodes ["AbuEhab"].NodeFont = new System.Drawing.Font ("Times New Roman",10, FontStyle.Bold );
            Thread TreeThread = new Thread(PopulateTreeAccounts);
            TreeThread.Start();
            //===============================
            DGVAccountsDaily.Rows.Clear();
        }

        private void ExpandBtn_Click(object sender, EventArgs e)
        {
             TreeAccounts.ExpandAll();
             Broom();
        }

        private void CollapseBtn_Click(object sender, EventArgs e)
        {
            TreeAccounts.CollapseAll();
            Broom();
        }

        #region "  ^^^  Get Account Details        "
        public int AcctID { get; set; }
        private void TreeAccounts_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (TreeAccounts.Nodes.Count != 0)
            {
                Broom();
                var accts = AccountCommand.GetAccountByName(e.Node.Text);
                foreach (var actitem in accts)
                {
                    AcctID = actitem.ID;
                    txtAccountName.Text = actitem.AccountName;
                    txtDescription.Text = actitem.Description;

                }

                Thread DGVThread = new Thread(GetAccountDetails);
                DGVThread.Start();
            }
        }
        void GetAccountDetails()
        {
            Operation.BeginOperation(this);
            var getCurrentAccount = AccountDailyCommand.GetAllAccountDailyByAccountID(AcctID);
            this.Invoke((MethodInvoker)delegate
            {
                DGVAccountsDaily.DataSource = getCurrentAccount;
                double balance = AccountDailyCommand.GetBalanceByAccountID(AcctID);
                txtBalance.Text = balance.ToString();
            });
            Operation.EndOperation(this);
        }
        void Broom() { txtDescription.Text = ""; txtAccountName.Text = ""; txtBalance.Text = ""; DGVAccountsDaily.Rows.Clear(); }
        #endregion 

        private void txtAccountName_TextChanged(object sender, EventArgs e)
        {
         

               

              
            
        }

        private void ReportOptionBtn_Click(object sender, EventArgs e)
        {
        
        }

        
       
    }
}