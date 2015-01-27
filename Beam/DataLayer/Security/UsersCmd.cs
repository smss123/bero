using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Security
{
    public   class UsersCmd : BaseDatabase 
    {
       
        public static bool NewUser(SystemUser usr)
        {
            db.SystemUsers.InsertOnSubmit(usr);
            db.SubmitChanges();
            return true;
        }

        public static bool EditUser(SystemUser usr)
        {
            try
            {
                       var q = db.SystemUsers.Where(u => u.ID == usr.ID).SingleOrDefault();
                        if (q.ID != 0)
                        {
                            q.UserName = usr.UserName;
                            q.pwd = usr.pwd;
                        
                            db.SubmitChanges();
                            return true;
                        }
                        return false;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static bool DeleteUser( int UsrID)
        {
            try
            {
                var q = db.SystemUsers.Where(u => u.ID ==  UsrID ).SingleOrDefault();
                if (q.ID != 0)
                {
                    db.SystemUsers.DeleteOnSubmit(q);

                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public static List<SystemUser> GetAllUsers()
        {
            return db.SystemUsers.ToList();
        }

    }
}
