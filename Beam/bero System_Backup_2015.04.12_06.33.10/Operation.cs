using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bero_System
{
   public class Operation
   {


       #region "       Form Controler          "
       public static void ShowToustOk(string msg, Control frm)
       {
           ToastNotification.Show(frm, msg, null, 1000, eToastGlowColor.Green, eToastPosition.MiddleCenter);
       }

       public static void BeginOperation(Control frm)
       {
           frm.Invoke((MethodInvoker)delegate {

               frm.Enabled = false;
               frm.Cursor = Cursors.WaitCursor;
           
           });
       }

       public static void EndOperation(Control frm)
       {
           frm.Invoke((MethodInvoker)delegate
           {

               frm.Enabled = true;
               frm.Cursor = Cursors.Default;

           });
       }


       #endregion 



       #region "   ^^^ Check End Of Month  For Expire Projects   "
       public static bool IsEndOfMonth()
       {
           int day = DateTime.Now.Day;
           bool status = false;
           if (day == DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month))
           {
               status = true;
           }
           return status;
       }

        #endregion
    }
}
