namespace bero_System.SecurityForms
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label pwdLabel;
            System.Windows.Forms.Label userNameLabel;
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.ExitBtn = new Telerik.WinControls.UI.RadButton();
            this.EnterBtn = new Telerik.WinControls.UI.RadButton();
            this.pwdTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            pwdLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnterBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pwdLabel
            // 
            pwdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            pwdLabel.AutoSize = true;
            pwdLabel.Location = new System.Drawing.Point(259, 94);
            pwdLabel.Name = "pwdLabel";
            pwdLabel.Size = new System.Drawing.Size(63, 13);
            pwdLabel.TabIndex = 2;
            pwdLabel.Text = "كلمة المرور:";
            // 
            // userNameLabel
            // 
            userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(259, 59);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(85, 13);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "اسم المستخدم:";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.ExitBtn);
            this.radGroupBox1.Controls.Add(this.EnterBtn);
            this.radGroupBox1.Controls.Add(pwdLabel);
            this.radGroupBox1.Controls.Add(this.pwdTextBox);
            this.radGroupBox1.Controls.Add(userNameLabel);
            this.radGroupBox1.Controls.Add(this.userNameTextBox);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "بيانات المستخدم";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(357, 213);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "بيانات المستخدم";
            this.radGroupBox1.ThemeName = "Office2013Light";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.Location = new System.Drawing.Point(22, 150);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(109, 36);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "خروج";
            this.ExitBtn.ThemeName = "Office2013Light";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // EnterBtn
            // 
            this.EnterBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EnterBtn.Location = new System.Drawing.Point(234, 150);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(109, 36);
            this.EnterBtn.TabIndex = 6;
            this.EnterBtn.Text = "دخول";
            this.EnterBtn.ThemeName = "Office2013Light";
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // pwdTextBox
            // 
            this.pwdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pwdTextBox.Location = new System.Drawing.Point(22, 92);
            this.pwdTextBox.Name = "pwdTextBox";
            this.pwdTextBox.Size = new System.Drawing.Size(233, 20);
            this.pwdTextBox.TabIndex = 3;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameTextBox.Location = new System.Drawing.Point(22, 57);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(233, 20);
            this.userNameTextBox.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 213);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "FrmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnterBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton ExitBtn;
        private Telerik.WinControls.UI.RadButton EnterBtn;
        private System.Windows.Forms.TextBox pwdTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
    }
}