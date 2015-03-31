using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DataLayer.Security
{
    public class LoginInfomation : BaseDatabase 
    {
        public static SystemUser CurrnetUser { get; set; }


        public static SystemUser  Login(string usr, string pass)
        {
            try
            {
            SystemUser q = db.SystemUsers.Where(p => p.UserName == usr && p.pwd == pass).Single ();
            if (q.UserName.StartsWith(usr) && q.pwd.StartsWith(pass))
            {
                CurrnetUser = q;

                var htb = new History();
                htb.ActionName = "User LogIn";
                htb.DateOfProcess = DateTime.Now;
                htb.HistoryAction = "User LogIn ";
                htb.Description = string.Format("User : {0}  LogIn And Started Use The System Now", q.UserName);
                htb.UserID = q.ID;

                HistoryCommand.NewHistory(htb);
                return q;
            }
                          
            return null;
            }
            catch (Exception)
            {
          
                  return null;
            }
        }
    }
}
