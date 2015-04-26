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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label installments_nameLabel;
            System.Windows.Forms.Label dateOfInstallmentsLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label payByLabel;
            System.Windows.Forms.Label payDescriptionLabel;
            System.Windows.Forms.Label activeStatusLabel;
            System.Windows.Forms.Label projectLevelIDLabel;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.ReportBtn = new System.Windows.Forms.Button();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.CmbActiveStatus = new System.Windows.Forms.ComboBox();
            this.projectLevelComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.projectLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.payByTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.dateOfInstallmentsDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.installments_nameTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // installments_nameLabel
            // 
            installments_nameLabel.AutoSize = true;
            installments_nameLabel.Location = new System.Drawing.Point(294, 25);
            installments_nameLabel.Name = "installments_nameLabel";
            installments_nameLabel.Size = new System.Drawing.Size(57, 13);
            installments_nameLabel.TabIndex = 0;
            installments_nameLabel.Text = "اسم القسط:";
            // 
            // dateOfInstallmentsLabel
            // 
            dateOfInstallmentsLabel.AutoSize = true;
            dateOfInstallmentsLabel.Location = new System.Drawing.Point(293, 53);
            dateOfInstallmentsLabel.Name = "dateOfInstallmentsLabel";
            dateOfInstallmentsLabel.Size = new System.Drawing.Size(62, 13);
            dateOfInstallmentsLabel.TabIndex = 2;
            dateOfInstallmentsLabel.Text = "تاريخ الدفع:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(298, 82);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(35, 13);
            amountLabel.TabIndex = 4;
            amountLabel.Text = "المبلغ:";
            // 
            // payByLabel
            // 
            payByLabel.AutoSize = true;
            payByLabel.Location = new System.Drawing.Point(298, 112);
            payByLabel.Name = "payByLabel";
            payByLabel.Size = new System.Drawing.Size(65, 13);
            payByLabel.TabIndex = 6;
            payByLabel.Text = "دفع بواسطة:";
            // 
            // payDescriptionLabel
            // 
            payDescriptionLabel.AutoSize = true;
            payDescriptionLabel.Location = new System.Drawing.Point(298, 139);
            payDescriptionLabel.Name = "payDescriptionLabel";
            payDescriptionLabel.Size = new System.Drawing.Size(61, 13);
            payDescriptionLabel.TabIndex = 8;
            payDescriptionLabel.Text = "وصف الدفع:";
            // 
            // activeStatusLabel
            // 
            activeStatusLabel.AutoSize = true;
            activeStatusLabel.Location = new System.Drawing.Point(298, 170);
            activeStatusLabel.Name = "activeStatusLabel";
            activeStatusLabel.Size = new System.Drawing.Size(35, 13);
            activeStatusLabel.TabIndex = 10;
            activeStatusLabel.Text = "الحالة:";
            // 
            // projectLevelIDLabel
            // 
            projectLevelIDLabel.AutoSize = true;
            projectLevelIDLabel.Location = new System.Drawing.Point(293, 200);
            projectLevelIDLabel.Name = "projectLevelIDLabel";
            projectLevelIDLabel.Size = new System.Drawing.Size(91, 13);
            projectLevelIDLabel.TabIndex = 13;
            projectLevelIDLabel.Text = "المستوى المخصص:";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.ReportBtn);
            this.radGroupBox1.Controls.Add(this.AddBtn);
            this.radGroupBox1.Controls.Add(this.CmbActiveStatus);
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
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(393, 291);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.ThemeName = "Office2013Light";
            // 
            // ReportBtn
            // 
            this.ReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportBtn.Location = new System.Drawing.Point(60, 245);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(175, 32);
            this.ReportBtn.TabIndex = 14;
            this.ReportBtn.Text = "طبـــــــــاعة أيصــــــــال دفـــــــــع";
            this.ReportBtn.UseVisualStyleBackColor = true;
            this.ReportBtn.Click += new System.EventHandler(this.ReportBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Image = global::bero_System.Properties.Resources.Add;
            this.AddBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.Location = new System.Drawing.Point(274, 245);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(110, 36);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "اضافة";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.ThemeName = "Office2013Light";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CmbActiveStatus
            // 
            this.CmbActiveStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbActiveStatus.FormattingEnabled = true;
            this.CmbActiveStatus.Items.AddRange(new object[] {
            "تمت الجدولة",
            "تم الدفع",
            "غير مكتمل"});
            this.CmbActiveStatus.Location = new System.Drawing.Point(171, 167);
            this.CmbActiveStatus.Name = "CmbActiveStatus";
            this.CmbActiveStatus.Size = new System.Drawing.Size(121, 21);
            this.CmbActiveStatus.TabIndex = 6;
            // 
            // projectLevelComboBox
            // 
            this.projectLevelComboBox.DataSource = this.projectLevelBindingSource;
            // 
            // projectLevelComboBox.NestedRadGridView
            // 
            this.projectLevelComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.projectLevelComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.projectLevelComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.projectLevelComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.projectLevelComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.projectLevelComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.projectLevelComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.projectLevelComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.projectLevelComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.projectLevelComboBox.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            this.projectLevelComboBox.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "id";
            gridViewDecimalColumn1.HeaderText = "id";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "id";
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "LevelName";
            gridViewTextBoxColumn1.HeaderText = "المستوى";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "LevelName";
            gridViewTextBoxColumn1.Width = 58;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Descripotion";
            gridViewTextBoxColumn2.HeaderText = "الوصف";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Descripotion";
            gridViewTextBoxColumn2.Width = 106;
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<double>);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "LevelAmount";
            gridViewDecimalColumn2.HeaderText = "التكلفة";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "LevelAmount";
            gridViewDecimalColumn2.Width = 58;
            this.projectLevelComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn2});
            this.projectLevelComboBox.EditorControl.MasterTemplate.DataSource = this.projectLevelBindingSource;
            this.projectLevelComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.projectLevelComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.projectLevelComboBox.EditorControl.Name = "NestedRadGridView";
            this.projectLevelComboBox.EditorControl.ReadOnly = true;
            this.projectLevelComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.projectLevelComboBox.EditorControl.ShowGroupPanel = false;
            this.projectLevelComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.projectLevelComboBox.EditorControl.TabIndex = 0;
            this.projectLevelComboBox.Location = new System.Drawing.Point(60, 197);
            this.projectLevelComboBox.Name = "projectLevelComboBox";
            this.projectLevelComboBox.Size = new System.Drawing.Size(232, 20);
            this.projectLevelComboBox.TabIndex = 7;
            this.projectLevelComboBox.TabStop = false;
            this.projectLevelComboBox.ThemeName = "Office2013Light";
            // 
            // projectLevelBindingSource
            // 
            this.projectLevelBindingSource.DataSource = typeof(DataLayer.projectLevel);
            // 
            // payDescriptionTextBox
            // 
            this.payDescriptionTextBox.Location = new System.Drawing.Point(171, 136);
            this.payDescriptionTextBox.Name = "payDescriptionTextBox";
            this.payDescriptionTextBox.Size = new System.Drawing.Size(121, 20);
            this.payDescriptionTextBox.TabIndex = 5;
            // 
            // payByTextBox
            // 
            this.payByTextBox.Location = new System.Drawing.Point(171, 105);
            this.payByTextBox.Name = "payByTextBox";
            this.payByTextBox.Size = new System.Drawing.Size(121, 20);
            this.payByTextBox.TabIndex = 4;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(171, 79);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(121, 20);
            this.amountTextBox.TabIndex = 3;
            this.amountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountTextBox_KeyPress);
            // 
            // dateOfInstallmentsDateTimePicker
            // 
            this.dateOfInstallmentsDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dateOfInstallmentsDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfInstallmentsDateTimePicker.Location = new System.Drawing.Point(171, 47);
            this.dateOfInstallmentsDateTimePicker.Name = "dateOfInstallmentsDateTimePicker";
            this.dateOfInstallmentsDateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.dateOfInstallmentsDateTimePicker.TabIndex = 2;
            // 
            // installments_nameTextBox
            // 
            this.installments_nameTextBox.Location = new System.Drawing.Point(38, 21);
            this.installments_nameTextBox.Name = "installments_nameTextBox";
            this.installments_nameTextBox.Size = new System.Drawing.Size(253, 20);
            this.installments_nameTextBox.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddProjectInstallment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(393, 291);
            this.Controls.Add(this.radGroupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(401, 322);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(401, 322);
            this.Name = "FrmAddProjectInstallment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(401, 322);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة قسط مشروع";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.FrmAddProjectInstallment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.ComboBox CmbActiveStatus;
        private Telerik.WinControls.UI.RadMultiColumnComboBox projectLevelComboBox;
        private System.Windows.Forms.TextBox payDescriptionTextBox;
        private System.Windows.Forms.TextBox payByTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.DateTimePicker dateOfInstallmentsDateTimePicker;
        private System.Windows.Forms.TextBox installments_nameTextBox;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource projectLevelBindingSource;
        private System.Windows.Forms.Button ReportBtn;
    }
}