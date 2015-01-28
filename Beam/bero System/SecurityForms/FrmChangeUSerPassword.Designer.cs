namespace bero_System.SecurityForms
{
    partial class FrmChangeUSerPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label pwdLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label label1;
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.NewPwdTextBox = new System.Windows.Forms.TextBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.OldpwdTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            pwdLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pwdLabel
            // 
            pwdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            pwdLabel.AutoSize = true;
            pwdLabel.Location = new System.Drawing.Point(261, 63);
            pwdLabel.Name = "pwdLabel";
            pwdLabel.Size = new System.Drawing.Size(122, 13);
            pwdLabel.TabIndex = 2;
            pwdLabel.Text = "ادخل كلمة المرور القدمية";
            // 
            // userNameLabel
            // 
            userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(263, 28);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(85, 13);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "اسم المستخدم:";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(261, 103);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(125, 13);
            label1.TabIndex = 7;
            label1.Text = "ادخل كلمة المرور الجديدة:";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(label1);
            this.radGroupBox1.Controls.Add(this.NewPwdTextBox);
            this.radGroupBox1.Controls.Add(this.AddBtn);
            this.radGroupBox1.Controls.Add(pwdLabel);
            this.radGroupBox1.Controls.Add(this.OldpwdTextBox);
            this.radGroupBox1.Controls.Add(userNameLabel);
            this.radGroupBox1.Controls.Add(this.userNameTextBox);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "بيانات المستخدم";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(388, 197);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "بيانات المستخدم";
            this.radGroupBox1.ThemeName = "Office2013Light";
            // 
            // NewPwdTextBox
            // 
            this.NewPwdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewPwdTextBox.Location = new System.Drawing.Point(27, 100);
            this.NewPwdTextBox.Name = "NewPwdTextBox";
            this.NewPwdTextBox.Size = new System.Drawing.Size(230, 20);
            this.NewPwdTextBox.TabIndex = 8;
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Location = new System.Drawing.Point(271, 149);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(109, 36);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "حفظ";
            this.AddBtn.ThemeName = "Office2013Light";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // OldpwdTextBox
            // 
            this.OldpwdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OldpwdTextBox.Location = new System.Drawing.Point(27, 60);
            this.OldpwdTextBox.Name = "OldpwdTextBox";
            this.OldpwdTextBox.Size = new System.Drawing.Size(230, 20);
            this.OldpwdTextBox.TabIndex = 3;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameTextBox.Location = new System.Drawing.Point(27, 25);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(230, 20);
            this.userNameTextBox.TabIndex = 1;
            // 
            // FrmChangeUSerPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 197);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "FrmChangeUSerPassword";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmChangeUSerPassword";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.FrmChangeUSerPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.TextBox NewPwdTextBox;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private System.Windows.Forms.TextBox OldpwdTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
    }
}