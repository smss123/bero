using DataLayer.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.XProject
{
     public  class ProjectInstallmentCommand :BaseDatabase
    {

        public delegate void OnchangeCallBack(string processName, string Usermsg, string description);
        public static event OnchangeCallBack ProcessChange;
        public static bool NewProjectInstallment(ProjectInstallment tb)
        {
            try
            {

                db.ProjectInstallments.InsertOnSubmit(tb);
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Adding New Project Installment",
                    Description = "Installments name " + tb.Installments_name +
                     "\n Amount : " + tb.Amount +
                     "Date Of Installments" + tb.DateOfInstallments.ToString() +
                     "Project Level ID" + tb.ProjectLevelID +
                     "Active Status" + tb.ActiveStatus +
                     "PayBy"+tb.PayBy+
                     "Pa yDescription" + tb.PayDescription +
                     "ProjectLevelID" + tb.ProjectLevelID,
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser,
                    HistoryAction = "Adding New Project Installment",

                });
                ProcessChange("Adding Project Installment", tb.Installments_name + " has Been Saved ", null);
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Project Installment", e.ToString());
                return false;
            }
        }

        public static bool EditProjectInstallment(ProjectInstallment tb)
        {
            try
            {
                var q = db.ProjectInstallments.Where(p => p.id == tb.id).Single();
                q.Installments_name = tb.Installments_name;
                q.Amount = tb.Amount;
                q.DateOfInstallments = tb.DateOfInstallments;
                q.ActiveStatus = tb.ActiveStatus;
                q.PayBy = tb.PayBy;
                q.PayDescription = tb.PayDescription;
                q.ProjectLevelID = tb.ProjectLevelID;
                q.SerialNumber = tb.SerialNumber;
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Edit Project Installment",
                    Description = String.Format("old Info Is Installments name {0}\n Amount : {1} Date Of Installments {2} Status {3} Pay By {4}  Pay Description {5} Active Status {6} ProjectLevelID {7} \n New Info is Installments name {8}\n Amount : {9} Date Of Installments {10} Status {11} Pay Bay  {12}  Pay Description {13} Active Status {14} ProjectLevelID {15}", q.Installments_name, q.Amount, q.DateOfInstallments, q.ActiveStatus, q.PayBy, q.PayDescription, q.ProjectLevelID, tb.Installments_name, tb.Amount, tb.DateOfInstallments,tb.ActiveStatus, tb.PayBy, tb.PayDescription, tb.ProjectLevelID),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser
                });

                ProcessChange("Edit Project Installment", tb.Installments_name + " has Been Edited ", null);
                q = null;
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't EditProject Installment", e.ToString());
                return false;
            }
        }

        public static bool DeleteprojectLevelSell(int iD)
        {
            try
            {
                var q = db.ProjectInstallments.Where(p => p.id == iD).Single();
                db.ProjectInstallments.DeleteOnSubmit(q);
                db.SubmitChanges();
                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Delete Project Installment",
                    Description = String.Format(" Info Is Installments name {0}\n Amount : {1} Date Of Installments {2} Status {3} pay Bay {4}  Pay Description {5} Active Status {6} ProjectLevelID {7}", q.Installments_name, q.Amount, q.DateOfInstallments, q.ActiveStatus, q.PayBy, q.PayDescription, q.ProjectLevelID),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser
                });
                q = null;
                ProcessChange("Delete Project Installment", q.Installments_name + " has Been Deleted ", null);
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error message", "Can't Delete Project Installment", e.ToString());
                return false;
            }
        }

        public static List<ProjectInstallment> GetAll()
        {
            return db.ProjectInstallments.ToList();
        }


    }
}
