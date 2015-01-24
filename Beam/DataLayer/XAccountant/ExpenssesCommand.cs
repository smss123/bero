using DataLayer.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.XAccountant
{
    public class ExpenssesCommand : BaseDatabase
    {

        public delegate void OnchangeCallBack(string processName, string Usermsg, string description);
        public static event OnchangeCallBack ProcessChange;
        public static bool NewExpensses(Expenss tb)
        {
            //try
            //{

                db.Expensses.InsertOnSubmit(tb);
                db.SubmitChanges();
            //    HistoryCommand.NewHistory(new History()
            //    {
            //        ActionName = "Adding New Expensses",
            //        Description = "Expensses Name " + tb.ExpenssesName +
            //         "\n Description : " + tb.Description,
            //        DateOfProcess = DateTime.Now,
            //        SystemUser = LoginInfomation.CurrnetUser,
            //        HistoryAction = "Adding New Expensses",

            //    });
            //    ProcessChange("Adding Expensses ", tb.ExpenssesName + " has Been Saved ", null);
           return true;
            //}
            //catch (Exception e)
            //{

            //    ProcessChange("Error message", "Can't Expensses", e.ToString());
            //    return false;
           // }
        }

        public static bool EditExpensses(Expenss tb)
        {
            try
            {
                var q = db.Expensses.Where(p => p.ID == tb.ID).Single();
                q.ExpenssesName = tb.ExpenssesName;
                q.Description = tb.Description;
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Edit Expensses",
                    Description = String.Format("old Info Is Expensses Name {0}\n Description : {1} \n New Info Is Expensses Name {2}\n Description : {3}", q.ExpenssesName, q.Description, tb.ExpenssesName, tb.Description),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser
                });

                ProcessChange("Edit Expensses", tb.ExpenssesName + " has Been Edited ", null);
                q = null;
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Edit Expensses", e.ToString());
                return false;
            }
        }

        public static bool DeleteExpensses(int iD)
        {
            try
            {
                var q = db.Expensses.Where(p => int.Parse(p.ID.ToString()) == iD).Single();
                db.Expensses.DeleteOnSubmit(q);
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Delete Expensses",
                    Description = String.Format("Info Is Expensses Name {0}\n Description : {1}", q.ExpenssesName, q.Description),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser
                });
                q = null;
                ProcessChange("Delete Expensses", q.ExpenssesName + " has Been Deleted ", null);
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Delete Expensses", e.ToString());
                return false;
            }
        }

        public static List<Expenss> GetAll()
        {
            return db.Expensses.ToList();
        }
    }
}
