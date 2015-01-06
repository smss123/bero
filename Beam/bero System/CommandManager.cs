using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.XCustomer;
using System.Windows.Forms;
namespace bero_System
{
    public class CommandManager
    {
     
        public static void ini()
        {
            CustomerCommand.ProcessChange += CustomerCommand_ProcessChange;
            DataLayer.Security.HistoryCommand.ProcessChange += HistoryCommand_ProcessChange;
        }

        static void HistoryCommand_ProcessChange(string processName, string Usermsg, string description)
        {
            MessageBox.Show(processName, Usermsg + "\n" + description);

        }

        static void CustomerCommand_ProcessChange(string processName, string Usermsg, string description)
        {
            if (description==null)
            {
                MessageBox.Show(Usermsg, processName);
            }
           
        }
    }
}
