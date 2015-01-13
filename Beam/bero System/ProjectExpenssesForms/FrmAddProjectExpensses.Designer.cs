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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.radDateTimePicker1 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.expenssesComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.projectExpenssBindingSource = new System.Windows.Forms.BindingSource(this.components);
            expenssesIDLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            dateOfExpenssesLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenssesComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenssesComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenssesComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectExpenssBindingSource)).BeginInit();
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
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.expenssesComboBox);
            this.radGroupBox1.Controls.Add(this.AddBtn);
            this.radGroupBox1.Controls.Add(this.radDateTimePicker1);
            this.radGroupBox1.Controls.Add(descriptionLabel);
            this.radGroupBox1.Controls.Add(this.descriptionTextBox);
            this.radGroupBox1.Controls.Add(dateOfExpenssesLabel);
            this.radGroupBox1.Controls.Add(amountLabel);
            this.radGroupBox1.Controls.Add(this.amountTextBox);
            this.radGroupBox1.Controls.Add(expenssesIDLabel);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "radGroupBox1";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(321, 266);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "radGroupBox1";
            this.radGroupBox1.ThemeName = "Office2013Light";
            this.radGroupBox1.Click += new System.EventHandler(this.radGroupBox1_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Location = new System.Drawing.Point(197, 225);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(110, 36);
            this.AddBtn.TabIndex = 19;
            this.AddBtn.Text = "اضافة";
            this.AddBtn.ThemeName = "Office2013Light";
            // 
            // radDateTimePicker1
            // 
            this.radDateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radDateTimePicker1.CustomFormat = "d";
            this.radDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.radDateTimePicker1.Location = new System.Drawing.Point(130, 96);
            this.radDateTimePicker1.Name = "radDateTimePicker1";
            this.radDateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radDateTimePicker1.Size = new System.Drawing.Size(106, 21);
            this.radDateTimePicker1.TabIndex = 18;
            this.radDateTimePicker1.TabStop = false;
            this.radDateTimePicker1.Text = "12/01/15";
            this.radDateTimePicker1.ThemeName = "Office2013Light";
            this.radDateTimePicker1.Value = new System.DateTime(2015, 1, 12, 23, 5, 45, 544);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectExpenssBindingSource, "Description", true));
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
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectExpenssBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(26, 64);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(210, 20);
            this.amountTextBox.TabIndex = 3;
            // 
            // expenssesComboBox
            // 
            // 
            // expenssesComboBox.NestedRadGridView
            // 
            this.expenssesComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.expenssesComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.expenssesComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.expenssesComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.expenssesComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.expenssesComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.expenssesComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.expenssesComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.expenssesComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
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
            // 
            // projectExpenssBindingSource
            // 
            this.projectExpenssBindingSource.DataSource = typeof(DataLayer.ProjectExpenss);
            // 
            // FrmAddProjectExpensses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 266);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "FrmAddProjectExpensses";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddProjectExpensses";
            this.ThemeName = "Office2013Light";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenssesComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenssesComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenssesComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectExpenssBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.BindingSource projectExpenssBindingSource;
        private System.Windows.Forms.TextBox amountTextBox;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker1;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private Telerik.WinControls.UI.RadMultiColumnComboBox expenssesComboBox;
    }
}