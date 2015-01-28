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

            HistoryCommand.NewHistory(new History()
            {
                ActionName = "Adding New User",
                Description = "User  Name " + usr .UserName  +
                 "   Created At " + DateTime .Now ,
                DateOfProcess = DateTime.Now,
                SystemUser = LoginInfomation.CurrnetUser,
                HistoryAction = "Adding New User",

            });

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

                HistoryCommand.NewHistory(new History()
                {
                    ActionName = "Edit User",
                    Description = String.Format("old Info Is User Name {0}Created At {1}",
                    q.UserName , DateTime .Now ),
                    DateOfProcess = DateTime.Now,
                    SystemUser = LoginInfomation.CurrnetUser
                });

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

                    HistoryCommand.NewHistory(new History()
                    {
                        ActionName = "Delete  User",
                        Description = String.Format("old Info Is User Name {0}Created At {1}",
                        q.UserName, DateTime.Now),
                        DateOfProcess = DateTime.Now,
                        SystemUser = LoginInfomation.CurrnetUser
                    });

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


        public static SystemUser GetByName(string UsrName)
        {
            SystemUser usr = db.SystemUsers.Where(u => u.UserName == UsrName).SingleOrDefault();
            return usr;
        }

        public static bool ChangePassword(SystemUser usr)
        {
            try
            {
                var q = db.SystemUsers.Where(u => u.ID == usr.ID).SingleOrDefault();
                if (q.ID != 0)
                {
                 
                    q.pwd = usr.pwd;

                    db.SubmitChanges();

                    HistoryCommand.NewHistory(new History()
                    {
                        ActionName = "Change User's password",
                        Description = String.Format("His Is  Name is {0}Created At {1}",
                        q.UserName, DateTime.Now),
                        DateOfProcess = DateTime.Now,
                        SystemUser = LoginInfomation.CurrnetUser
                    });

                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
