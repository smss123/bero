using DataLayer.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.XProject
{
    public class ProjectQuantityCommand : BaseDatabase
    {


        public delegate void OnchangeCallBack(string processName, string Usermsg, string description);
        public static event OnchangeCallBack ProcessChange;
        public static bool NewProjectQuantity(ProjectQuantity tb)
        {
            try
            {

                db.ProjectQuantities.InsertOnSubmit(tb);
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Adding New Project Quantity",
                    Description = "Item ID " + tb.ItemID +
                     "\n Qty : " + tb.Qty +
                     "Project Profile ID" + tb.ProjectProfileID.ToString(),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser,
                    HistoryAction = "Adding New Project Quantity",

                });
                ProcessChange("Adding Project Quantity ", tb.ID + " has Been Saved ", null);
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Project Quantity", e.ToString());
                return false;
            }
        }

        public static bool EditProjectQuantity(ProjectQuantity tb)
        {
            try
            {
                var q = db.ProjectQuantities.Where(p => p.ID == tb.ID).Single();
                q.ItemID = tb.ItemID;
                q.Qty = tb.Qty;
                q.ProjectProfileID = tb.ProjectProfileID;
                q.SerialNumber = tb.SerialNumber;
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Edit Project Quantity",
                    Description = String.Format("old Info Is ID {0}\n Item ID : {1} Qty {2} Project Profile ID {3} \n ID {0}\n Item ID : {1} Qty {2} Project Profile ID {3}", q.ID, q.ItemID, q.Qty,q.ProjectProfileID, tb.ID, tb.ItemID, tb.Qty, tb.ProjectProfileID),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser
                });

                ProcessChange("Edit Project Quantity", tb.ID + " has Been Edited ", null);
                q = null;
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Edit Project Quantity", e.ToString());
                return false;
            }
        }

        public static bool DeleteProjectQuantity(int iD)
        {
            try
            {
                var q = db.ProjectQuantities.Where(p => p.ID == iD).Single();
                db.ProjectQuantities.DeleteOnSubmit(q);
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Delete Project Quantity",
                    Description = String.Format(" Info Is ID {0}\n Item ID : {1} Qty {2} Project Profile ID {3}", q.ID, q.ItemID, q.Qty, q.ProjectProfileID),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser
                });
                q = null;
                ProcessChange("Delete Project Quantity", q.ID + " has Been Deleted ", null);
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Delete Project Quantity", e.ToString());
                return false;
            }
        }

        public static List<ProjectQuantity> GetAll()
        {
            return db.ProjectQuantities.ToList();
        }

        public static ProjectQuantity GetByID(int xid)
        {
            ProjectQuantity tb = db.ProjectQuantities.Where(c => c.ID == xid).Single();
            return tb;
        }

        public static ProjectQuantity GetByPojectProfileID(int xid)
        {
            ProjectQuantity tb = db.ProjectQuantities.Where(c => c.ProjectProfileID == xid).Single();
            return tb;
        }
        public static ProjectQuantity GetByItemID(int xid)
        {
            ProjectQuantity tb = db.ProjectQuantities.Where(c => c.ItemID == xid).Single();
            return tb;
        }
    }
}
