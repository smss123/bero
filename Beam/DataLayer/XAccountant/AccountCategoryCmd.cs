using DataLayer.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.XAccountant
{
    public class AccountCategoryCmd :BaseDatabase
    {
        public delegate void OnchangeCallBack(string processName, string Usermsg, string description);
        public static event OnchangeCallBack ProcessChange;
        public static bool NewAccountCategory(AccountCategory tb)
        {
            try
            {

                db.AccountCategories.InsertOnSubmit(tb);
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Adding New Account Category",
                    Description = "Account Category Name " + tb.AccountCategoryName +
                     "\n Description : " + tb.Description,
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser,
                    HistoryAction = "Adding New Account Category",

                });
                ProcessChange("Adding Account Category ", tb.AccountCategoryName + " has Been Saved ", null);
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Account Category", e.ToString());
                return false;
            }
        }

        public static bool EditAccountCategory(AccountCategory tb)
        {
            try
            {
                var q = db.AccountCategories.Where(p => p.ID == tb.ID).Single();
                q.AccountCategoryName = tb.AccountCategoryName;
                q.Description = tb.Description;
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Edit Account Category",
                    Description = String.Format("old Info Is Account Category Name {0}\n Description : {1} \n New Info Is Account Category Name {2}\n Description : {3}", q.AccountCategoryName, q.Description, tb.AccountCategoryName, tb.Description),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser
                });

                ProcessChange("Edit Account Category", tb.AccountCategoryName + " has Been Edited ", null);
                q = null;
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Edit Account Category", e.ToString());
                return false;
            }
        }

        public static bool DeleteAccountCategory(int iD)
        {
            try
            {
                var q = db.AccountCategories.Where(p => int.Parse(p.ID.ToString()) == iD).Single();
                db.AccountCategories.DeleteOnSubmit(q);
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Delete Account Category",
                    Description = String.Format("Info Is Account Category Name {0}\n Description : {1}", q.AccountCategoryName, q.Description),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser
                });
                q = null;
                ProcessChange("Delete Account Category", q.AccountCategoryName + " has Been Deleted ", null);
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Delete Account Category", e.ToString());
                return false;
            }
        }

        public static List<AccountCategory> GetAll()
        {
            return db.AccountCategories.ToList();
        }

    }
}
