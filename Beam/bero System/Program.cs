
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net.Mail;
using DataLayer;
using DataLayer.Security;

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
            Application.ThreadException += Application_ThreadException;
            Application.Run(new Form1());
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            RadMessageBox.Show("Oops , Same error here,\n" + e.Exception.ToString(), "error");

            var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                            Screen.PrimaryScreen.Bounds.Height,
                            PixelFormat.Format32bppArgb);

            // Create a graphics object from the bitmap.
            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);

            // Take the screenshot from the upper left corner to the right bottom corner.
            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                        Screen.PrimaryScreen.Bounds.Y,
                                        0,
                                        0,
                                        Screen.PrimaryScreen.Bounds.Size,
                                        CopyPixelOperation.SourceCopy);


            // Save the screenshot to the specified path that the user has chosen.
            bmpScreenshot.Save("Screenshot.png", ImageFormat.Png);
            Application.DoEvents();
            MailMessage mail = new MailMessage();
            SmtpClient smtpServer = new SmtpClient("smtp.xprema.net");
            mail.From = new MailAddress("support@xprema.net");
            mail.To.Add("support@xprema.net");
            mail.Subject = "Exception from System " + Application.ProductName;
            mail.Body = string.Format("Exption is \n{0}\n----------------------------------------------------------------\n{1}", e.Exception.ToString(), "");

            System.Net.Mail.Attachment attachment = new System.Net.Mail.Attachment("Screenshot.png");
            mail.Attachments.Add(attachment);

            smtpServer.Port = 587;
            smtpServer.Credentials = new System.Net.NetworkCredential("support@xprema.net", "1234");
            smtpServer.EnableSsl = false;

            smtpServer.Send(mail);

        }
    }
}
