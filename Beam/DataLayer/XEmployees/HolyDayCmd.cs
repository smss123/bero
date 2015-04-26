using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.XEmployees
{
   public  class HolyDayCmd
    {
        public delegate void OnchangeCallBack(string processName, string Usermsg, string description);
        public static event OnchangeCallBack ProcessChange;

        public static dbDataContext db = new dbDataContext(Properties.Settings.Default.xprema_beroConnectionString);
        public static bool NewHolyDay(HolyDay HolyTb)
        {
            db = new dbDataContext(Properties.Settings.Default.xprema_beroConnectionString);
            db.HolyDays.InsertOnSubmit(HolyTb);
            db.SubmitChanges();
            return true;
        }

        public static bool EditHolyDay(HolyDay HolyTb)
        {
            db = new dbDataContext(Properties.Settings.Default.xprema_beroConnectionString);

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
            var q = db.HolyDays.Where(d => d.ID == xid ).Single();
            db.HolyDays.DeleteOnSubmit(q);
            db.SubmitChanges();
            return true;
        }


        public static List<HolyDay> GetAllHolyDays()
        {
            return db.HolyDays.ToList();
        }

        public static List<HolyDay > GetByEmployeeID(int EmpID){

            var  q = db.HolyDays.Where(d => d.EmployeeID == EmpID).ToList();

            return q;
        }


       /// <summary>
       /// 
       /// </summary>
       /// <param name="empid">Insert Employee Id</param>
       /// <param name="_fromDate">Insert Start Date</param>
       /// <param name="_toDate">Insert End Date  </param>
       /// <returns></returns>
        public static List<HolyDay> GetHolydaysBetween2Days(int empid, DateTime _fromDate, DateTime _toDate)
        {
            List<HolyDay> GetData = (from h in db.HolyDays
                                     where h.EmployeeID == empid
                                         && h.fromDate.Value.Year >= _fromDate.Year
                                         && h.fromDate.Value.Month >= _fromDate.Month
                                         && h.fromDate.Value.Day >= _fromDate.Day
                                         && h.ToDatetime .Value .Year <= _toDate .Year 
                                         && h.ToDatetime .Value .Month <= _toDate .Month 
                                         && h.ToDatetime .Value .Day <= _toDate .Day 
                                     select h).ToList();               
            return GetData ;
        }

        public static List<HolyDay> GetHolydaysBetween2Days( DateTime _fromDate, DateTime _toDate)
        {
            List<HolyDay> GetData = (from h in db.HolyDays
                                     where
                                         h.fromDate.Value.Year >= _fromDate.Year
                                         && h.fromDate.Value.Month >= _fromDate.Month
                                         && h.fromDate.Value.Day >= _fromDate.Day
                                         && h.ToDatetime.Value.Year <= _toDate.Year
                                         && h.ToDatetime.Value.Month <= _toDate.Month
                                         && h.ToDatetime.Value.Day <= _toDate.Day
                                     select h).ToList();
            return GetData;
        }
    }
}
