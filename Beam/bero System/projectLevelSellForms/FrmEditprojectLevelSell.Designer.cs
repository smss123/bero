namespace bero_System.projectLevelSellForms
{
    partial class FrmEditprojectLevelSell
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
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label dateOfSellLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label sell_ItemLabel;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.projectLevelComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.SaveBtn = new Telerik.WinControls.UI.RadButton();
            this.radDateTimePicker1 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.sell_ItemTextBox = new System.Windows.Forms.TextBox();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            projectLevelIDLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            dateOfSellLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            sell_ItemLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // projectLevelIDLabel
            // 
            projectLevelIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            projectLevelIDLabel.AutoSize = true;
            projectLevelIDLabel.Location = new System.Drawing.Point(264, 199);
            projectLevelIDLabel.Name = "projectLevelIDLabel";
            projectLevelIDLabel.Size = new System.Drawing.Size(58, 13);
            projectLevelIDLabel.TabIndex = 10;
            projectLevelIDLabel.Text = "المستوى :";
            // 
            // statusLabel
            // 
            statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(265, 170);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(36, 13);
            statusLabel.TabIndex = 8;
            statusLabel.Text = "الحالة:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(268, 110);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(41, 13);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "الوصف:";
            // 
            // dateOfSellLabel
            // 
            dateOfSellLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            dateOfSellLabel.AutoSize = true;
            dateOfSellLabel.Location = new System.Drawing.Point(264, 77);
            dateOfSellLabel.Name = "dateOfSellLabel";
            dateOfSellLabel.Size = new System.Drawing.Size(68, 13);
            dateOfSellLabel.TabIndex = 4;
            dateOfSellLabel.Text = "تاريخ العملية:";
            // 
            // amountLabel
            // 
            amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(267, 51);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(43, 13);
            amountLabel.TabIndex = 2;
            amountLabel.Text = "التكلفة:";
            // 
            // sell_ItemLabel
            // 
            sell_ItemLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            sell_ItemLabel.AutoSize = true;
            sell_ItemLabel.Location = new System.Drawing.Point(267, 25);
            sell_ItemLabel.Name = "sell_ItemLabel";
            sell_ItemLabel.Size = new System.Drawing.Size(37, 13);
            sell_ItemLabel.TabIndex = 0;
            sell_ItemLabel.Text = "الوصف";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.projectLevelComboBox);
            this.radGroupBox1.Controls.Add(this.SaveBtn);
            this.radGroupBox1.Controls.Add(this.radDateTimePicker1);
            this.radGroupBox1.Controls.Add(projectLevelIDLabel);
            this.radGroupBox1.Controls.Add(statusLabel);
            this.radGroupBox1.Controls.Add(this.statusComboBox);
            this.radGroupBox1.Controls.Add(descriptionLabel);
            this.radGroupBox1.Controls.Add(this.descriptionTextBox);
            this.radGroupBox1.Controls.Add(dateOfSellLabel);
            this.radGroupBox1.Controls.Add(amountLabel);
            this.radGroupBox1.Controls.Add(this.amountTextBox);
            this.radGroupBox1.Controls.Add(sell_ItemLabel);
            this.radGroupBox1.Controls.Add(this.sell_ItemTextBox);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(336, 279);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.ThemeName = "Office2013Light";
            // 
            // projectLevelComboBox
            // 
            this.projectLevelComboBox.BackColor = System.Drawing.SystemColors.Info;
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
            gridViewDecimalColumn1.Width = 121;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "LevelName";
            gridViewTextBoxColumn1.HeaderText = "اسم المستوى";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "LevelName";
            gridViewTextBoxColumn1.Width = 78;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Descripotion";
            gridViewTextBoxColumn2.HeaderText = "الوصف";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Descripotion";
            gridViewTextBoxColumn2.Width = 66;
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<double>);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "LevelAmount";
            gridViewDecimalColumn2.HeaderText = "الموازنة";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "LevelAmount";
            gridViewDecimalColumn2.Width = 39;
            gridViewTextBoxColumn3.DataType = typeof(System.Nullable<System.Guid>);
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "SerialNumber";
            gridViewTextBoxColumn3.HeaderText = "SerialNumber";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "SerialNumber";
            gridViewTextBoxColumn3.Width = 40;
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
            this.projectLevelComboBox.Enabled = false;
            this.projectLevelComboBox.Location = new System.Drawing.Point(23, 197);
            this.projectLevelComboBox.Name = "projectLevelComboBox";
            this.projectLevelComboBox.Size = new System.Drawing.Size(241, 20);
            this.projectLevelComboBox.TabIndex = 20;
            this.projectLevelComboBox.TabStop = false;
            this.projectLevelComboBox.ThemeName = "Office2013Light";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.Image = global::bero_System.Properties.Resources.Save;
            this.SaveBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveBtn.Location = new System.Drawing.Point(214, 232);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(110, 36);
            this.SaveBtn.TabIndex = 19;
            this.SaveBtn.Text = "حفظ";
            this.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBtn.ThemeName = "Office2013Light";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // radDateTimePicker1
            // 
            this.radDateTimePicker1.BackColor = System.Drawing.SystemColors.Info;
            this.radDateTimePicker1.CustomFormat = "d";
            this.radDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.radDateTimePicker1.Location = new System.Drawing.Point(166, 74);
            this.radDateTimePicker1.Name = "radDateTimePicker1";
            this.radDateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radDateTimePicker1.Size = new System.Drawing.Size(98, 21);
            this.radDateTimePicker1.TabIndex = 18;
            this.radDateTimePicker1.TabStop = false;
            this.radDateTimePicker1.Text = "1/26/2015";
            this.radDateTimePicker1.ThemeName = "Office2013Light";
            this.radDateTimePicker1.Value = new System.DateTime(2015, 1, 26, 0, 0, 0, 0);
            // 
            // statusComboBox
            // 
            this.statusComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.statusComboBox.BackColor = System.Drawing.SystemColors.Info;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(127, 167);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(137, 21);
            this.statusComboBox.TabIndex = 9;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 103);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(251, 57);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.amountTextBox.Location = new System.Drawing.Point(99, 48);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(165, 20);
            this.amountTextBox.TabIndex = 3;
            this.amountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountTextBox_KeyPress);
            // 
            // sell_ItemTextBox
            // 
            this.sell_ItemTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sell_ItemTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.sell_ItemTextBox.Location = new System.Drawing.Point(17, 22);
            this.sell_ItemTextBox.Name = "sell_ItemTextBox";
            this.sell_ItemTextBox.Size = new System.Drawing.Size(247, 20);
            this.sell_ItemTextBox.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // FrmEditprojectLevelSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 279);
            this.Controls.Add(this.radGroupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(344, 310);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(344, 310);
            this.Name = "FrmEditprojectLevelSell";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(344, 310);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل المشتريات للمشروع";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.FrmEditprojectLevelSell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton SaveBtn;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker1;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox sell_ItemTextBox;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public Telerik.WinControls.UI.RadMultiColumnComboBox projectLevelComboBox;

    }
}