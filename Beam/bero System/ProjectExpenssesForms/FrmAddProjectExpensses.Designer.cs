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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
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
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "id";
            gridViewDecimalColumn1.HeaderText = "id";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "id";
            gridViewDecimalColumn1.Width = 35;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "LevelName";
            gridViewTextBoxColumn1.HeaderText = "المستوى";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "LevelName";
            gridViewTextBoxColumn1.Width = 55;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Descripotion";
            gridViewTextBoxColumn2.HeaderText = "الوصف";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Descripotion";
            gridViewTextBoxColumn2.Width = 98;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "LevelAmount";
            gridViewDecimalColumn2.HeaderText = "الموازنة";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "LevelAmount";
            gridViewDecimalColumn2.Width = 28;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "SerialNumber";
            gridViewTextBoxColumn3.HeaderText = "SerialNumber";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "SerialNumber";
            gridViewTextBoxColumn3.Width = 42;
            this.projectLevelComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn3});
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
            gridViewDecimalColumn3.DataType = typeof(int);
            gridViewDecimalColumn3.EnableExpressionEditor = false;
            gridViewDecimalColumn3.FieldName = "ID";
            gridViewDecimalColumn3.HeaderText = "ID";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.IsVisible = false;
            gridViewDecimalColumn3.Name = "ID";
            gridViewDecimalColumn3.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewDecimalColumn3.Width = 57;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "ExpenssesName";
            gridViewTextBoxColumn4.HeaderText = "نوع المصروف";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "ExpenssesName";
            gridViewTextBoxColumn4.Width = 81;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "Description";
            gridViewTextBoxColumn5.HeaderText = "الوصف";
            gridViewTextBoxColumn5.IsAutoGenerated = true;
            gridViewTextBoxColumn5.Name = "Description";
            gridViewTextBoxColumn5.Width = 95;
            gridViewTextBoxColumn6.DataType = typeof(System.Nullable<System.Guid>);
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "SerialNumber";
            gridViewTextBoxColumn6.HeaderText = "SerialNumber";
            gridViewTextBoxColumn6.IsAutoGenerated = true;
            gridViewTextBoxColumn6.Name = "SerialNumber";
            gridViewTextBoxColumn6.Width = 46;
            this.expenssesComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.expenssesComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.expenssesComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            sortDescriptor1.PropertyName = "ID";
            this.expenssesComboBox.EditorControl.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
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
            this.amountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountTextBox_KeyPress);
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
            this.RootElement.MaxSize = new System.Drawing.Size(329, 336);
            this.ShowIcon = false;
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