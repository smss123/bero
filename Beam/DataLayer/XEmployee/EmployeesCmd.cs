using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.XEmployees
{
    public class EmployeesCmd
    {
        public delegate void OnchangeCallBack(string processName, string Usermsg, string description);
        public static event OnchangeCallBack ProcessChange;

        public static dbDataContext db = new dbDataContext();
        public static bool NewEmployee(Employee tb)
        {
            db.Employees.InsertOnSubmit(tb);
            db.SubmitChanges();
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
            return true;


        }

        public static bool DeleteEmployee(int xid)
        {

            var q = db.Employees.Where(d => d.id == xid).SingleOrDefault();
            db.Employees.DeleteOnSubmit(q);
            db.SubmitChanges();
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
    }
}
