using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Security
{
    public class PermessionsCmd : BaseDatabase
    {
      
        public static bool AddAllSystemPermessions(SystemPermession tb)
        {
            db.SystemPermessions.InsertOnSubmit(tb);
            db.SubmitChanges();
          
            return true;
        }

        public static List<SystemPermession> GetAllSystemPermession()
        {
           
            var q = db.SystemPermessions.ToList();
            return q;
        }

        public static bool AddUserPermessions(UserPermession tb)
        {
          
            db.UserPermessions.InsertOnSubmit(tb);
            db.SubmitChanges();

         
            return true;
        }

        public static bool EditPermessionValue(UserPermession u, int xxUserID)
        {
            var q = db.UserPermessions.Where(p => p.ID == u.ID && p.SystemUserID == xxUserID).SingleOrDefault();

            if (q != null)
            {
                q.SystemPermessionID = u.SystemPermessionID;
                q.PermessionValue = u.PermessionValue;
                q.SystemUserID = u.SystemUserID;
                db.SubmitChanges();

                return true;
            }
            return false;
        }

        public static List<UserPermession> LoadingPermissonsOfCurrentUser()
        {

            var LST = (from u in db.UserPermessions
                       where u.SystemUserID ==  LoginInfomation .CurrnetUser .ID 
                       select u).ToList();
            return LST;
        }

        public static List<UserPermession> GetAllUserPermissonsByUserID(int UsrID)
        {
          
            var LST = (from u in db.UserPermessions
                       where u.SystemUserID == UsrID
                       select u).ToList();
            return LST;
        }

        public static bool ClearAllUserPermessions(int usrid)
        {
            db = new dbDataContext(Properties.Settings.Default.xprema_beroConnectionString);
            var tb = new UserPermession();
            var lst = (from u in db.UserPermessions
                       where u.SystemUserID == usrid
                       select u).ToList();

            var iDes = new List<int>();
            iDes.Clear();
            foreach (var i in lst)
            {
                iDes.Add(i.ID);
            }
            foreach (var item in iDes)
            {
                tb = db.UserPermessions.Where(x => x.ID == item).Single();
                db.UserPermessions.DeleteOnSubmit(tb);
                db.SubmitChanges();
            }

            return true;
        }
    }
}
