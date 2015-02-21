namespace bero_System.EmployeeForms
{
    partial class FrmEditEmployee
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
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label personaltyExpiredDateLabel;
            System.Windows.Forms.Label passportExpierdDateLabel;
            System.Windows.Forms.Label salaryLabel;
            System.Windows.Forms.Label peronaltyNumberLabel;
            System.Windows.Forms.Label passportNumberLabel;
            System.Windows.Forms.Label nationaltyLabel;
            System.Windows.Forms.Label employeeNameLabel;
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.SaveBtn = new Telerik.WinControls.UI.RadButton();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.personaltyExpiredDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.passportExpierdDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.peronaltyNumberTextBox = new System.Windows.Forms.TextBox();
            this.passportNumberTextBox = new System.Windows.Forms.TextBox();
            this.nationaltyComboBox = new System.Windows.Forms.ComboBox();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            statusLabel = new System.Windows.Forms.Label();
            personaltyExpiredDateLabel = new System.Windows.Forms.Label();
            passportExpierdDateLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            peronaltyNumberLabel = new System.Windows.Forms.Label();
            passportNumberLabel = new System.Windows.Forms.Label();
            nationaltyLabel = new System.Windows.Forms.Label();
            employeeNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(271, 210);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(36, 13);
            statusLabel.TabIndex = 14;
            statusLabel.Text = "الحالة:";
            // 
            // personaltyExpiredDateLabel
            // 
            personaltyExpiredDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            personaltyExpiredDateLabel.AutoSize = true;
            personaltyExpiredDateLabel.Location = new System.Drawing.Point(271, 157);
            personaltyExpiredDateLabel.Name = "personaltyExpiredDateLabel";
            personaltyExpiredDateLabel.Size = new System.Drawing.Size(87, 13);
            personaltyExpiredDateLabel.TabIndex = 12;
            personaltyExpiredDateLabel.Text = "تاريخ انتهاء الهوية:";
            // 
            // passportExpierdDateLabel
            // 
            passportExpierdDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            passportExpierdDateLabel.AutoSize = true;
            passportExpierdDateLabel.Location = new System.Drawing.Point(269, 108);
            passportExpierdDateLabel.Name = "passportExpierdDateLabel";
            passportExpierdDateLabel.Size = new System.Drawing.Size(112, 13);
            passportExpierdDateLabel.TabIndex = 10;
            passportExpierdDateLabel.Text = "تاريخ انتهاء جواز السفر:";
            // 
            // salaryLabel
            // 
            salaryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new System.Drawing.Point(271, 184);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(38, 13);
            salaryLabel.TabIndex = 8;
            salaryLabel.Text = "الراتب:";
            // 
            // peronaltyNumberLabel
            // 
            peronaltyNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            peronaltyNumberLabel.AutoSize = true;
            peronaltyNumberLabel.Location = new System.Drawing.Point(271, 134);
            peronaltyNumberLabel.Name = "peronaltyNumberLabel";
            peronaltyNumberLabel.Size = new System.Drawing.Size(57, 13);
            peronaltyNumberLabel.TabIndex = 6;
            peronaltyNumberLabel.Text = "رقم الهوية:";
            // 
            // passportNumberLabel
            // 
            passportNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            passportNumberLabel.AutoSize = true;
            passportNumberLabel.Location = new System.Drawing.Point(270, 86);
            passportNumberLabel.Name = "passportNumberLabel";
            passportNumberLabel.Size = new System.Drawing.Size(82, 13);
            passportNumberLabel.TabIndex = 4;
            passportNumberLabel.Text = "رقم جواز السفر:";
            // 
            // nationaltyLabel
            // 
            nationaltyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            nationaltyLabel.AutoSize = true;
            nationaltyLabel.Location = new System.Drawing.Point(270, 55);
            nationaltyLabel.Name = "nationaltyLabel";
            nationaltyLabel.Size = new System.Drawing.Size(42, 13);
            nationaltyLabel.TabIndex = 2;
            nationaltyLabel.Text = "الجنس:";
            // 
            // employeeNameLabel
            // 
            employeeNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            employeeNameLabel.AutoSize = true;
            employeeNameLabel.Location = new System.Drawing.Point(270, 25);
            employeeNameLabel.Name = "employeeNameLabel";
            employeeNameLabel.Size = new System.Drawing.Size(71, 13);
            employeeNameLabel.TabIndex = 0;
            employeeNameLabel.Text = "اسم الموظف:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.SaveBtn);
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
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(385, 301);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.ThemeName = "Office2013Light";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.Image = global::bero_System.Properties.Resources.Save;
            this.SaveBtn.Location = new System.Drawing.Point(263, 251);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(110, 36);
            this.SaveBtn.TabIndex = 16;
            this.SaveBtn.Text = "حفظ";
            this.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBtn.ThemeName = "Office2013Light";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // statusComboBox
            // 
            this.statusComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.ItemHeight = 13;
            this.statusComboBox.Items.AddRange(new object[] {
            "فعال",
            "مؤجز",
            "مطرود"});
            this.statusComboBox.Location = new System.Drawing.Point(104, 210);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(161, 21);
            this.statusComboBox.TabIndex = 15;
            // 
            // personaltyExpiredDateDateTimePicker
            // 
            this.personaltyExpiredDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personaltyExpiredDateDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.personaltyExpiredDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.personaltyExpiredDateDateTimePicker.Location = new System.Drawing.Point(139, 157);
            this.personaltyExpiredDateDateTimePicker.Name = "personaltyExpiredDateDateTimePicker";
            this.personaltyExpiredDateDateTimePicker.Size = new System.Drawing.Size(126, 20);
            this.personaltyExpiredDateDateTimePicker.TabIndex = 6;
            // 
            // passportExpierdDateDateTimePicker
            // 
            this.passportExpierdDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passportExpierdDateDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.passportExpierdDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.passportExpierdDateDateTimePicker.Location = new System.Drawing.Point(139, 105);
            this.passportExpierdDateDateTimePicker.Name = "passportExpierdDateDateTimePicker";
            this.passportExpierdDateDateTimePicker.Size = new System.Drawing.Size(126, 20);
            this.passportExpierdDateDateTimePicker.TabIndex = 4;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salaryTextBox.Location = new System.Drawing.Point(139, 184);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(126, 20);
            this.salaryTextBox.TabIndex = 7;
            this.salaryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salaryTextBox_KeyPress);
            // 
            // peronaltyNumberTextBox
            // 
            this.peronaltyNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.peronaltyNumberTextBox.Location = new System.Drawing.Point(71, 131);
            this.peronaltyNumberTextBox.Name = "peronaltyNumberTextBox";
            this.peronaltyNumberTextBox.Size = new System.Drawing.Size(194, 20);
            this.peronaltyNumberTextBox.TabIndex = 5;
            this.peronaltyNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.peronaltyNumberTextBox_KeyPress);
            // 
            // passportNumberTextBox
            // 
            this.passportNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passportNumberTextBox.Location = new System.Drawing.Point(71, 79);
            this.passportNumberTextBox.Name = "passportNumberTextBox";
            this.passportNumberTextBox.Size = new System.Drawing.Size(194, 20);
            this.passportNumberTextBox.TabIndex = 3;
            this.passportNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passportNumberTextBox_KeyPress);
            // 
            // nationaltyComboBox
            // 
            this.nationaltyComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nationaltyComboBox.FormattingEnabled = true;
            this.nationaltyComboBox.Location = new System.Drawing.Point(113, 52);
            this.nationaltyComboBox.Name = "nationaltyComboBox";
            this.nationaltyComboBox.Size = new System.Drawing.Size(152, 21);
            this.nationaltyComboBox.TabIndex = 2;
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeNameTextBox.Location = new System.Drawing.Point(12, 22);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(253, 20);
            this.employeeNameTextBox.TabIndex = 1;
            // 
            // FrmEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 301);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "FrmEditEmployee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل موظف";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.FrmEditEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton SaveBtn;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.DateTimePicker personaltyExpiredDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker passportExpierdDateDateTimePicker;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox peronaltyNumberTextBox;
        private System.Windows.Forms.TextBox passportNumberTextBox;
        private System.Windows.Forms.ComboBox nationaltyComboBox;
        private System.Windows.Forms.TextBox employeeNameTextBox;

    }
}