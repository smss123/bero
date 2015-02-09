using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.XCustomer;
using System.Windows.Forms;
using DataLayer.XProject;
using DataLayer.XAccountant;
namespace bero_System
{
    public class CommandManager
    {
     
        public static void ini()
        {
            CustomerCommand.ProcessChange += CustomerCommand_ProcessChange;
            ProjectProfileCommand.ProcessChange += ProjectProfileCommand_ProcessChange;
            DataLayer.Security.HistoryCommand.ProcessChange += HistoryCommand_ProcessChange;
            ExpenssesMovmentCommand.ProcessChange += ExpenssesMovmentCommand_ProcessChange;
        }

        static void ExpenssesMovmentCommand_ProcessChange(string processName, string Usermsg, string description)
        {
            MessageBox.Show(processName, string.Format("{0}\n{1}", Usermsg, description));
        }

        static void ProjectProfileCommand_ProcessChange(string processName, string Usermsg, string description)
        {
            MessageBox.Show(processName, string.Format("{0}\n{1}", Usermsg, description));
        }

        static void HistoryCommand_ProcessChange(string processName, string Usermsg, string description)
        {
         // MessageBox.Show(processName, string.Format("{0}\n{1}", Usermsg, description));

        }

        static void CustomerCommand_ProcessChange(string processName, string usermsg, string description)
        {
            if (description==null)
            {
                MessageBox.Show(usermsg, processName);
            }
           
        }
    }
}
