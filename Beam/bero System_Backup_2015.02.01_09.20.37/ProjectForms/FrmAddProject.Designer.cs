namespace bero_System.ProjectForms
{
    partial class FrmAddProject
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label projectDescriptionLabel;
            System.Windows.Forms.Label projectFullAmountLabel;
            System.Windows.Forms.Label projectNameLabel;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.DeliverDateText = new Telerik.WinControls.UI.RadDateTimePicker();
            this.projectDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.projectFullAmountTextBox = new System.Windows.Forms.TextBox();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.CustomerComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.object_77c47ca6_f4db_413a_9876_66f5e21071bc = new Telerik.WinControls.RootRadElement();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            customerIDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            projectDescriptionLabel = new System.Windows.Forms.Label();
            projectFullAmountLabel = new System.Windows.Forms.Label();
            projectNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeliverDateText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(255, 178);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(42, 13);
            customerIDLabel.TabIndex = 6;
            customerIDLabel.Text = "العميل:";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(256, 148);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 13);
            label1.TabIndex = 18;
            label1.Text = "تار يخ التسليم:";
            // 
            // projectDescriptionLabel
            // 
            projectDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            projectDescriptionLabel.AutoSize = true;
            projectDescriptionLabel.Location = new System.Drawing.Point(256, 91);
            projectDescriptionLabel.Name = "projectDescriptionLabel";
            projectDescriptionLabel.Size = new System.Drawing.Size(80, 13);
            projectDescriptionLabel.TabIndex = 16;
            projectDescriptionLabel.Text = "وصف المشروع:";
            // 
            // projectFullAmountLabel
            // 
            projectFullAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            projectFullAmountLabel.AutoSize = true;
            projectFullAmountLabel.Location = new System.Drawing.Point(255, 65);
            projectFullAmountLabel.Name = "projectFullAmountLabel";
            projectFullAmountLabel.Size = new System.Drawing.Size(83, 13);
            projectFullAmountLabel.TabIndex = 13;
            projectFullAmountLabel.Text = "موازنة المشروع:";
            // 
            // projectNameLabel
            // 
            projectNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            projectNameLabel.AutoSize = true;
            projectNameLabel.Location = new System.Drawing.Point(255, 35);
            projectNameLabel.Name = "projectNameLabel";
            projectNameLabel.Size = new System.Drawing.Size(82, 13);
            projectNameLabel.TabIndex = 11;
            projectNameLabel.Text = "اسم المشرورع:";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(label1);
            this.radGroupBox1.Controls.Add(this.DeliverDateText);
            this.radGroupBox1.Controls.Add(projectDescriptionLabel);
            this.radGroupBox1.Controls.Add(this.projectDescriptionTextBox);
            this.radGroupBox1.Controls.Add(projectFullAmountLabel);
            this.radGroupBox1.Controls.Add(this.projectFullAmountTextBox);
            this.radGroupBox1.Controls.Add(projectNameLabel);
            this.radGroupBox1.Controls.Add(this.projectNameTextBox);
            this.radGroupBox1.Controls.Add(this.AddBtn);
            this.radGroupBox1.Controls.Add(this.CustomerComboBox);
            this.radGroupBox1.Controls.Add(customerIDLabel);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(349, 260);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.ThemeName = "Office2013Light";
            // 
            // DeliverDateText
            // 
            this.DeliverDateText.CustomFormat = "d";
            this.DeliverDateText.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DeliverDateText.Location = new System.Drawing.Point(144, 145);
            this.DeliverDateText.Name = "DeliverDateText";
            this.DeliverDateText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DeliverDateText.Size = new System.Drawing.Size(106, 21);
            this.DeliverDateText.TabIndex = 17;
            this.DeliverDateText.TabStop = false;
            this.DeliverDateText.Text = "1/12/2015";
            this.DeliverDateText.ThemeName = "Office2013Light";
            this.DeliverDateText.Value = new System.DateTime(2015, 1, 12, 23, 5, 45, 544);
            // 
            // projectDescriptionTextBox
            // 
            this.projectDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.projectDescriptionTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.projectDescriptionTextBox.Location = new System.Drawing.Point(21, 84);
            this.projectDescriptionTextBox.Multiline = true;
            this.projectDescriptionTextBox.Name = "projectDescriptionTextBox";
            this.projectDescriptionTextBox.Size = new System.Drawing.Size(229, 55);
            this.projectDescriptionTextBox.TabIndex = 15;
            // 
            // projectFullAmountTextBox
            // 
            this.projectFullAmountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.projectFullAmountTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.projectFullAmountTextBox.Location = new System.Drawing.Point(96, 58);
            this.projectFullAmountTextBox.Name = "projectFullAmountTextBox";
            this.projectFullAmountTextBox.Size = new System.Drawing.Size(154, 20);
            this.projectFullAmountTextBox.TabIndex = 14;
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.projectNameTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.projectNameTextBox.Location = new System.Drawing.Point(21, 32);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(229, 20);
            this.projectNameTextBox.TabIndex = 12;
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Image = global::bero_System.Properties.Resources.Add;
            this.AddBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.Location = new System.Drawing.Point(235, 216);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(109, 36);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "اضافة";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.ThemeName = "Office2013Light";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerComboBox.BackColor = System.Drawing.SystemColors.Menu;
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
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "ID";
            gridViewDecimalColumn2.HeaderText = "ID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "ID";
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "CustomerName";
            gridViewTextBoxColumn4.HeaderText = "اسم العميل";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "CustomerName";
            gridViewTextBoxColumn4.Width = 80;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "PhoneNumber";
            gridViewTextBoxColumn5.HeaderText = "رقم الهاتف";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "PhoneNumber";
            gridViewTextBoxColumn5.Width = 55;
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.FieldName = "CreateDate";
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn2.HeaderText = "تاريخ الاضافة";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "CreateDate";
            gridViewDateTimeColumn2.Width = 49;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "SerialNumber";
            gridViewTextBoxColumn6.HeaderText = "SerialNumber";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "SerialNumber";
            gridViewTextBoxColumn6.Width = 39;
            this.CustomerComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn2,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewDateTimeColumn2,
            gridViewTextBoxColumn6});
            this.CustomerComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.CustomerComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.CustomerComboBox.EditorControl.Name = "NestedRadGridView";
            this.CustomerComboBox.EditorControl.ReadOnly = true;
            this.CustomerComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CustomerComboBox.EditorControl.ShowGroupPanel = false;
            this.CustomerComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.CustomerComboBox.EditorControl.TabIndex = 0;
            this.CustomerComboBox.Location = new System.Drawing.Point(21, 173);
            this.CustomerComboBox.Name = "CustomerComboBox";
            this.CustomerComboBox.Size = new System.Drawing.Size(229, 20);
            this.CustomerComboBox.TabIndex = 4;
            this.CustomerComboBox.TabStop = false;
            this.CustomerComboBox.ThemeName = "Office2013Light";
            // 
            // object_77c47ca6_f4db_413a_9876_66f5e21071bc
            // 
            this.object_77c47ca6_f4db_413a_9876_66f5e21071bc.Name = "object_77c47ca6_f4db_413a_9876_66f5e21071bc";
            this.object_77c47ca6_f4db_413a_9876_66f5e21071bc.StretchHorizontally = true;
            this.object_77c47ca6_f4db_413a_9876_66f5e21071bc.StretchVertically = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmAddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 260);
            this.Controls.Add(this.radGroupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(357, 291);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(357, 291);
            this.Name = "FrmAddProject";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة مشروع";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.FrmAddProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeliverDateText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox CustomerComboBox;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private Telerik.WinControls.RootRadElement object_77c47ca6_f4db_413a_9876_66f5e21071bc;
        private Telerik.WinControls.UI.RadDateTimePicker DeliverDateText;
        private System.Windows.Forms.TextBox projectDescriptionTextBox;
        private System.Windows.Forms.TextBox projectFullAmountTextBox;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timer1;
    }
}