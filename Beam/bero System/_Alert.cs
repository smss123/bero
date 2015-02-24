using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bero_System
{
    public class _Alert
    {

        #region " Controls "

        static Form Frm = new Form();
        static Timer timer1 = new Timer();
        static Label ImageLab = new Label();
        static Label MsgHolderLab = new Label();
        Panel BackPanel = new Panel();
        #endregion

        #region " Create Controls "
        static void CreateMsgFrm()
        {
            // Form
            Frm.FormBorderStyle = FormBorderStyle.None;
            Frm.StartPosition = FormStartPosition.CenterScreen;
            Frm.BackgroundImageLayout = ImageLayout.Stretch;
            Frm.Size = new Size(338, 60);
            Frm.TopMost = true;
            //=======================================

            // ImageLab
            ImageLab.AutoSize = false;
            ImageLab.Dock = DockStyle.Right;
            ImageLab.BackColor = Color.Transparent;
            ImageLab.ImageAlign = ContentAlignment.MiddleCenter;
            ImageLab.Size = new Size(59, 60);
            ImageLab.BorderStyle = BorderStyle.None;
            Frm.Controls.Add(ImageLab);
            //============================
            // MsgHolderLab
            MsgHolderLab.Size = new Size(200, 60);
            MsgHolderLab.BackColor = Color.Transparent;
            MsgHolderLab.Anchor = AnchorStyles.Right;
            MsgHolderLab.TextAlign = ContentAlignment.MiddleRight;
            MsgHolderLab.ForeColor = Color.White;
            MsgHolderLab.Font = new Font("Times New Roman", 12, FontStyle.Bold);

            Frm.Controls.Add(MsgHolderLab);




        }
        #endregion

        #region "   Timer      "
        static void ActivateTimer()
        {
            timer1.Interval = 3000;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;

        }
        static void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            Frm.Cursor = Cursors.Default;
            Frm.Hide();
        }
        #endregion

        #region "  ^^^ Messages ^^^     "
        public static void Info(string Msg)
        {

            CreateMsgFrm();
            ActivateTimer();
            Frm.Cursor = Cursors.WaitCursor;
            ImageLab.Image = Properties.Resources.Info;

            Frm.BackgroundImage = Properties.Resources.BOkey;
            MsgHolderLab.Text = Msg;
            Frm.Show();

        }

        public static void Error(string Msg)
        {
            CreateMsgFrm();
            ActivateTimer();
            Frm.Cursor = Cursors.WaitCursor;
            ImageLab.Image = Properties.Resources.error5;

            Frm.BackgroundImage = Properties.Resources.BError;

            MsgHolderLab.Text = Msg;
            Frm.Show();
        }

        public static void Warning(string Msg)
        {
            CreateMsgFrm();
            ActivateTimer();
            Frm.Cursor = Cursors.WaitCursor;
            ImageLab.Image = Properties.Resources.Warning;
            Frm.BackgroundImage = Properties.Resources.BWarnnig;
            MsgHolderLab.ForeColor = Color.Blue;
            MsgHolderLab.Text = Msg;
            Frm.Show();

        }


       
        #endregion
    }
}
