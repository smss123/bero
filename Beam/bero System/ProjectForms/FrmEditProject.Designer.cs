namespace bero_System.ProjectForms
{
    partial class FrmEditProject
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
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label projectDescriptionLabel;
            System.Windows.Forms.Label projectFullAmountLabel;
            System.Windows.Forms.Label projectNameLabel;
            System.Windows.Forms.Label label1;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.DeliverDateText = new Telerik.WinControls.UI.RadDateTimePicker();
            this.CustomerComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.SaveBtn = new Telerik.WinControls.UI.RadButton();
            this.projectDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.projectFullAmountTextBox = new System.Windows.Forms.TextBox();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            customerIDLabel = new System.Windows.Forms.Label();
            projectDescriptionLabel = new System.Windows.Forms.Label();
            projectFullAmountLabel = new System.Windows.Forms.Label();
            projectNameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeliverDateText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(251, 172);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(42, 13);
            customerIDLabel.TabIndex = 6;
            customerIDLabel.Text = "العميل:";
            // 
            // projectDescriptionLabel
            // 
            projectDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            projectDescriptionLabel.AutoSize = true;
            projectDescriptionLabel.Location = new System.Drawing.Point(256, 89);
            projectDescriptionLabel.Name = "projectDescriptionLabel";
            projectDescriptionLabel.Size = new System.Drawing.Size(80, 13);
            projectDescriptionLabel.TabIndex = 4;
            projectDescriptionLabel.Text = "وصف المشروع:";
            // 
            // projectFullAmountLabel
            // 
            projectFullAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            projectFullAmountLabel.AutoSize = true;
            projectFullAmountLabel.Location = new System.Drawing.Point(255, 63);
            projectFullAmountLabel.Name = "projectFullAmountLabel";
            projectFullAmountLabel.Size = new System.Drawing.Size(83, 13);
            projectFullAmountLabel.TabIndex = 2;
            projectFullAmountLabel.Text = "موازنة المشروع:";
            // 
            // projectNameLabel
            // 
            projectNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            projectNameLabel.AutoSize = true;
            projectNameLabel.Location = new System.Drawing.Point(255, 33);
            projectNameLabel.Name = "projectNameLabel";
            projectNameLabel.Size = new System.Drawing.Size(82, 13);
            projectNameLabel.TabIndex = 0;
            projectNameLabel.Text = "اسم المشرورع:";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(256, 146);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 13);
            label1.TabIndex = 10;
            label1.Text = "تار يخ التسليم:";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(label1);
            this.radGroupBox1.Controls.Add(this.DeliverDateText);
            this.radGroupBox1.Controls.Add(this.CustomerComboBox);
            this.radGroupBox1.Controls.Add(this.SaveBtn);
            this.radGroupBox1.Controls.Add(customerIDLabel);
            this.radGroupBox1.Controls.Add(projectDescriptionLabel);
            this.radGroupBox1.Controls.Add(this.projectDescriptionTextBox);
            this.radGroupBox1.Controls.Add(projectFullAmountLabel);
            this.radGroupBox1.Controls.Add(this.projectFullAmountTextBox);
            this.radGroupBox1.Controls.Add(projectNameLabel);
            this.radGroupBox1.Controls.Add(this.projectNameTextBox);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.HeaderText = "radGroupBox1";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(349, 248);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "radGroupBox1";
            this.radGroupBox1.ThemeName = "Office2013Light";
            // 
            // DeliverDateText
            // 
            this.DeliverDateText.CustomFormat = "d";
            this.DeliverDateText.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DeliverDateText.Location = new System.Drawing.Point(126, 143);
            this.DeliverDateText.Name = "DeliverDateText";
            this.DeliverDateText.Size = new System.Drawing.Size(124, 21);
            this.DeliverDateText.TabIndex = 9;
            this.DeliverDateText.TabStop = false;
            this.DeliverDateText.Text = "1/12/2015";
            this.DeliverDateText.ThemeName = "Office2013Light";
            this.DeliverDateText.Value = new System.DateTime(2015, 1, 12, 23, 5, 45, 544);
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // CustomerComboBox.NestedRadGridView
            // 
            this.CustomerComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.CustomerComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.CustomerComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CustomerComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CustomerComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CustomerComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.CustomerComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.CustomerComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.CustomerComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.CustomerComboBox.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            this.CustomerComboBox.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.Width = 121;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "CustomerName";
            gridViewTextBoxColumn1.HeaderText = "اسم العميل";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "CustomerName";
            gridViewTextBoxColumn1.Width = 62;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "PhoneNumber";
            gridViewTextBoxColumn2.HeaderText = "رقم الهاتف";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "PhoneNumber";
            gridViewTextBoxColumn2.Width = 53;
            gridViewDateTimeColumn1.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "CreateDate";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.HeaderText = "تاريخ الاضافة";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "CreateDate";
            gridViewDateTimeColumn1.Width = 53;
            gridViewTextBoxColumn3.DataType = typeof(System.Nullable<System.Guid>);
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "SerialNumber";
            gridViewTextBoxColumn3.HeaderText = "SerialNumber";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "SerialNumber";
            gridViewTextBoxColumn3.Width = 55;
            this.CustomerComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn3});
            this.CustomerComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.CustomerComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.CustomerComboBox.EditorControl.Name = "NestedRadGridView";
            this.CustomerComboBox.EditorControl.ReadOnly = true;
            this.CustomerComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CustomerComboBox.EditorControl.ShowGroupPanel = false;
            this.CustomerComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.CustomerComboBox.EditorControl.TabIndex = 0;
            this.CustomerComboBox.Location = new System.Drawing.Point(23, 172);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(227, 20);
            this.CustomerComboBox.TabIndex = 7;
            this.CustomerComboBox.TabStop = false;
            this.CustomerComboBox.ThemeName = "Office2013Light";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.Location = new System.Drawing.Point(234, 207);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(110, 36);
            this.SaveBtn.TabIndex = 5;
            this.SaveBtn.Text = "حفظ";
            this.SaveBtn.ThemeName = "Office2013Light";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // projectDescriptionTextBox
            // 
            this.projectDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.projectDescriptionTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.projectDescriptionTextBox.Location = new System.Drawing.Point(21, 82);
            this.projectDescriptionTextBox.Multiline = true;
            this.projectDescriptionTextBox.Name = "projectDescriptionTextBox";
            this.projectDescriptionTextBox.Size = new System.Drawing.Size(229, 55);
            this.projectDescriptionTextBox.TabIndex = 3;
            // 
            // projectFullAmountTextBox
            // 
            this.projectFullAmountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.projectFullAmountTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.projectFullAmountTextBox.Location = new System.Drawing.Point(96, 56);
            this.projectFullAmountTextBox.Name = "projectFullAmountTextBox";
            this.projectFullAmountTextBox.Size = new System.Drawing.Size(154, 20);
            this.projectFullAmountTextBox.TabIndex = 2;
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.projectNameTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.projectNameTextBox.Location = new System.Drawing.Point(21, 30);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(229, 20);
            this.projectNameTextBox.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // FrmEditProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 248);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "FrmEditProject";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditProject";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.FrmEditProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeliverDateText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton SaveBtn;
        private System.Windows.Forms.TextBox projectDescriptionTextBox;
        private System.Windows.Forms.TextBox projectFullAmountTextBox;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private Telerik.WinControls.UI.RadDateTimePicker DeliverDateText;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public Telerik.WinControls.UI.RadMultiColumnComboBox CustomerComboBox;

    }
}