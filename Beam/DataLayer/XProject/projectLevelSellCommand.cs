using DataLayer.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.XProject
{
    public class projectLevelSellCommand : BaseDatabase
    {
        public delegate void OnchangeCallBack(string processName, string Usermsg, string description);
        public static event OnchangeCallBack ProcessChange;
        public static bool NewprojectLevelSell(projectLevelSell tb)
        {
            try
            {

                db.projectLevelSells.InsertOnSubmit(tb);
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Adding New project Level Sell",
                    Description = "Sell Item " + tb.Sell_Item +
                     "\n Amount : " + tb.Amount +
                     "Date Of Sell" + tb.DateOfSell.ToString() +
                     "Description" + tb.Description+
                     "Status" + tb.Status+
                     "ProjectLevelID" + tb.ProjectLevelID,
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser,
                    HistoryAction = "Adding New roject Level Sell",

                });
                ProcessChange("Adding project Level Sell", tb.Sell_Item + " has Been Saved ", null);
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't project Level Sell", e.ToString());
                return false;
            }
        }

        public static bool EditprojectLevelSell(projectLevelSell tb)
        {
            try
            {
                var q = db.projectLevelSells.Where(p => p.ID == tb.ID).Single();
                q.Sell_Item = tb.Sell_Item;
                q.Amount = tb.Amount;
                q.DateOfSell = tb.DateOfSell;
                q.Description = tb.Description;
                q.Status = tb.Status;
                q.ProjectLevelID = tb.ProjectLevelID;
                q.SerialNumber = tb.SerialNumber;
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Edit project Level Sell",
                    Description = String.Format("old Info Is Sell Item {0}\n Amount : {1}Date Of Sell {2} Description {3} Status {4}  Project Level {5} \n New Info is Sell Item {6}\n Amount : {7}Date Of Sell {8} Description {9} Status {10}  Project Level {11}", q.Sell_Item, q.Amount, q.DateOfSell, q.Description, q.Status,q.projectLevel.LevelName, tb.Sell_Item, tb.Amount, tb.DateOfSell, tb.Description, tb.Status,tb.projectLevel.LevelName),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser
                });

                ProcessChange("Edit project Level Sell", tb.Sell_Item + " has Been Edited ", null);
                q = null;
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Edit project Level Sell", e.ToString());
                return false;
            }
        }

        public static bool DeleteprojectLevelSell(int iD)
        {
            try
            {
                var q = db.projectLevelSells.Where(p => p.ID == iD).Single();
                db.projectLevelSells.DeleteOnSubmit(q);
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Delete project Level Sell",
                    Description = String.Format(" Info Is Sell Item {0}\n Amount : {1}Date Of Sell {2} Description {3} Status {4}  Project Level {5}", q.Sell_Item, q.Amount, q.DateOfSell, q.Description, q.Status, q.projectLevel.LevelName),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser
                });
                q = null;
                ProcessChange("Delete project Level Sell", q.Sell_Item + " has Been Deleted ", null);
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Delete project Level Sell", e.ToString());
                return false;
            }
        }

        #region " ^^^ Searching Data"

        public static List<projectLevelSell> GetAll()
        {
            return db.projectLevelSells.ToList();
        }

        public static projectLevelSell GetByProjectLevelID(int  PrjLevelId)
        {
            projectLevelSell stb = db.projectLevelSells.Where(c => c.ProjectLevelID == PrjLevelId).SingleOrDefault();
            return stb;
        }


        public static List<projectLevelSell > GetAllByProjectId(int TargetProjectID)
        {
            var GetAllLevelsByProjectId = projectLevelCommand.GetByProjectProfileID(TargetProjectID);

            List<projectLevelSell> LstSelles = new List<projectLevelSell>();

            projectLevelSell tb = new projectLevelSell();

            foreach (var item in GetAllLevelsByProjectId)
            {
                tb = new projectLevelSell();
                tb = (from i in db.projectLevelSells 
                      where i.ProjectLevelID == item.id
                      select i).SingleOrDefault();

                LstSelles.Add(tb);
            }
            return LstSelles;
        }

        #endregion
    }
}
