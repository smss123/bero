namespace bero_System.EmployeeForms
{
    partial class FrmAddEmployee
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
            System.Windows.Forms.Label employeeNameLabel;
            System.Windows.Forms.Label nationaltyLabel;
            System.Windows.Forms.Label passportNumberLabel;
            System.Windows.Forms.Label peronaltyNumberLabel;
            System.Windows.Forms.Label salaryLabel;
            System.Windows.Forms.Label passportExpierdDateLabel;
            System.Windows.Forms.Label personaltyExpiredDateLabel;
            System.Windows.Forms.Label statusLabel;
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.personaltyExpiredDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.passportExpierdDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.peronaltyNumberTextBox = new System.Windows.Forms.TextBox();
            this.passportNumberTextBox = new System.Windows.Forms.TextBox();
            this.nationaltyComboBox = new System.Windows.Forms.ComboBox();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            employeeNameLabel = new System.Windows.Forms.Label();
            nationaltyLabel = new System.Windows.Forms.Label();
            passportNumberLabel = new System.Windows.Forms.Label();
            peronaltyNumberLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            passportExpierdDateLabel = new System.Windows.Forms.Label();
            personaltyExpiredDateLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeNameLabel
            // 
            employeeNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            employeeNameLabel.AutoSize = true;
            employeeNameLabel.Location = new System.Drawing.Point(286, 24);
            employeeNameLabel.Name = "employeeNameLabel";
            employeeNameLabel.Size = new System.Drawing.Size(71, 13);
            employeeNameLabel.TabIndex = 0;
            employeeNameLabel.Text = "اسم الموظف:";
            // 
            // nationaltyLabel
            // 
            nationaltyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            nationaltyLabel.AutoSize = true;
            nationaltyLabel.Location = new System.Drawing.Point(286, 54);
            nationaltyLabel.Name = "nationaltyLabel";
            nationaltyLabel.Size = new System.Drawing.Size(42, 13);
            nationaltyLabel.TabIndex = 2;
            nationaltyLabel.Text = "الجنس:";
            // 
            // passportNumberLabel
            // 
            passportNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            passportNumberLabel.AutoSize = true;
            passportNumberLabel.Location = new System.Drawing.Point(286, 85);
            passportNumberLabel.Name = "passportNumberLabel";
            passportNumberLabel.Size = new System.Drawing.Size(82, 13);
            passportNumberLabel.TabIndex = 4;
            passportNumberLabel.Text = "رقم جواز السفر:";
            // 
            // peronaltyNumberLabel
            // 
            peronaltyNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            peronaltyNumberLabel.AutoSize = true;
            peronaltyNumberLabel.Location = new System.Drawing.Point(287, 133);
            peronaltyNumberLabel.Name = "peronaltyNumberLabel";
            peronaltyNumberLabel.Size = new System.Drawing.Size(57, 13);
            peronaltyNumberLabel.TabIndex = 6;
            peronaltyNumberLabel.Text = "رقم الهوية:";
            // 
            // salaryLabel
            // 
            salaryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new System.Drawing.Point(287, 183);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(38, 13);
            salaryLabel.TabIndex = 8;
            salaryLabel.Text = "الراتب:";
            salaryLabel.Click += new System.EventHandler(this.salaryLabel_Click);
            // 
            // passportExpierdDateLabel
            // 
            passportExpierdDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            passportExpierdDateLabel.AutoSize = true;
            passportExpierdDateLabel.Location = new System.Drawing.Point(285, 107);
            passportExpierdDateLabel.Name = "passportExpierdDateLabel";
            passportExpierdDateLabel.Size = new System.Drawing.Size(112, 13);
            passportExpierdDateLabel.TabIndex = 10;
            passportExpierdDateLabel.Text = "تاريخ انتهاء جواز السفر:";
            // 
            // personaltyExpiredDateLabel
            // 
            personaltyExpiredDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            personaltyExpiredDateLabel.AutoSize = true;
            personaltyExpiredDateLabel.Location = new System.Drawing.Point(287, 156);
            personaltyExpiredDateLabel.Name = "personaltyExpiredDateLabel";
            personaltyExpiredDateLabel.Size = new System.Drawing.Size(87, 13);
            personaltyExpiredDateLabel.TabIndex = 12;
            personaltyExpiredDateLabel.Text = "تاريخ انتهاء الهوية:";
            // 
            // statusLabel
            // 
            statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(287, 209);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(36, 13);
            statusLabel.TabIndex = 14;
            statusLabel.Text = "الحالة:";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.AddBtn);
            this.radGroupBox1.Controls.Add(statusLabel);
            this.radGroupBox1.Controls.Add(this.statusComboBox);
            this.radGroupBox1.Controls.Add(personaltyExpiredDateLabel);
            this.radGroupBox1.Controls.Add(this.personaltyExpiredDateDateTimePicker);
            this.radGroupBox1.Controls.Add(passportExpierdDateLabel);
            this.radGroupBox1.Controls.Add(this.passportExpierdDateDateTimePicker);
            this.radGroupBox1.Controls.Add(salaryLabel);
            this.radGroupBox1.Controls.Add(this.salaryTextBox);
            this.radGroupBox1.Controls.Add(peronaltyNumberLabel);
            this.radGroupBox1.Controls.Add(this.peronaltyNumberTextBox);
            this.radGroupBox1.Controls.Add(passportNumberLabel);
            this.radGroupBox1.Controls.Add(this.passportNumberTextBox);
            this.radGroupBox1.Controls.Add(this.nationaltyComboBox);
            this.radGroupBox1.Controls.Add(nationaltyLabel);
            this.radGroupBox1.Controls.Add(employeeNameLabel);
            this.radGroupBox1.Controls.Add(this.employeeNameTextBox);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "بيانات الموظفين";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(393, 309);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "بيانات الموظفين";
            this.radGroupBox1.ThemeName = "Office2013Light";
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Image = global::bero_System.Properties.Resources.Add;
            this.AddBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.Location = new System.Drawing.Point(271, 251);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(110, 36);
            this.AddBtn.TabIndex = 16;
            this.AddBtn.Text = "اضافة";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.ThemeName = "Office2013Light";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // statusComboBox
            // 
            this.statusComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.ItemHeight = 13;
            this.statusComboBox.Items.AddRange(new object[] {
            "فعال",
            "مؤجز",
            "مطرود",
            "موقوف"});
            this.statusComboBox.Location = new System.Drawing.Point(120, 209);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(161, 21);
            this.statusComboBox.TabIndex = 15;
            // 
            // personaltyExpiredDateDateTimePicker
            // 
            this.personaltyExpiredDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personaltyExpiredDateDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.personaltyExpiredDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.personaltyExpiredDateDateTimePicker.Location = new System.Drawing.Point(155, 156);
            this.personaltyExpiredDateDateTimePicker.Name = "personaltyExpiredDateDateTimePicker";
            this.personaltyExpiredDateDateTimePicker.Size = new System.Drawing.Size(126, 20);
            this.personaltyExpiredDateDateTimePicker.TabIndex = 6;
            // 
            // passportExpierdDateDateTimePicker
            // 
            this.passportExpierdDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passportExpierdDateDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.passportExpierdDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.passportExpierdDateDateTimePicker.Location = new System.Drawing.Point(155, 104);
            this.passportExpierdDateDateTimePicker.Name = "passportExpierdDateDateTimePicker";
            this.passportExpierdDateDateTimePicker.Size = new System.Drawing.Size(126, 20);
            this.passportExpierdDateDateTimePicker.TabIndex = 4;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salaryTextBox.Location = new System.Drawing.Point(155, 183);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(126, 20);
            this.salaryTextBox.TabIndex = 7;
            this.salaryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salaryTextBox_KeyPress);
            // 
            // peronaltyNumberTextBox
            // 
            this.peronaltyNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.peronaltyNumberTextBox.Location = new System.Drawing.Point(87, 130);
            this.peronaltyNumberTextBox.Name = "peronaltyNumberTextBox";
            this.peronaltyNumberTextBox.Size = new System.Drawing.Size(194, 20);
            this.peronaltyNumberTextBox.TabIndex = 5;
            this.peronaltyNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.peronaltyNumberTextBox_KeyPress);
            // 
            // passportNumberTextBox
            // 
            this.passportNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passportNumberTextBox.Location = new System.Drawing.Point(87, 78);
            this.passportNumberTextBox.Name = "passportNumberTextBox";
            this.passportNumberTextBox.Size = new System.Drawing.Size(194, 20);
            this.passportNumberTextBox.TabIndex = 3;
            this.passportNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passportNumberTextBox_KeyPress);
            // 
            // nationaltyComboBox
            // 
            this.nationaltyComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nationaltyComboBox.FormattingEnabled = true;
            this.nationaltyComboBox.Items.AddRange(new object[] {
            "ذكر",
            "انثى",
            "اخرى"});
            this.nationaltyComboBox.Location = new System.Drawing.Point(129, 51);
            this.nationaltyComboBox.Name = "nationaltyComboBox";
            this.nationaltyComboBox.Size = new System.Drawing.Size(152, 21);
            this.nationaltyComboBox.TabIndex = 2;
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeNameTextBox.Location = new System.Drawing.Point(25, 21);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(256, 20);
            this.employeeNameTextBox.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // FrmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 309);
            this.Controls.Add(this.radGroupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(401, 340);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(401, 340);
            this.Name = "FrmAddEmployee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(401, 340);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة موظف";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.FrmAddEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.DateTimePicker personaltyExpiredDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker passportExpierdDateDateTimePicker;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox peronaltyNumberTextBox;
        private System.Windows.Forms.TextBox passportNumberTextBox;
        private System.Windows.Forms.ComboBox nationaltyComboBox;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}