using DataLayer.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.XAccountant
{
    public class AccountDailyCommand : BaseDatabase
    {
        public delegate void OnchangeCallBack(string processName, string Usermsg, string description);
        public static event OnchangeCallBack ProcessChange;
        public static bool NewAccountDaily(AccountDaily tb)
        {
            //try
            //{


                db.AccountDailies.InsertOnSubmit(tb);
                db.SubmitChanges();
                History htb = new History()
                {
                    ActionName = "Adding New Account Daily",
                    Description = "Account ID " + tb.AccountID +
                     "\n Total In : " + tb.TotalIn.ToString() +
                     "Total Out : " + tb.TotalOut.ToString() +
                     "Date Of Process : " + tb.DateOfProcess.ToString() +
                     "Description : " + tb.Description+
                     "Command Arg : " + tb.CommandArg,
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser,
                    HistoryAction = "Adding New Account Daily",

                };
                db.Histories.InsertOnSubmit(htb);
                db.SubmitChanges();
                //ProcessChange("Adding Account Daily ", tb.AccountID + " has Been Saved ", null);
                return true;
            //}
            //catch (Exception e)
            //{

            //    ProcessChange("Error message", "Can't Account Daily", e.ToString());
            //    return false;
            //}
        }

        public static bool EditAccountDaily(AccountDaily tb)
        {
            try
            {
                var q = db.AccountDailies.Where(p => p.ID == tb.ID).Single();
                q.AccountID = tb.AccountID;
                q.TotalIn = tb.TotalIn;
                q.TotalOut = tb.TotalOut;
                q.DateOfProcess = tb.DateOfProcess;
                q.Description = tb.Description;
                q.CommandArg = tb.CommandArg;
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Edit Account Daily",
                    Description = String.Format("old Info Is Account ID {0}\n  Total In : {1} Total Out {2} Date Of Process {3} Description {4} Command Arg {5}  \n New Info Is Account ID {6}\n  Total In : {7} Total Out {8} Date Of Process {9} Description {10} Command Arg {11}", q.AccountID, q.TotalIn, q.TotalOut, q.DateOfProcess, q.Description, q.CommandArg, tb.AccountID, tb.TotalIn, tb.TotalOut, tb.DateOfProcess, tb.Description, tb.CommandArg),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser
                });

                ProcessChange("Edit Account Daily", tb.AccountID + " has Been Edited ", null);
                q = null;
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Edit Account Daily", e.ToString());
                return false;
            }
        }

        public static bool DeleteAccountDaily(int iD)
        {
            try
            {
                var q = db.AccountDailies.Where(p => int.Parse(p.ID.ToString()) == iD).Single();
                db.AccountDailies.DeleteOnSubmit(q);
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Delete Account Daily",
                    Description = String.Format(" Info Is Account ID {0}\n  Total In : {1} Total Out {2} Date Of Process {3} Description {4} Command Arg {5}", q.AccountID, q.TotalIn, q.TotalOut, q.DateOfProcess, q.Description, q.CommandArg),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser
                });
                q = null;
                ProcessChange("Delete Account Daily", q.AccountID + " has Been Deleted ", null);
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Delete Account Daily", e.ToString());
                return false;
            }
        }

        public static List<AccountDaily> GetAll()
        {
            return db.AccountDailies.ToList();
        }

        public static List<AccountDaily> GetAllAccountDailyByAccountID(int actid)
        {
            db = new dbDataContext(); ;
            var dy = (from d in db.AccountDailies
                      orderby d.DateOfProcess ascending
                      where d.AccountID == actid
                      select d).ToList();
            return dy;
        }
        public static double GetBalanceByAccountID(int ACTID)
        {
            double netBalance = 0;
            try
            {
                db = new  dbDataContext ();

                var totIn = (from d in db.AccountDailies
                             orderby d.DateOfProcess ascending
                             where d.AccountID == ACTID
                             select d.TotalIn).Sum();

                var totOut = (from d in db.AccountDailies
                              orderby d.DateOfProcess ascending
                              where d.AccountID == ACTID
                              select d.TotalOut).Sum();
                netBalance = totIn.Value - totOut.Value;

                return netBalance;
            }
            catch (Exception)
            {
                return netBalance = 0;
            }
        }

    }
}
