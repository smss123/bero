using DataLayer.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.XAccountant
{
   public class AccountCommand:BaseDatabase
    {
   {
       public delegate void OnchangeCallBack(string processName, string Usermsg, string description);
       public static event OnchangeCallBack ProcessChange;
       public static bool NewAccount(Account tb)
       {
           try
           {

               db.Accounts.InsertOnSubmit(tb);
               db.SubmitChanges();
               HistoryCommand.NewHistory(new History()
               {
                   ActionName = "Adding New  Account",
                   Description = "Account Name " + tb.AccountName +
                   "\n  Description : " + tb.Description +
                   "Category ID : " + tb.CategoryID,
                   DateOfProcess = DateTime.Now,
                   SystemUser = LoginInfomation.CurrnetUser,
                   HistoryAction = "Adding New  Account",

               });
               ProcessChange("Adding Account ", tb.AccountName + " has Been Saved ", null);
               return true;
           }
           catch (Exception e)
           {

               ProcessChange("Error message", "Can't Account", e.ToString());
               return false;
           }
       }

       public static bool EditAccount(Account tb)
       {
           try
           {
               var q = db.Accounts.Where(p => p.ID == tb.ID).Single();
               q.AccountName = tb.AccountName;
               q.Description = tb.Description;
               q.CategoryID = tb.CategoryID;
               db.SubmitChanges();
               HistoryCommand.NewHistory(new History()
               {
                   ActionName = "Edit Account",
                   Description = String.Format("old Info Is Account Name {0}\n  Description : {1} Category ID {2} \n New Info Is Account Name {4}\n Description : {4} Category ID {5}", q.AccountName, q.Description, q.CategoryID, tb.AccountName, tb.Description, tb.CategoryID),
                   DateOfProcess = DateTime.Now,
                   SystemUser = LoginInfomation.CurrnetUser
               });

               ProcessChange("Edit Account", tb.AccountName + " has Been Edited ", null);
               q = null;
               return true;
           }
           catch (Exception e)
           {

               ProcessChange("Error message", "Can't Edit Account", e.ToString());
               return false;
           }
       }

       public static bool DeleteAccount(int iD)
       {
           try
           {
               var q = db.Accounts.Where(p => int.Parse(p.ID.ToString()) == iD).Single();
               db.Accounts.DeleteOnSubmit(q);
               db.SubmitChanges();
               HistoryCommand.NewHistory(new History()
               {
                   ActionName = "Delete Account",
                   Description = String.Format("Info Is Account Name {0}\n Description : {1} Category ID {2}", q.AccountName, q.Description, q.CategoryID),
                   DateOfProcess = DateTime.Now,
                   SystemUser = LoginInfomation.CurrnetUser
               });
               q = null;
               ProcessChange("Delete Account", q.AccountName + " has Been Deleted ", null);
               return true;
           }
           catch (Exception e)
           {

               ProcessChange("Error message", "Can't Delete Account", e.ToString());
               return false;
           }
       }

       public static List<Account> GetAll()
       {
           return db.Accounts.ToList();
       }
    }
}
