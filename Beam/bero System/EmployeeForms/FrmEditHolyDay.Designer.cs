namespace bero_System.EmployeeForms
{
    partial class FrmEditHolyDay
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label fromDateLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label toDatetimeLabel;
            System.Windows.Forms.Label employeeIDLabel;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn3 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn4 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.EmployeeComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.Savebtn = new Telerik.WinControls.UI.RadButton();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.commintTextBox = new System.Windows.Forms.TextBox();
            this.fromDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDatetimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            label1 = new System.Windows.Forms.Label();
            fromDateLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            toDatetimeLabel = new System.Windows.Forms.Label();
            employeeIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Savebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(271, 147);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 13);
            label1.TabIndex = 22;
            label1.Text = "تعليق:";
            // 
            // fromDateLabel
            // 
            fromDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            fromDateLabel.AutoSize = true;
            fromDateLabel.Location = new System.Drawing.Point(270, 57);
            fromDateLabel.Name = "fromDateLabel";
            fromDateLabel.Size = new System.Drawing.Size(49, 13);
            fromDateLabel.TabIndex = 18;
            fromDateLabel.Text = "من تاريخ:";
            // 
            // statusLabel
            // 
            statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(270, 120);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(36, 13);
            statusLabel.TabIndex = 17;
            statusLabel.Text = "الحالة:";
            // 
            // toDatetimeLabel
            // 
            toDatetimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            toDatetimeLabel.AutoSize = true;
            toDatetimeLabel.Location = new System.Drawing.Point(268, 86);
            toDatetimeLabel.Name = "toDatetimeLabel";
            toDatetimeLabel.Size = new System.Drawing.Size(52, 13);
            toDatetimeLabel.TabIndex = 15;
            toDatetimeLabel.Text = "إلى تاريخ:";
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(270, 28);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(46, 13);
            employeeIDLabel.TabIndex = 14;
            employeeIDLabel.Text = "الموظف:";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.EmployeeComboBox);
            this.radGroupBox1.Controls.Add(this.Savebtn);
            this.radGroupBox1.Controls.Add(label1);
            this.radGroupBox1.Controls.Add(this.statusComboBox);
            this.radGroupBox1.Controls.Add(this.commintTextBox);
            this.radGroupBox1.Controls.Add(fromDateLabel);
            this.radGroupBox1.Controls.Add(this.fromDateDateTimePicker);
            this.radGroupBox1.Controls.Add(statusLabel);
            this.radGroupBox1.Controls.Add(toDatetimeLabel);
            this.radGroupBox1.Controls.Add(this.toDatetimeDateTimePicker);
            this.radGroupBox1.Controls.Add(employeeIDLabel);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(337, 281);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.ThemeName = "Office2013Light";
            // 
            // EmployeeComboBox
            // 
            // 
            // EmployeeComboBox.NestedRadGridView
            // 
            this.EmployeeComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.EmployeeComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.EmployeeComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.EmployeeComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EmployeeComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EmployeeComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.EmployeeComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.EmployeeComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.EmployeeComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.EmployeeComboBox.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            this.EmployeeComboBox.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "id";
            gridViewDecimalColumn3.HeaderText = "id";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.IsVisible = false;
            gridViewDecimalColumn3.Name = "id";
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "EmployeeName";
            gridViewTextBoxColumn6.HeaderText = "اسم الموظف";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "EmployeeName";
            gridViewTextBoxColumn6.Width = 28;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "nationalty";
            gridViewTextBoxColumn7.HeaderText = "الجنس";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.Name = "nationalty";
            gridViewTextBoxColumn7.Width = 28;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "PassportNumber";
            gridViewTextBoxColumn8.HeaderText = "رقم جواز السفر";
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.Name = "PassportNumber";
            gridViewTextBoxColumn8.Width = 28;
            gridViewDateTimeColumn3.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn3.EnableExpressionEditor = false;
            gridViewDateTimeColumn3.FieldName = "PassportExpierdDate";
            gridViewDateTimeColumn3.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn3.HeaderText = "تاريخ انتهاء الجواز";
            gridViewDateTimeColumn3.IsAutoGenerated = true;
            gridViewDateTimeColumn3.Name = "PassportExpierdDate";
            gridViewDateTimeColumn3.Width = 28;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "peronaltyNumber";
            gridViewTextBoxColumn9.HeaderText = "رقم الهوية";
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.Name = "peronaltyNumber";
            gridViewTextBoxColumn9.Width = 28;
            gridViewDateTimeColumn4.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn4.EnableExpressionEditor = false;
            gridViewDateTimeColumn4.FieldName = "personaltyExpiredDate";
            gridViewDateTimeColumn4.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn4.HeaderText = "تاريخ انتهاء الهوية";
            gridViewDateTimeColumn4.IsAutoGenerated = true;
            gridViewDateTimeColumn4.Name = "personaltyExpiredDate";
            gridViewDateTimeColumn4.Width = 28;
            gridViewDecimalColumn4.DataType = typeof(System.Nullable<double>);
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "Salary";
            gridViewDecimalColumn4.HeaderText = "الراتب";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.Name = "Salary";
            gridViewDecimalColumn4.Width = 28;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "Status";
            gridViewTextBoxColumn10.HeaderText = "الحالة";
            gridViewTextBoxColumn10.IsAutoGenerated = true;
            gridViewTextBoxColumn10.Name = "Status";
            gridViewTextBoxColumn10.Width = 31;
            this.EmployeeComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn3,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewDateTimeColumn3,
            gridViewTextBoxColumn9,
            gridViewDateTimeColumn4,
            gridViewDecimalColumn4,
            gridViewTextBoxColumn10});
            this.EmployeeComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.EmployeeComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.EmployeeComboBox.EditorControl.Name = "NestedRadGridView";
            this.EmployeeComboBox.EditorControl.ReadOnly = true;
            this.EmployeeComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EmployeeComboBox.EditorControl.ShowGroupPanel = false;
            this.EmployeeComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.EmployeeComboBox.EditorControl.TabIndex = 0;
            this.EmployeeComboBox.Location = new System.Drawing.Point(16, 26);
            this.EmployeeComboBox.Name = "EmployeeComboBox";
            this.EmployeeComboBox.Size = new System.Drawing.Size(247, 20);
            this.EmployeeComboBox.TabIndex = 24;
            this.EmployeeComboBox.TabStop = false;
            this.EmployeeComboBox.ThemeName = "Office2013Light";
            // 
            // Savebtn
            // 
            this.Savebtn.Image = global::bero_System.Properties.Resources.Save;
            this.Savebtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Savebtn.Location = new System.Drawing.Point(214, 233);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(111, 36);
            this.Savebtn.TabIndex = 23;
            this.Savebtn.Text = "حفظ";
            this.Savebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Savebtn.ThemeName = "Office2013Light";
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // statusComboBox
            // 
            this.statusComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "فعال",
            "مؤجز",
            "مطرود"});
            this.statusComboBox.Location = new System.Drawing.Point(88, 116);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(176, 21);
            this.statusComboBox.TabIndex = 21;
            // 
            // commintTextBox
            // 
            this.commintTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.commintTextBox.Location = new System.Drawing.Point(20, 144);
            this.commintTextBox.Multiline = true;
            this.commintTextBox.Name = "commintTextBox";
            this.commintTextBox.Size = new System.Drawing.Size(244, 62);
            this.commintTextBox.TabIndex = 20;
            // 
            // fromDateDateTimePicker
            // 
            this.fromDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDateDateTimePicker.Location = new System.Drawing.Point(154, 56);
            this.fromDateDateTimePicker.Name = "fromDateDateTimePicker";
            this.fromDateDateTimePicker.Size = new System.Drawing.Size(110, 20);
            this.fromDateDateTimePicker.TabIndex = 19;
            this.fromDateDateTimePicker.Value = new System.DateTime(2015, 1, 27, 12, 40, 59, 0);
            // 
            // toDatetimeDateTimePicker
            // 
            this.toDatetimeDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toDatetimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDatetimeDateTimePicker.Location = new System.Drawing.Point(154, 86);
            this.toDatetimeDateTimePicker.Name = "toDatetimeDateTimePicker";
            this.toDatetimeDateTimePicker.Size = new System.Drawing.Size(110, 20);
            this.toDatetimeDateTimePicker.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // FrmEditHolyDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 281);
            this.Controls.Add(this.radGroupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(345, 312);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(345, 312);
            this.Name = "FrmEditHolyDay";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(345, 312);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل اجازة";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.FrmEditHolyDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Savebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton Savebtn;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.TextBox commintTextBox;
        private System.Windows.Forms.DateTimePicker fromDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker toDatetimeDateTimePicker;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public Telerik.WinControls.UI.RadMultiColumnComboBox EmployeeComboBox;
    }
}