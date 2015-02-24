namespace bero_System.ProjectInstallmentForms
{
    partial class FrmEditProjectInstallment
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
            System.Windows.Forms.Label projectLevelIDLabel;
            System.Windows.Forms.Label activeStatusLabel;
            System.Windows.Forms.Label payDescriptionLabel;
            System.Windows.Forms.Label payByLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label dateOfInstallmentsLabel;
            System.Windows.Forms.Label installments_nameLabel;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.SaveBtn = new Telerik.WinControls.UI.RadButton();
            this.projectLevelComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.payDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.payByTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.dateOfInstallmentsDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.installments_nameTextBox = new System.Windows.Forms.TextBox();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            projectLevelIDLabel = new System.Windows.Forms.Label();
            activeStatusLabel = new System.Windows.Forms.Label();
            payDescriptionLabel = new System.Windows.Forms.Label();
            payByLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            dateOfInstallmentsLabel = new System.Windows.Forms.Label();
            installments_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // projectLevelIDLabel
            // 
            projectLevelIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            projectLevelIDLabel.AutoSize = true;
            projectLevelIDLabel.Location = new System.Drawing.Point(269, 199);
            projectLevelIDLabel.Name = "projectLevelIDLabel";
            projectLevelIDLabel.Size = new System.Drawing.Size(100, 13);
            projectLevelIDLabel.TabIndex = 20;
            projectLevelIDLabel.Text = "المستوى المخصص:";
            // 
            // activeStatusLabel
            // 
            activeStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            activeStatusLabel.AutoSize = true;
            activeStatusLabel.Location = new System.Drawing.Point(274, 169);
            activeStatusLabel.Name = "activeStatusLabel";
            activeStatusLabel.Size = new System.Drawing.Size(36, 13);
            activeStatusLabel.TabIndex = 19;
            activeStatusLabel.Text = "الحالة:";
            // 
            // payDescriptionLabel
            // 
            payDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            payDescriptionLabel.AutoSize = true;
            payDescriptionLabel.Location = new System.Drawing.Point(274, 138);
            payDescriptionLabel.Name = "payDescriptionLabel";
            payDescriptionLabel.Size = new System.Drawing.Size(61, 13);
            payDescriptionLabel.TabIndex = 18;
            payDescriptionLabel.Text = "وصف الدفع:";
            // 
            // payByLabel
            // 
            payByLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            payByLabel.AutoSize = true;
            payByLabel.Location = new System.Drawing.Point(274, 111);
            payByLabel.Name = "payByLabel";
            payByLabel.Size = new System.Drawing.Size(66, 13);
            payByLabel.TabIndex = 17;
            payByLabel.Text = "دفع بواسطة:";
            // 
            // amountLabel
            // 
            amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(274, 81);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(38, 13);
            amountLabel.TabIndex = 16;
            amountLabel.Text = "المبلغ:";
            // 
            // dateOfInstallmentsLabel
            // 
            dateOfInstallmentsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            dateOfInstallmentsLabel.AutoSize = true;
            dateOfInstallmentsLabel.Location = new System.Drawing.Point(269, 52);
            dateOfInstallmentsLabel.Name = "dateOfInstallmentsLabel";
            dateOfInstallmentsLabel.Size = new System.Drawing.Size(58, 13);
            dateOfInstallmentsLabel.TabIndex = 15;
            dateOfInstallmentsLabel.Text = "تاريخ الدفع:";
            // 
            // installments_nameLabel
            // 
            installments_nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            installments_nameLabel.AutoSize = true;
            installments_nameLabel.Location = new System.Drawing.Point(270, 24);
            installments_nameLabel.Name = "installments_nameLabel";
            installments_nameLabel.Size = new System.Drawing.Size(68, 13);
            installments_nameLabel.TabIndex = 14;
            installments_nameLabel.Text = "اسم القسط:";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(projectLevelIDLabel);
            this.radGroupBox1.Controls.Add(this.SaveBtn);
            this.radGroupBox1.Controls.Add(activeStatusLabel);
            this.radGroupBox1.Controls.Add(this.projectLevelComboBox);
            this.radGroupBox1.Controls.Add(payDescriptionLabel);
            this.radGroupBox1.Controls.Add(this.comboBox1);
            this.radGroupBox1.Controls.Add(payByLabel);
            this.radGroupBox1.Controls.Add(this.payDescriptionTextBox);
            this.radGroupBox1.Controls.Add(amountLabel);
            this.radGroupBox1.Controls.Add(this.payByTextBox);
            this.radGroupBox1.Controls.Add(dateOfInstallmentsLabel);
            this.radGroupBox1.Controls.Add(installments_nameLabel);
            this.radGroupBox1.Controls.Add(this.amountTextBox);
            this.radGroupBox1.Controls.Add(this.dateOfInstallmentsDateTimePicker);
            this.radGroupBox1.Controls.Add(this.installments_nameTextBox);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(371, 298);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.ThemeName = "Office2013Light";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.Image = global::bero_System.Properties.Resources.Save;
            this.SaveBtn.Location = new System.Drawing.Point(256, 250);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(110, 36);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "حفظ";
            this.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBtn.ThemeName = "Office2013Light";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // projectLevelComboBox
            // 
            this.projectLevelComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            gridViewTextBoxColumn1.HeaderText = "اسم المستوى";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "LevelName";
            gridViewTextBoxColumn1.Width = 74;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Descripotion";
            gridViewTextBoxColumn2.HeaderText = "الوصف";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Descripotion";
            gridViewTextBoxColumn2.Width = 86;
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<double>);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "LevelAmount";
            gridViewDecimalColumn2.HeaderText = "الموازنة";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "LevelAmount";
            gridViewDecimalColumn2.Width = 62;
            this.projectLevelComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn2});
            this.projectLevelComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.projectLevelComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.projectLevelComboBox.EditorControl.Name = "NestedRadGridView";
            this.projectLevelComboBox.EditorControl.ReadOnly = true;
            this.projectLevelComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.projectLevelComboBox.EditorControl.ShowGroupPanel = false;
            this.projectLevelComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.projectLevelComboBox.EditorControl.TabIndex = 0;
            this.projectLevelComboBox.Enabled = false;
            this.projectLevelComboBox.Location = new System.Drawing.Point(48, 196);
            this.projectLevelComboBox.Name = "projectLevelComboBox";
            this.projectLevelComboBox.Size = new System.Drawing.Size(219, 20);
            this.projectLevelComboBox.TabIndex = 7;
            this.projectLevelComboBox.TabStop = false;
            this.projectLevelComboBox.ThemeName = "Office2013Light";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "تمت الجدولة",
            "تم الدفع",
            "غير مكتمل"});
            this.comboBox1.Location = new System.Drawing.Point(147, 166);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // payDescriptionTextBox
            // 
            this.payDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.payDescriptionTextBox.Location = new System.Drawing.Point(168, 135);
            this.payDescriptionTextBox.Name = "payDescriptionTextBox";
            this.payDescriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.payDescriptionTextBox.TabIndex = 5;
            // 
            // payByTextBox
            // 
            this.payByTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.payByTextBox.Location = new System.Drawing.Point(168, 104);
            this.payByTextBox.Name = "payByTextBox";
            this.payByTextBox.Size = new System.Drawing.Size(100, 20);
            this.payByTextBox.TabIndex = 4;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountTextBox.Location = new System.Drawing.Point(141, 78);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(127, 20);
            this.amountTextBox.TabIndex = 3;
            this.amountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountTextBox_KeyPress);
            // 
            // dateOfInstallmentsDateTimePicker
            // 
            this.dateOfInstallmentsDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateOfInstallmentsDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.dateOfInstallmentsDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfInstallmentsDateTimePicker.Location = new System.Drawing.Point(168, 46);
            this.dateOfInstallmentsDateTimePicker.Name = "dateOfInstallmentsDateTimePicker";
            this.dateOfInstallmentsDateTimePicker.Size = new System.Drawing.Size(99, 20);
            this.dateOfInstallmentsDateTimePicker.TabIndex = 5;
            // 
            // installments_nameTextBox
            // 
            this.installments_nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.installments_nameTextBox.Location = new System.Drawing.Point(34, 20);
            this.installments_nameTextBox.Name = "installments_nameTextBox";
            this.installments_nameTextBox.Size = new System.Drawing.Size(233, 20);
            this.installments_nameTextBox.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmEditProjectInstallment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 298);
            this.Controls.Add(this.radGroupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(379, 329);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(379, 329);
            this.Name = "FrmEditProjectInstallment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(379, 329);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل  قسط لمشروع";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.FrmEditProjectInstallment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox payDescriptionTextBox;
        private System.Windows.Forms.TextBox payByTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.DateTimePicker dateOfInstallmentsDateTimePicker;
        private System.Windows.Forms.TextBox installments_nameTextBox;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private Telerik.WinControls.UI.RadButton SaveBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public Telerik.WinControls.UI.RadMultiColumnComboBox projectLevelComboBox;
    }
}