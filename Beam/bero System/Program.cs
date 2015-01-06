using DataLayer;
using DataLayer.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace bero_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginInfomation.CurrnetUser = BaseDatabase.db.SystemUsers.SingleOrDefault();

            CommandManager.ini();
            Application.Run(new Form1());
        }
    }
}
