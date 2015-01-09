using DataLayer.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.XProject
{
   public class ProjectProfileCommand:BaseDatabase
    {

        public delegate void OnchangeCallBack(string processName, string Usermsg, string description);
        public static event OnchangeCallBack ProcessChange;
        public static bool NewProject(ProjectProfile Pro)
        {
            try
            {

                db.ProjectProfiles.InsertOnSubmit(Pro);
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Adding New Project Profile",
                    Description = "ProjectProfile Name " + Pro.ProjectName +
                     "\n Description : " + Pro.ProjectDescription +
                     "Created At " + Pro.createdDate.ToString()+
                     "Deliver Date"+Pro.DeliverDate.ToString()+
                     "Project Full Amount"+Pro.ProjectFullAmount.ToString()+
                     "Customer"+Pro.CustomerID.ToString(),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser,
                    HistoryAction = "Adding New Project Profile",

                });
                ProcessChange("Adding Project Profile", Pro.ProjectName + " has Been Saved ", null);
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Project Profile", e.ToString());
                return false;
            }
        }

        public static bool EditProject(ProjectProfile pro)
        {
            try
            {
                var q = db.ProjectProfiles.Where(p => p.ID == pro.ID).Single();
                q.ProjectName = pro.ProjectName;
                q.ProjectDescription = pro.ProjectDescription;
                q.createdDate = pro.createdDate;
                q.DeliverDate = pro.DeliverDate;
                q.ProjectFullAmount = pro.ProjectFullAmount;
                q.CustomerID = pro.CustomerID;
                q.SerialNumber = pro.SerialNumber;
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Edit ProjectProfile",
                    Description = String.Format("old Info Is ProjectProfile Name {0}\n Project Description : {1}Created At {2} Deliver Date {3} Project Full Amount {4} \n New Info is ProjectProfile Name {5}\n  Project Description : {6}Created At {7} Deliver Date {8} Project Full Amount {9}", q.ProjectName, q.ProjectDescription, q.createdDate,q.DeliverDate,q.ProjectFullAmount, pro.ProjectName, pro.ProjectDescription, pro.createdDate,pro.DeliverDate,pro.ProjectFullAmount),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser
                });

                ProcessChange("Edit ProjectProfile", pro.ProjectName + " has Been Edited ", null);
                q = null;
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Edit ProjectProfile", e.ToString());
                return false;
            }
        }

        public static bool DeleteProject(int iD)
        {
            try
            {
                var q = db.ProjectProfiles.Where(p => p.ID == iD).Single();
                db.ProjectProfiles.DeleteOnSubmit(q);
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Delete Project Profile",
                    Description = String.Format("old Info Is ProjectProfile Name {0}\n Project Description : {1}Created At {2} Deliver Date {3} Project Full Amount {4} \n", q.ProjectName, q.ProjectDescription, q.createdDate, q.DeliverDate, q.ProjectFullAmount),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser
                });
                q = null;
                ProcessChange("Delete Project Profile", q.ProjectName + " has Been Deleted ", null);
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Delete Project Profile", e.ToString());
                return false;
            }
        }

        public static List<ProjectProfile> GetAll()
        {
            return db.ProjectProfiles.ToList();
        }

    }
}
