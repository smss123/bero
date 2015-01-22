using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.XEmployees
{
    public class HolyDayCmd
    {
        public delegate void OnchangeCallBack(string processName, string Usermsg, string description);
        public static event OnchangeCallBack ProcessChange;

        public static dbDataContext db = new dbDataContext();
        public static bool NewHolyDay(HolyDay HolyTb)
        {
            db.HolyDays.InsertOnSubmit(HolyTb);
            return true;
        }

        public static bool EditHolyDay(HolyDay HolyTb)
        {
            var q = db.HolyDays.Where(d => d.ID == HolyTb.ID).Single();
            q.fromDate = HolyTb.fromDate;
            q.ToDatetime = HolyTb.ToDatetime;
            q.EmployeeID = HolyTb.EmployeeID;
            q.commint = HolyTb.commint;
            q.status = HolyTb.status;
            q.SerialNumber = HolyTb.SerialNumber;
            db.SubmitChanges();
            return true;
        }

        public static bool DeleteHolyDay(int xid)
        {
            var q = db.HolyDays.Where(d => d.ID == xid).Single();
            db.HolyDays.DeleteOnSubmit(q);
            db.SubmitChanges();
            return true;
        }


        public static List<HolyDay> GetAllHolyDays()
        {
            return db.HolyDays.ToList();
        }

        public static List<HolyDay> GetByEmployeeID(int EmpID)
        {

            var q = db.HolyDays.Where(d => d.EmployeeID == EmpID).ToList();

            return q;
        }
    }
}
