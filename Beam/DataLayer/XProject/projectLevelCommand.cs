using DataLayer.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.XProject
{
    public class projectLevelCommand : BaseDatabase
    {
                       
            public delegate void OnchangeCallBack(string processName, string Usermsg, string description);
            public static event OnchangeCallBack ProcessChange;
            public static bool NewprojectLevel(projectLevel tb)
            {
                //try
                //{

                    db.projectLevels.InsertOnSubmit(tb);
                    db.SubmitChanges();
                //    HistoryCommand.NewHistory(new History()
                //    {
                //        ActionName = "Adding New project Level",
                //        Description = "Level Name Name " + tb.LevelName +
                //         "\n Description : " + tb.Descripotion +
                //         "Level Amount  " + tb.LevelAmount +
                //          "Project Profile" + tb.ProjectProfileID.ToString(),
                //        DateOfProcess = DateTime.Now,
                //        SystemUser = LoginInfomation.CurrnetUser,
                //        HistoryAction = "Adding New Pproject Level",

                //    });
                //    ProcessChange("Addingproject Level", tb.LevelName + " has Been Saved ", null);
                   return true;
                //}
                //catch (Exception e)
                //{

                //    ProcessChange("Error message", "Can't project Level", e.ToString());
                //    return false;
                //}
            }
            private static bool WriteHistory(History htb)
            {
                db.Histories.InsertOnSubmit(htb);
                db.SubmitChanges();
                return true;
            }
            public static bool EditprojectLevel(projectLevel tb)
            {
                //try
                //{
                    var q = db.projectLevels.Where(p => p.id == tb.id).Single();
                    q.LevelName = tb.LevelName;
                    q.Descripotion = tb.Descripotion;
                    q.ProjectProfileID = tb.ProjectProfileID;
                    q.LevelAmount = tb.LevelAmount;
                    q.SerialNumber = tb.SerialNumber;
                    db.SubmitChanges();

                    //HistoryCommand.NewHistory(new History()
                    //{
                    History htb = new History()
                    {
                        ActionName = "Edit project Level",
                        Description = String.Format("old Info Is Level Name {0}\n Project Description : {1}Project Profile {2} Level Amount {3} \n New Info is Level Name {4}\n Project Description : {5}Project Profile {6} Level Amount {7}", q.LevelName, q.Descripotion, q.LevelAmount, tb.LevelName, tb.Descripotion, tb.ProjectProfile.ProjectName, tb.LevelAmount),
                        DateOfProcess = DateTime.Now,
                        SystemUser = LoginInfomation.CurrnetUser
                    };
                    WriteHistory(htb);
                    //});

                   // ProcessChange("Edit project Level", tb.LevelName + " has Been Edited ", null);
                  q = null;
                    return true;
                //}
                //catch (Exception e)
                //{

                //    ProcessChange("Error message", "Can't Edit project Level", e.ToString());
                //    return false;
                //}
            }
           
            public static bool DeleteprojectLevel(int iD)
            {
                //try
                //{
                    var q = db.projectLevels.Where(p => p.id == iD).Single();
                    db.projectLevels.DeleteOnSubmit(q);
                    db.SubmitChanges();
                    //HistoryCommand.NewHistory(new History()
                    //{
                    History htb = new History()
                    {
                        ActionName = "Edit project Level",
                        Description = String.Format(" Info Is Level Name {0}\n Project Description : {1}Project Profile {2} Level Amount {3}", q.LevelName, q.Descripotion, q.ProjectProfile.ProjectName, q.LevelAmount),
                        DateOfProcess = DateTime.Now,
                        SystemUser = LoginInfomation.CurrnetUser
                    };
                    WriteHistory(htb);
                   // });;
                    q = null;
                   // ProcessChange("Delete Project Level", q.LevelName + " has Been Deleted ", null);
                    return true;
                //}
                //catch (Exception e)
                //{

                //    ProcessChange("Error message", "Can't Delete Project Level", e.ToString());
                //    return false;
              //  }
            }

            public static List<projectLevel> GetAll()
            {
                return db.projectLevels.ToList();
            }

            public static List<projectLevel> GetByProjectProfileID(int XID)
            {
                var lst = db.projectLevels.Where(i => i.ProjectProfileID == XID).ToList();
                return lst;
            }

        
    }
}