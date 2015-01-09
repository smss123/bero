using DataLayer.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.XProject
{
   public class ProjectExpenssesCommand:BaseDatabase
    {
        public delegate void OnchangeCallBack(string processName, string Usermsg, string description);
        public static event OnchangeCallBack ProcessChange;
        public static bool NewProjectQuantity(ProjectExpenss tb)
        {
            try
            {

                db.ProjectExpensses.InsertOnSubmit(tb);
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Adding New Project Expenss",
                    Description = "Item ID " + tb.ExpenssesID +
                     "\n Amount : " + tb.Amount +
                     "Description : " + tb.Description +
                     "date Of Expensses : " + tb.dateOfExpensses +
                     "Project Level ID" + tb.ProjectLevelID.ToString(),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser,
                    HistoryAction = "Adding New Project Expenss",

                });
                ProcessChange("Adding Project Expenss ", tb.ExpenssesID + " has Been Saved ", null);
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Project Expenss", e.ToString());
                return false;
            }
        }

        public static bool EditProjectQuantity(ProjectExpenss tb)
        {
            try
            {
                var q = db.ProjectExpensses.Where(p => p.ID == tb.ID).Single();
                q.ExpenssesID = tb.ExpenssesID;
                q.Amount = tb.Amount;
                q.Description = tb.Description;
                q.dateOfExpensses = tb.dateOfExpensses;
              
                q.ProjectLevelID = tb.ProjectLevelID;
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Edit Project Expenss",
                    Description = String.Format("old Info Is Expensses ID {0}\n Amount : {1} Description {2} dateOfExpensses {3} ProjectLevelID{4} \n Expensses ID {5}\n Amount : {6} Description {7} dateOfExpensses {8} ProjectLevelID{9}", q.ExpenssesID, q.Amount, q.Description, q.dateOfExpensses,q.ProjectLevelID, tb.ExpenssesID, tb.Amount, tb.Description, tb.dateOfExpensses,tb.ProjectLevelID),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser
                });

                ProcessChange("Edit Project Expenss", tb.ExpenssesID + " has Been Edited ", null);
                q = null;
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Edit Project Expenss", e.ToString());
                return false;
            }
        }

        public static bool DeleteProjectQuantity(int iD)
        {
            try
            {
                var q = db.ProjectExpensses.Where(p => p.ID == iD).Single();
                db.ProjectExpensses.DeleteOnSubmit(q);
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Delete Project Expenss",
                    Description = String.Format(" Info Is Expensses ID {0}\n Amount : {1} Description {2} dateOfExpensses {3} ProjectLevelID{4} \n", q.ExpenssesID, q.Amount, q.Description, q.dateOfExpensses, q.ProjectLevelID),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser
                });
                q = null;
                ProcessChange("Delete Project Expenss", q.ExpenssesID + " has Been Deleted ", null);
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Delete Project Expenss", e.ToString());
                return false;
            }
        }

        public static List<ProjectExpenss> GetAll()
        {
            return db.ProjectExpensses.ToList();
        }
    }
}
