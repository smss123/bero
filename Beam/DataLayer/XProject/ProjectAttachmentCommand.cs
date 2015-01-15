using DataLayer.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.XProject
{
    public class ProjectAttachmentCommand : BaseDatabase
    {

        public delegate void OnchangeCallBack(string processName, string Usermsg, string description);
        public static event OnchangeCallBack ProcessChange;
        public static bool NewProjectAttachment(ProjectAttachment tb)
        {
            try
            {

                db.ProjectAttachments.InsertOnSubmit(tb);
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Adding New Project Attachment",
                    Description = "Item ID " + tb.FileName +
                     "\n File Path : " + tb.FilePath +
                     "File Content : " + tb.FileContent +
                     "Project Profile ID : " + tb.ProjectProfileID.ToString(),
                    
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser,
                    HistoryAction = "Adding New Project Attachment",

                });
                ProcessChange("Adding Project Attachment ", tb.FileName + " has Been Saved ", null);
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Project Attachment", e.ToString());
                return false;
            }
        }

        public static bool EditProjectAttachment(ProjectAttachment tb)
        {
            try
            {
                var q = db.ProjectAttachments.Where(p => p.ID == tb.ID).Single();
                q.FileName = tb.FileName;
                q.FilePath = tb.FilePath;
                q.FileContent = tb.FileContent;
                q.ProjectProfileID = tb.ProjectProfileID;

             
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Edit Project Attachment",
                    Description = String.Format("old Info Is File Name {0}\n File Path : {1} File Content {2} Project ProfileID {3} \n New Info Is File Name {4}\n File Path : {5} File Content {6} Project ProfileID {7}", q.FileName, q.FilePath, q.FileContent, q.ProjectProfileID, tb.FileName, tb.FilePath, tb.FileContent, tb.ProjectProfileID),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser
                });

                ProcessChange("Edit Project Attachment", tb.FileName + " has Been Edited ", null);
                q = null;
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Edit Project Attachment", e.ToString());
                return false;
            }
        }

        public static bool DeleteProjectAttachment(int iD)
        {
            try
            {
                var q = db.ProjectAttachments.Where(p => int.Parse(p.ID.ToString()) == iD).Single();
                db.ProjectAttachments.DeleteOnSubmit(q);
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Delete Project Attachment",
                    Description = String.Format(" Info Is File Name {0}\n File Path : {1} File Content {2} Project ProfileID {3}", q.FileName, q.FilePath, q.FileContent, q.ProjectProfileID),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser
                });
                q = null;
                ProcessChange("Delete Project Attachment", q.FileName + " has Been Deleted ", null);
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Delete Project Attachment", e.ToString());
                return false;
            }
        }
        
        #region "^^^^ Get Data "
        public static List<ProjectAttachment> GetAll()
        {
            return db.ProjectAttachments.ToList();
        }

        public static ProjectAttachment GetByProjectProfileID(int ProjtID)
        {
            ProjectAttachment atb = db.ProjectAttachments.Where(a => a.ProjectProfileID == ProjtID).SingleOrDefault();
            return atb;
        }

        #endregion

    }
}
