using DataLayer.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.XAccountant
{
    public class ExpenssesMovmentCommand : BaseDatabase
    {

        public delegate void OnchangeCallBack(string processName, string Usermsg, string description);
        public static event OnchangeCallBack ProcessChange;
        public static bool NewExpenssesMovment(ExpenssesMovment tb)
        {
            try
            {

                db.ExpenssesMovments.InsertOnSubmit(tb);
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Adding New Expensses Movment",
                    Description = "Expensses ID " + tb.ExpenssesID +
                     "\n Amount : " + tb.Amount.ToString() +
                     "Date Of Process : " + tb.DateOfProcess.ToString() +
                     "Description : " + tb.Description,

                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser,
                    HistoryAction = "Adding New Expensses Movment",

                });
                ProcessChange("Adding Expensses Movment ", tb.ExpenssesID + " has Been Saved ", null);
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Expensses Movment", e.ToString());
                return false;
            }
        }

        public static bool EditExpenssesMovment(ExpenssesMovment tb)
        {
            try
            {
                var q = db.ExpenssesMovments.Where(p => p.ID == tb.ID).Single();
                q.ExpenssesID = tb.ExpenssesID;
                q.Amount = tb.Amount;
                q.DateOfProcess = tb.DateOfProcess;
                q.Description = tb.Description;


                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Edit Expensses Movment",
                    Description = String.Format("old Info Is Expensses ID {0}\n Amount : {1} Date Of Process {2} Description {3} \n New Info Is Expensses ID {4}\n Amount : {5} Date Of Process {6} Description {7}", q.ExpenssesID, q.Amount, q.DateOfProcess, q.Description, tb.ExpenssesID, tb.Amount, tb.DateOfProcess, tb.Description),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser
                });

                ProcessChange("Edit Expensses Movment", tb.ExpenssesID + " has Been Edited ", null);
                q = null;
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Edit Expensses Movment", e.ToString());
                return false;
            }
        }

        public static bool DeleteExpenssesMovment(int iD)
        {
            try
            {
                var q = db.ExpenssesMovments.Where(p => int.Parse(p.ID.ToString()) == iD).Single();
                db.ExpenssesMovments.DeleteOnSubmit(q);
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Delete Expensses Movment",
                    Description = String.Format(" Info Is Expensses ID {0}\n Amount : {1} Date Of Process {2} Description {3}", q.ExpenssesID, q.Amount, q.DateOfProcess, q.Description),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser
                });
                q = null;
                ProcessChange("Delete Expensses Movment", q.ExpenssesID + " has Been Deleted ", null);
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Delete Expensses Movment", e.ToString());
                return false;
            }
        }

        public static List<ExpenssesMovment> GetAll()
        {
            return db.ExpenssesMovments.ToList();
        }

        public static List<ExpenssesMovment> GetAllExpenssesMovmentByExpID(int expID)
        {
          

            var LST = (from c in db.ExpenssesMovments
                       where c.ExpenssesID == expID
                       select c).ToList();
            return LST;
        }
    }
}
