namespace bero_System.AccountForms
{
    partial class FrmAddExpenssesMovment
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
            System.Windows.Forms.Label descriptionLabel;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.expenssesComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            expenssesIDLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenssesComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenssesComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenssesComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // expenssesIDLabel
            // 
            expenssesIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            expenssesIDLabel.AutoSize = true;
            expenssesIDLabel.Location = new System.Drawing.Point(289, 26);
            expenssesIDLabel.Name = "expenssesIDLabel";
            expenssesIDLabel.Size = new System.Drawing.Size(53, 13);
            expenssesIDLabel.TabIndex = 0;
            expenssesIDLabel.Text = "المصروف:";
            // 
            // amountLabel
            // 
            amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(286, 53);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(43, 13);
            amountLabel.TabIndex = 2;
            amountLabel.Text = "التكلفة:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(287, 79);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(41, 13);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "الوصف:";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.AddBtn);
            this.radGroupBox1.Controls.Add(descriptionLabel);
            this.radGroupBox1.Controls.Add(this.descriptionTextBox);
            this.radGroupBox1.Controls.Add(amountLabel);
            this.radGroupBox1.Controls.Add(this.amountTextBox);
            this.radGroupBox1.Controls.Add(this.expenssesComboBox);
            this.radGroupBox1.Controls.Add(expenssesIDLabel);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "radGroupBox1";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(347, 207);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "radGroupBox1";
            this.radGroupBox1.ThemeName = "Office2013Light";
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Location = new System.Drawing.Point(225, 159);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(110, 36);
            this.AddBtn.TabIndex = 8;
            this.AddBtn.Text = "اضافة";
            this.AddBtn.ThemeName = "Office2013Light";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.Location = new System.Drawing.Point(25, 76);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(260, 67);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountTextBox.Location = new System.Drawing.Point(116, 49);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(167, 20);
            this.amountTextBox.TabIndex = 3;
            // 
            // expenssesComboBox
            // 
            this.expenssesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "ID";
            gridViewDecimalColumn2.HeaderText = "ID";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "ID";
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "ExpenssesName";
            gridViewTextBoxColumn4.HeaderText = "اسم المصروف";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "ExpenssesName";
            gridViewTextBoxColumn4.Width = 67;
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
            gridViewTextBoxColumn6.Width = 60;
            this.expenssesComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn2,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.expenssesComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.expenssesComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.expenssesComboBox.EditorControl.Name = "NestedRadGridView";
            this.expenssesComboBox.EditorControl.ReadOnly = true;
            this.expenssesComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.expenssesComboBox.EditorControl.ShowGroupPanel = false;
            this.expenssesComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.expenssesComboBox.EditorControl.TabIndex = 0;
            this.expenssesComboBox.Location = new System.Drawing.Point(25, 23);
            this.expenssesComboBox.Name = "expenssesComboBox";
            this.expenssesComboBox.Size = new System.Drawing.Size(260, 20);
            this.expenssesComboBox.TabIndex = 1;
            this.expenssesComboBox.TabStop = false;
            this.expenssesComboBox.ThemeName = "Office2013Light";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // FrmAddExpenssesMovment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 207);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "FrmAddExpenssesMovment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddExpenssesMovment";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.FrmAddExpenssesMovment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenssesComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenssesComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenssesComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private Telerik.WinControls.UI.RadMultiColumnComboBox expenssesComboBox;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}