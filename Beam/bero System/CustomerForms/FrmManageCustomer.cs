using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using DataLayer.XCustomer;
using DataLayer;
using System.Threading;
using Telerik.WinControls;
using System.Net.Mail;
namespace bero_System.CustomerForms
{
    public partial class FrmManageCustomer : RadForm
    {
        public FrmManageCustomer()
        {
            InitializeComponent();
        }
        #region "^^^^ Populate Grid"
       public  void PopulateDgv()
        {
            var LstCustomers= CustomerCommand.GetAll();
            this.Invoke((MethodInvoker)delegate { BulidItemGridView.DataSource = LstCustomers; });
           
        }

        #endregion 

        private void FrmManageCustomer_Load(object sender, EventArgs e)
        {
            Thread CustomersThread = new Thread(PopulateDgv);
            CustomersThread.Start();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            FrmAddCustomer frm = new FrmAddCustomer();
            frm.ShowDialog();
           
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            FrmManageCustomer_Load(sender, e);
        }

        private void BulidItemGridView_CommandCellClick(object sender, EventArgs e)
        {
            var col = BulidItemGridView.CurrentColumn.Index;
            if (col == 4)
            {
               
                Operation.BeginOperation(this);
                FrmEditCustomer frm = new FrmEditCustomer();

                Customer tb = (Customer)BulidItemGridView.CurrentRow.DataBoundItem;
                frm.TargetRecord = tb;

                frm.ShowDialog();
                Operation.EndOperation(this);
            }
            if (col == 5)
            {

                Operation.BeginOperation(this);
                 RadMessageBox.ThemeName = this.ThemeName;
                 if (RadMessageBox.Show("هل تريد حذف العميل؟", "", MessageBoxButtons.YesNo, RadMessageIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                 {
                     try
                     {
                         CustomerCommand.DeleteCustomer(int.Parse(BulidItemGridView.CurrentRow.Cells[0].Value.ToString()));
                         FrmManageCustomer_Load(sender, e);
                     }
                     catch (Exception ex)
                     {
                         if (ex.Message.Contains("This is not supported"))
                         {
                             RadMessageBox.Show("لا يمكن حذف العميل لانه مرتبط ببعض العمليات في النظام");
                         }
                         if (ex.Message.Contains("he DELETE statement conflicted with the REFERENCE constraint"))
                         {
                             RadMessageBox.Show("لا يمكن حذف العميل لانه مرتبط ببعض العمليات في النظام");


                         }
                     }
                     
                 }
                Operation.EndOperation(this);
            }
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            foreach (GridViewRowInfo item in BulidItemGridView.Rows )
            {
                var q = item.Cells[7].Value;


                if ( q!=null && bool.Parse(q.ToString()))
                {
                    if (item.Cells[6].Value != null)
                    {
                        SendEmail(item.Cells[6].Value.ToString());
                    }

                }
            }


            //RadMessageBox.Show("Oops , Same error here,\n" + e.Exception.ToString(), "error");

            //var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
            //                Screen.PrimaryScreen.Bounds.Height,
            //                PixelFormat.Format32bppArgb);

            //// Create a graphics object from the bitmap.
            //var gfxScreenshot = Graphics.FromImage(bmpScreenshot);

            //// Take the screenshot from the upper left corner to the right bottom corner.
            //gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
            //                            Screen.PrimaryScreen.Bounds.Y,
            //                            0,
            //                            0,
            //                            Screen.PrimaryScreen.Bounds.Size,
            //                            CopyPixelOperation.SourceCopy);


            //// Save the screenshot to the specified path that the user has chosen.
            //bmpScreenshot.Save("Screenshot.png", ImageFormat.Png);
            //Application.DoEvents();
            
            RadMessageBox.ThemeName = this.ThemeName;
            RadMessageBox.Show("تم ارسال الايميلات بنجاح");
        }

        private static void SendEmail(string email)
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtpServer = new SmtpClient("smtp.borg-alhadith.com");
            mail.From = new MailAddress("info@borg-alhadith.com");
            mail.To.Add(email);
            mail.Subject = "شركة برج الحديث للمقاولات";
            mail.Priority = MailPriority.High;
            mail.Body = "<html dir='rtl'><head></head><body><center>"+
                    "<font size='16' color='blue'>"+
                        "شركة برج الحديث للمقاولات"+
                    "</font>"+
                    "</center>"+
                    "<font size='14'>"+
                    "<br>"+
                    "عزيزنا العميل "+
                     "<br>"+
                    " يرجى التكرم بمراجعة الشركة للسداد"+
                    "<br>"+
                    "شكرا لكم"+
                    " <br>"+
                    "</font>"+
                "</body></html>";
            mail.IsBodyHtml = true;
           
            smtpServer.Port = 587;
            smtpServer.Credentials = new System.Net.NetworkCredential("info@borg-alhadith.com", "info607080");
            smtpServer.EnableSsl = false;
            smtpServer.Send(mail);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
