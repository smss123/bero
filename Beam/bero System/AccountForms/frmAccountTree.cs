using DataLayer.XAccountant;
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

                    TreeAccounts.Nodes[0].Nodes.Add("", item.AccountCategoryName, 1).ForeColor = Color.Black ;
                    var Accts = AccountCommand.GetAccountByCategoryID(item.ID);
                   
                    foreach (var Actitem in Accts)
                    {
                        TreeAccounts.Nodes[0].Nodes[Indx].Nodes.Add("", Actitem.AccountName, 2).ForeColor = Color.Blue;
                    }
                    Indx++;
                }



            });
            Operation.EndOperation(this);
        }

        private void frmAccountTree_Load(object sender, EventArgs e)
        {
            TreeMainPopulate();
            Thread TreeThread = new Thread(PopulateTreeAccounts);
            TreeThread.Start();
            //===============================
            DGVAccountsDaily.Rows.Clear();

            var Accts = (from c in AccountCommand.GetAll() select c.AccountName).ToArray();
            TextBoxAutoComplate(SearchTextBox, Accts);

        }

        private void TreeMainPopulate()
        {
            TreeAccounts.Nodes.Clear();
            TreeAccounts.ImageList = imageList1;
            TreeAccounts.Nodes.Add("AbuEhab", "شجرة الحسابات", 0).ForeColor = Color.Red;
            TreeAccounts.Nodes["AbuEhab"].NodeFont = new System.Drawing.Font("Times New Roman", 10, FontStyle.Bold);
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

    

        #region "      *** AutoComplate              "

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextKeyDown(SearchTextBox, e);

            if (e.KeyCode == Keys.Enter)
            {
          
                Broom();
                var accts = AccountCommand.GetAccountByName(SearchTextBox.Text);
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


        public static void TextKeyDown(TextBox TextBoxName, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (!TextBoxName.AutoCompleteCustomSource.Contains(TextBoxName.Text))
                {

                    TextBoxName.AutoCompleteCustomSource.Add(TextBoxName.Text);
                }

            }
            else if (e.KeyCode == Keys.Delete)
            {
                ((AutoCompleteStringCollection)TextBoxName.AutoCompleteCustomSource).Remove(TextBoxName.Text);
                TextBoxName.Clear();
            }
        }


        public static void TextBoxAutoComplate(TextBox TextBoxName, string[] Datasource)
        {
            TextBoxName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TextBoxName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection TheSource = new AutoCompleteStringCollection();
            TextBoxName.AutoCompleteCustomSource = TheSource;
            TheSource.AddRange(Datasource);

        }


        

  


        #endregion
    }
}
