namespace bero_System.ProjectInstallmentForms
{
    partial class FrmAddProjectInstallment
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
            System.Windows.Forms.Label installments_nameLabel;
            System.Windows.Forms.Label dateOfInstallmentsLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label payByLabel;
            System.Windows.Forms.Label payDescriptionLabel;
            System.Windows.Forms.Label activeStatusLabel;
            System.Windows.Forms.Label projectLevelIDLabel;
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.projectLevelComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.payDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.payByTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.dateOfInstallmentsDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.installments_nameTextBox = new System.Windows.Forms.TextBox();
            installments_nameLabel = new System.Windows.Forms.Label();
            dateOfInstallmentsLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            payByLabel = new System.Windows.Forms.Label();
            payDescriptionLabel = new System.Windows.Forms.Label();
            activeStatusLabel = new System.Windows.Forms.Label();
            projectLevelIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // installments_nameLabel
            // 
            installments_nameLabel.AutoSize = true;
            installments_nameLabel.Location = new System.Drawing.Point(261, 40);
            installments_nameLabel.Name = "installments_nameLabel";
            installments_nameLabel.Size = new System.Drawing.Size(98, 13);
            installments_nameLabel.TabIndex = 0;
            installments_nameLabel.Text = "Installments name:";
            // 
            // dateOfInstallmentsLabel
            // 
            dateOfInstallmentsLabel.AutoSize = true;
            dateOfInstallmentsLabel.Location = new System.Drawing.Point(260, 68);
            dateOfInstallmentsLabel.Name = "dateOfInstallmentsLabel";
            dateOfInstallmentsLabel.Size = new System.Drawing.Size(110, 13);
            dateOfInstallmentsLabel.TabIndex = 2;
            dateOfInstallmentsLabel.Text = "Date Of Installments:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(260, 97);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(48, 13);
            amountLabel.TabIndex = 4;
            amountLabel.Text = "Amount:";
            // 
            // payByLabel
            // 
            payByLabel.AutoSize = true;
            payByLabel.Location = new System.Drawing.Point(265, 127);
            payByLabel.Name = "payByLabel";
            payByLabel.Size = new System.Drawing.Size(44, 13);
            payByLabel.TabIndex = 6;
            payByLabel.Text = "Pay By:";
            // 
            // payDescriptionLabel
            // 
            payDescriptionLabel.AutoSize = true;
            payDescriptionLabel.Location = new System.Drawing.Point(265, 154);
            payDescriptionLabel.Name = "payDescriptionLabel";
            payDescriptionLabel.Size = new System.Drawing.Size(85, 13);
            payDescriptionLabel.TabIndex = 8;
            payDescriptionLabel.Text = "Pay Description:";
            // 
            // activeStatusLabel
            // 
            activeStatusLabel.AutoSize = true;
            activeStatusLabel.Location = new System.Drawing.Point(265, 185);
            activeStatusLabel.Name = "activeStatusLabel";
            activeStatusLabel.Size = new System.Drawing.Size(75, 13);
            activeStatusLabel.TabIndex = 10;
            activeStatusLabel.Text = "Active Status:";
            // 
            // projectLevelIDLabel
            // 
            projectLevelIDLabel.AutoSize = true;
            projectLevelIDLabel.Location = new System.Drawing.Point(260, 215);
            projectLevelIDLabel.Name = "projectLevelIDLabel";
            projectLevelIDLabel.Size = new System.Drawing.Size(87, 13);
            projectLevelIDLabel.TabIndex = 13;
            projectLevelIDLabel.Text = "Project Level ID:";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.AddBtn);
            this.radGroupBox1.Controls.Add(this.comboBox1);
            this.radGroupBox1.Controls.Add(projectLevelIDLabel);
            this.radGroupBox1.Controls.Add(this.projectLevelComboBox);
            this.radGroupBox1.Controls.Add(activeStatusLabel);
            this.radGroupBox1.Controls.Add(payDescriptionLabel);
            this.radGroupBox1.Controls.Add(this.payDescriptionTextBox);
            this.radGroupBox1.Controls.Add(payByLabel);
            this.radGroupBox1.Controls.Add(this.payByTextBox);
            this.radGroupBox1.Controls.Add(amountLabel);
            this.radGroupBox1.Controls.Add(this.amountTextBox);
            this.radGroupBox1.Controls.Add(dateOfInstallmentsLabel);
            this.radGroupBox1.Controls.Add(this.dateOfInstallmentsDateTimePicker);
            this.radGroupBox1.Controls.Add(installments_nameLabel);
            this.radGroupBox1.Controls.Add(this.installments_nameTextBox);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "radGroupBox1";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(376, 309);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "radGroupBox1";
            this.radGroupBox1.ThemeName = "Office2013Light";
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Location = new System.Drawing.Point(261, 261);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(110, 36);
            this.AddBtn.TabIndex = 15;
            this.AddBtn.Text = "اضافة";
            this.AddBtn.ThemeName = "Office2013Light";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(138, 182);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // projectLevelComboBox
            // 
            // 
            // projectLevelComboBox.NestedRadGridView
            // 
            this.projectLevelComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.projectLevelComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.projectLevelComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.projectLevelComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.projectLevelComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.projectLevelComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.projectLevelComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.projectLevelComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.projectLevelComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.projectLevelComboBox.EditorControl.Name = "NestedRadGridView";
            this.projectLevelComboBox.EditorControl.ReadOnly = true;
            this.projectLevelComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.projectLevelComboBox.EditorControl.ShowGroupPanel = false;
            this.projectLevelComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.projectLevelComboBox.EditorControl.TabIndex = 0;
            this.projectLevelComboBox.Location = new System.Drawing.Point(27, 212);
            this.projectLevelComboBox.Name = "projectLevelComboBox";
            this.projectLevelComboBox.Size = new System.Drawing.Size(232, 20);
            this.projectLevelComboBox.TabIndex = 12;
            this.projectLevelComboBox.TabStop = false;
            this.projectLevelComboBox.ThemeName = "Office2013Light";
            // 
            // payDescriptionTextBox
            // 
            this.payDescriptionTextBox.Location = new System.Drawing.Point(159, 151);
            this.payDescriptionTextBox.Name = "payDescriptionTextBox";
            this.payDescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.payDescriptionTextBox.TabIndex = 9;
            // 
            // payByTextBox
            // 
            this.payByTextBox.Location = new System.Drawing.Point(159, 120);
            this.payByTextBox.Name = "payByTextBox";
            this.payByTextBox.Size = new System.Drawing.Size(100, 20);
            this.payByTextBox.TabIndex = 7;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(132, 94);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(127, 20);
            this.amountTextBox.TabIndex = 5;
            // 
            // dateOfInstallmentsDateTimePicker
            // 
            this.dateOfInstallmentsDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dateOfInstallmentsDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfInstallmentsDateTimePicker.Location = new System.Drawing.Point(125, 62);
            this.dateOfInstallmentsDateTimePicker.Name = "dateOfInstallmentsDateTimePicker";
            this.dateOfInstallmentsDateTimePicker.Size = new System.Drawing.Size(133, 20);
            this.dateOfInstallmentsDateTimePicker.TabIndex = 3;
            // 
            // installments_nameTextBox
            // 
            this.installments_nameTextBox.Location = new System.Drawing.Point(39, 36);
            this.installments_nameTextBox.Name = "installments_nameTextBox";
            this.installments_nameTextBox.Size = new System.Drawing.Size(219, 20);
            this.installments_nameTextBox.TabIndex = 1;
            // 
            // FrmAddProjectInstallment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(376, 309);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "FrmAddProjectInstallment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddProjectInstallment";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.FrmAddProjectInstallment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox projectLevelComboBox;
        private System.Windows.Forms.TextBox payDescriptionTextBox;
        private System.Windows.Forms.TextBox payByTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.DateTimePicker dateOfInstallmentsDateTimePicker;
        private System.Windows.Forms.TextBox installments_nameTextBox;
        private Telerik.WinControls.UI.RadButton AddBtn;
    }
}