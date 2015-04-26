using DataLayer.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.XEmployees
{
   public  class EmployeesCmd
    {
        public delegate void OnchangeCallBack(string processName, string Usermsg, string description);
        public static event OnchangeCallBack ProcessChange;

        public  static   dbDataContext db = new dbDataContext(Properties.Settings.Default.xprema_beroConnectionString);
        public static bool NewEmployee(Employee tb)
        {
            db = new dbDataContext(Properties.Settings.Default.xprema_beroConnectionString);
            db.Employees.InsertOnSubmit(tb);
            db.SubmitChanges();
            HistoryCommand.NewHistory(new History()
            {
                ActionName = "Adding New Employee",
                Description = "User  Name " +  tb.EmployeeName  +
                 "   Created At " + DateTime.Now,
                DateOfProcess = DateTime.Now,
                SystemUser = LoginInfomation.CurrnetUser,
                HistoryAction = "Adding New Employee",

            });

            return true;
        }



        public static bool EditEmployee(Employee tb)
        {
            var q = db.Employees.Where(d => d.id == tb.id).SingleOrDefault();
            q.EmployeeName = tb.EmployeeName;
            q.nationalty = tb.nationalty;
            q.PassportNumber = tb.PassportNumber;
            q.PassportExpierdDate = tb.PassportExpierdDate;
            q.peronaltyNumber = tb.peronaltyNumber;
            q.Salary = tb.Salary;
            q.SerialNumber = tb.SerialNumber;
            q.Status = tb.Status;
            db.SubmitChanges();

            HistoryCommand.NewHistory(new History()
            {
                ActionName = "Edit Employee",
                Description = String.Format("old Info Is Employee Name {0}Created At {1}",
                q.EmployeeName , DateTime.Now),
                DateOfProcess = DateTime.Now,
                SystemUser = LoginInfomation.CurrnetUser
            });

            return true;


        }

        public static bool DeleteEmployee(int xid)
        {
         
            var q = db.Employees.Where(d => d.id == xid).SingleOrDefault();
            db.Employees.DeleteOnSubmit(q);
            db.SubmitChanges();
            HistoryCommand.NewHistory(new History()
            {
                ActionName = "Delete Employee",
                Description = String.Format("old Info Is Employee Name {0}Created At {1}",
                q.EmployeeName, DateTime.Now),
                DateOfProcess = DateTime.Now,
                SystemUser = LoginInfomation.CurrnetUser
            });

            return true;
         
        }

        public static List<Employee> GetAllEmployees()
        {
            return db.Employees.ToList();
        }

        public static Employee GetByID(int XID)
        {
            Employee tb = db.Employees.Where(d => d.id == XID).Single();
            return tb;
        }

        public static Employee GetByName(string EmpName)
        {
            Employee tb = db.Employees.Where(d =>  d.EmployeeName == EmpName ).Single();
            return tb;
        }

        public static Employee EditStatus(Employee emptb)
        {
            Employee tb = db.Employees.Where(d => d.id ==  emptb .id ).Single();
            tb.Status = emptb.Status;
            db.SubmitChanges();
            return tb;
        }
    }
}
