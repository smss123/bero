using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Security
{
    public class HistoryCommand:BaseDatabase
    {
        public delegate void OnchangeCallBack(string processName, string Usermsg, string description);
        public static event OnchangeCallBack ProcessChange;

        public static bool NewHistory(History his)
        {
            try
            {
                db = new dbDataContext(Properties.Settings.Default.xprema_beroConnectionString);
                db.Histories.InsertOnSubmit(his);
                db.SubmitChanges();
                ProcessChange("Adding History", string.Format("{0} has {1}", his.SystemUser.UserName, his.ActionName), his.Description);
                return true;
            }
            catch (Exception e)
            {

                ProcessChange("Error History", "Error in Record History", his.Description);
                return false;
            }
        }

   
     

        public static List<History> GetAll()
        {
            return db.Histories.ToList();
        }
    }
}
