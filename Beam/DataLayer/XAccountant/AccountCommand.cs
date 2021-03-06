﻿using DataLayer.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.XAccountant
{
   public class AccountCommand:BaseDatabase
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

               
               return false;
           }
       }
       public static List<Account> GetAccountByCategoryID(int Categid)
       {
           db = new dbDataContext(Properties.Settings.Default.xprema_beroConnectionString);
           var Lst = (from c in db.Accounts where c.CategoryID == Categid select c).ToList();
           return Lst;

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

               
               return false;
           }
       }
       public static List<Account> GetAccountByName(string nam)
       {
           db = new dbDataContext ();
           var ACT = (from ac in db.Accounts
                      where ac.AccountName == nam
                      select ac).ToList();
           return ACT;
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


       public static double GetFreeBalance(int? actid)
       {
           double NetBalance = 0;
           try
           {
               db = new dbDataContext(Properties.Settings.Default.xprema_beroConnectionString);

               var TotIn = (from d in db.AccountDailies
                            where d.AccountID == actid
                            select d.TotalIn).Sum();

               var TotOut = (from d in db.AccountDailies
                             where d.AccountID == actid
                             select d.TotalOut).Sum();
               NetBalance = TotIn.Value - TotOut.Value;

               return NetBalance;
           }
           catch (Exception)
           {
               return NetBalance = 0;
           }
       }

       public static double? GetAccountBalance(int accountID)
       {
           var balance = (double?)0d;

           var allTotalIn = db.AccountDailies.Where(p => p.AccountID == accountID).Sum(p => p.TotalIn);
           var allTotalOut = db.AccountDailies.Where(p => p.AccountID == accountID).Sum(p => p.TotalOut);
           balance = allTotalIn - allTotalOut;

           return balance;
       }

       public static double? GetAccountBalance(int accountID, DateTime fromDate, DateTime toDate)
       {
           var balance = (double?)0d;

           var allTotalIn = db.AccountDailies.Where(
           p => p.AccountID == accountID &&
                p.DateOfProcess.Value.Year >= fromDate.Year
                && p.DateOfProcess.Value.Month >= fromDate.Month &&
                p.DateOfProcess.Value.Day >= fromDate.Day &&

                 p.DateOfProcess.Value.Year <= toDate.Year
                && p.DateOfProcess.Value.Month <= toDate.Month &&
                p.DateOfProcess.Value.Day <= toDate.Day

                ).Sum(p => p.TotalIn);
           var allTotalOut = db.AccountDailies.Where(p => p.AccountID == accountID &&
                p.DateOfProcess.Value.Year >= fromDate.Year
                && p.DateOfProcess.Value.Month >= fromDate.Month &&
                p.DateOfProcess.Value.Day >= fromDate.Day &&

                 p.DateOfProcess.Value.Year <= toDate.Year
                && p.DateOfProcess.Value.Month <= toDate.Month &&
                p.DateOfProcess.Value.Day <= toDate.Day
                ).Sum(p => p.TotalOut);
           balance = allTotalIn - allTotalOut;

           return balance;
       }
    }
}
