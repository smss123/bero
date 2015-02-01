namespace bero_System.ProjectExpenssesForms
{
    partial class FrmAddProjectExpensses
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
            System.Windows.Forms.Label expenssesIDLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label dateOfExpenssesLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label label1;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.projectLevelComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.expenssesComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.DateProcessBox = new Telerik.WinControls.UI.RadDateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            expenssesIDLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            dateOfExpenssesLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenssesComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenssesComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenssesComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateProcessBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // expenssesIDLabel
            // 
            expenssesIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            expenssesIDLabel.AutoSize = true;
            expenssesIDLabel.Location = new System.Drawing.Point(238, 35);
            expenssesIDLabel.Name = "expenssesIDLabel";
            expenssesIDLabel.Size = new System.Drawing.Size(53, 13);
            expenssesIDLabel.TabIndex = 0;
            expenssesIDLabel.Text = "المصروف:";
            // 
            // amountLabel
            // 
            amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(239, 67);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(38, 13);
            amountLabel.TabIndex = 2;
            amountLabel.Text = "المبلغ:";
            // 
            // dateOfExpenssesLabel
            // 
            dateOfExpenssesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            dateOfExpenssesLabel.AutoSize = true;
            dateOfExpenssesLabel.Location = new System.Drawing.Point(239, 99);
            dateOfExpenssesLabel.Name = "dateOfExpenssesLabel";
            dateOfExpenssesLabel.Size = new System.Drawing.Size(68, 13);
            dateOfExpenssesLabel.TabIndex = 4;
            dateOfExpenssesLabel.Text = "تاريخ العملية:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(239, 133);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(41, 13);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "الوصف:";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(239, 209);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 13);
            label1.TabIndex = 22;
            label1.Text = "المستوى:";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(label1);
            this.radGroupBox1.Controls.Add(this.projectLevelComboBox);
            this.radGroupBox1.Controls.Add(this.expenssesComboBox);
            this.radGroupBox1.Controls.Add(this.AddBtn);
            this.radGroupBox1.Controls.Add(this.DateProcessBox);
            this.radGroupBox1.Controls.Add(descriptionLabel);
            this.radGroupBox1.Controls.Add(this.descriptionTextBox);
            this.radGroupBox1.Controls.Add(dateOfExpenssesLabel);
            this.radGroupBox1.Controls.Add(amountLabel);
            this.radGroupBox1.Controls.Add(this.amountTextBox);
            this.radGroupBox1.Controls.Add(expenssesIDLabel);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(321, 305);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.ThemeName = "Office2013Light";
            // 
            // projectLevelComboBox
            // 
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
            gridViewDecimalColumn4.EnableExpressionEditor = false;
            gridViewDecimalColumn4.FieldName = "id";
            gridViewDecimalColumn4.HeaderText = "id";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.IsVisible = false;
            gridViewDecimalColumn4.Name = "id";
            gridViewDecimalColumn4.Width = 35;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "LevelName";
            gridViewTextBoxColumn7.HeaderText = "المستوى";
            gridViewTextBoxColumn7.IsAutoGenerated = true;
            gridViewTextBoxColumn7.Name = "LevelName";
            gridViewTextBoxColumn7.Width = 55;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "Descripotion";
            gridViewTextBoxColumn8.HeaderText = "الوصف";
            gridViewTextBoxColumn8.IsAutoGenerated = true;
            gridViewTextBoxColumn8.Name = "Descripotion";
            gridViewTextBoxColumn8.Width = 98;
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "LevelAmount";
            gridViewDecimalColumn5.HeaderText = "الموازنة";
            gridViewDecimalColumn5.IsAutoGenerated = true;
            gridViewDecimalColumn5.Name = "LevelAmount";
            gridViewDecimalColumn5.Width = 28;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "SerialNumber";
            gridViewTextBoxColumn9.HeaderText = "SerialNumber";
            gridViewTextBoxColumn9.IsAutoGenerated = true;
            gridViewTextBoxColumn9.Name = "SerialNumber";
            gridViewTextBoxColumn9.Width = 42;
            this.projectLevelComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn4,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewDecimalColumn5,
            gridViewTextBoxColumn9});
            this.projectLevelComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.projectLevelComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.projectLevelComboBox.EditorControl.Name = "NestedRadGridView";
            this.projectLevelComboBox.EditorControl.ReadOnly = true;
            this.projectLevelComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.projectLevelComboBox.EditorControl.ShowGroupPanel = false;
            this.projectLevelComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.projectLevelComboBox.EditorControl.TabIndex = 0;
            this.projectLevelComboBox.Location = new System.Drawing.Point(26, 206);
            this.projectLevelComboBox.Name = "projectLevelComboBox";
            this.projectLevelComboBox.Size = new System.Drawing.Size(210, 20);
            this.projectLevelComboBox.TabIndex = 21;
            this.projectLevelComboBox.TabStop = false;
            this.projectLevelComboBox.ThemeName = "Office2013Light";
            this.projectLevelComboBox.SelectedIndexChanged += new System.EventHandler(this.projectLevelComboBox_SelectedIndexChanged);
            // 
            // expenssesComboBox
            // 
            // 
            // expenssesComboBox.NestedRadGridView
            // 
            this.expenssesComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.expenssesComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.expenssesComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.expenssesComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.expenssesComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.expenssesComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.expenssesComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.expenssesComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.expenssesComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.expenssesComboBox.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            this.expenssesComboBox.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn6.DataType = typeof(int);
            gridViewDecimalColumn6.EnableExpressionEditor = false;
            gridViewDecimalColumn6.FieldName = "ID";
            gridViewDecimalColumn6.HeaderText = "ID";
            gridViewDecimalColumn6.IsAutoGenerated = true;
            gridViewDecimalColumn6.IsVisible = false;
            gridViewDecimalColumn6.Name = "ID";
            gridViewDecimalColumn6.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewDecimalColumn6.Width = 57;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "ExpenssesName";
            gridViewTextBoxColumn10.HeaderText = "نوع المصروف";
            gridViewTextBoxColumn10.IsAutoGenerated = true;
            gridViewTextBoxColumn10.Name = "ExpenssesName";
            gridViewTextBoxColumn10.Width = 81;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "Description";
            gridViewTextBoxColumn11.HeaderText = "الوصف";
            gridViewTextBoxColumn11.IsAutoGenerated = true;
            gridViewTextBoxColumn11.Name = "Description";
            gridViewTextBoxColumn11.Width = 95;
            gridViewTextBoxColumn12.DataType = typeof(System.Nullable<System.Guid>);
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.FieldName = "SerialNumber";
            gridViewTextBoxColumn12.HeaderText = "SerialNumber";
            gridViewTextBoxColumn12.IsAutoGenerated = true;
            gridViewTextBoxColumn12.Name = "SerialNumber";
            gridViewTextBoxColumn12.Width = 46;
            this.expenssesComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn6,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12});
            this.expenssesComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.expenssesComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            sortDescriptor2.PropertyName = "ID";
            this.expenssesComboBox.EditorControl.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.expenssesComboBox.EditorControl.Name = "NestedRadGridView";
            this.expenssesComboBox.EditorControl.ReadOnly = true;
            this.expenssesComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.expenssesComboBox.EditorControl.ShowGroupPanel = false;
            this.expenssesComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.expenssesComboBox.EditorControl.TabIndex = 0;
            this.expenssesComboBox.Location = new System.Drawing.Point(26, 32);
            this.expenssesComboBox.Name = "expenssesComboBox";
            this.expenssesComboBox.Size = new System.Drawing.Size(210, 20);
            this.expenssesComboBox.TabIndex = 20;
            this.expenssesComboBox.TabStop = false;
            this.expenssesComboBox.ThemeName = "Office2013Light";
            this.expenssesComboBox.SelectedIndexChanged += new System.EventHandler(this.expenssesComboBox_SelectedIndexChanged);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Image = global::bero_System.Properties.Resources.Add;
            this.AddBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.Location = new System.Drawing.Point(199, 257);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(110, 36);
            this.AddBtn.TabIndex = 19;
            this.AddBtn.Text = "اضافة";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.ThemeName = "Office2013Light";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DateProcessBox
            // 
            this.DateProcessBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateProcessBox.CustomFormat = "d";
            this.DateProcessBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateProcessBox.Location = new System.Drawing.Point(130, 96);
            this.DateProcessBox.Name = "DateProcessBox";
            this.DateProcessBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateProcessBox.Size = new System.Drawing.Size(106, 21);
            this.DateProcessBox.TabIndex = 18;
            this.DateProcessBox.TabStop = false;
            this.DateProcessBox.Text = "1/12/2015";
            this.DateProcessBox.ThemeName = "Office2013Light";
            this.DateProcessBox.Value = new System.DateTime(2015, 1, 12, 23, 5, 45, 544);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.descriptionTextBox.Location = new System.Drawing.Point(26, 130);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(210, 69);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.amountTextBox.Location = new System.Drawing.Point(26, 64);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(210, 20);
            this.amountTextBox.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddProjectExpensses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 305);
            this.Controls.Add(this.radGroupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(329, 336);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(329, 336);
            this.Name = "FrmAddProjectExpensses";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة مصروف لمشروع";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.FrmAddProjectExpensses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenssesComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenssesComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenssesComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateProcessBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private Telerik.WinControls.UI.RadDateTimePicker DateProcessBox;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private Telerik.WinControls.UI.RadMultiColumnComboBox expenssesComboBox;
        private Telerik.WinControls.UI.RadMultiColumnComboBox projectLevelComboBox;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}