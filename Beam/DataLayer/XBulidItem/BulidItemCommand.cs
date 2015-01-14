using DataLayer.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.XBulidItem
{
    public class BulidItemCommand:BaseDatabase
    {
        public delegate void OnchangeCallBack(string processName, string Usermsg, string description);
        public static event OnchangeCallBack ProcessChange;
        public static bool NewBulidItem(BulidItem tb)
        {
            try
            {

                db.BulidItems.InsertOnSubmit(tb);
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Adding New Bulid Item",
                    Description = "Item Name " + tb.ItemName +
                    "\n Item Description : " + tb.ItemDescription+
                    "Item Summery : " + tb.ItemSummery,
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser,
                    HistoryAction = "Adding New Bulid Item",

                });
                ProcessChange("Adding Bulid Item ", tb.ItemName + " has Been Saved ", null);
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Bulid Item", e.ToString());
                return false;
            }
        }

        public static bool EditBulidItem(BulidItem tb)
        {
            try
            {
                var q = db.BulidItems.Where(p => p.ID == tb.ID).Single();
                q.ItemName = tb.ItemName;
                q.ItemDescription = tb.ItemDescription;
                q.ItemSummery = tb.ItemSummery;
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Edit Bulid Item",
                    Description = String.Format("old Info Is Item Name {0}\n Item Description : {1} Item Summery {2} \n New Info Is Expensses Name {4}\n Description : {4} Item Summery {5}", q.ItemName, q.ItemDescription, q.ItemSummery, tb.ItemName, tb.ItemDescription, tb.ItemSummery),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser
                });

                ProcessChange("Edit Bulid Item", tb.ItemName + " has Been Edited ", null);
                q = null;
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Edit Bulid Item", e.ToString());
                return false;
            }
        }

        public static bool DeleteBulidItem(int iD)
        {
            try
            {
                var q = db.BulidItems.Where(p => int.Parse(p.ID.ToString()) == iD).Single();
                db.BulidItems.DeleteOnSubmit(q);
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Delete Bulid Item",
                    Description = String.Format("Info Is Item Name {0}\n Item Description : {1} Item Summery {2}", q.ItemName, q.ItemDescription, q.ItemSummery),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser
                });
                q = null;
                ProcessChange("Delete Bulid Item", q.ItemName + " has Been Deleted ", null);
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Delete Bulid Item", e.ToString());
                return false;
            }
        }

        #region "^^^ Searching Data"

        public static List<BulidItem> GetAll()
        {
            return db.BulidItems.ToList();
        }

        public static BulidItem GetBuildItemByID(int xid)
        {

            BulidItem tb = db.BulidItems.Where(b => b.ID == xid).Single();
            return tb;
        }

        public static BulidItem GetBuildItemByItemName(string ItmName)
        {

            BulidItem tb = db.BulidItems.Where(b => b.ItemName == ItmName ).Single();
            return tb;
        }
        #endregion 

    }
}
