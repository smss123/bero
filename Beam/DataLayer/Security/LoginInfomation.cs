using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Security
{
    public class LoginInfomation : BaseDatabase 
    {
        public static SystemUser CurrnetUser { get; set; }


        public static SystemUser  Login(string usr, string pass)
        {
            var q = db.SystemUsers .Where(p => p.UserName == usr && p.pwd == pass ).ToList();
            if (q.Count == 0 || q.Count == -1)
            {
                return null;
            }
            else
            {
                CurrnetUser = q;

                var htb = new History();
                htb.ActionName = "User LogIn";
                htb.DateOfProcess = DateTime.Now;
                htb.HistoryAction = "User LogIn ";
                htb.Description = string.Format("User : {0}  LogIn And Started Use The System Now", q[0].UserName);
                htb.UserID = q[0].ID;

                HistoryCommand.NewHistory(htb);
                return q[0];
            }
        }
    }
}
