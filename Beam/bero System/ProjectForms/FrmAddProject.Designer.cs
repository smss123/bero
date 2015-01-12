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
            System.Windows.Forms.Label projectNameLabel;
            System.Windows.Forms.Label projectFullAmountLabel;
            System.Windows.Forms.Label projectDescriptionLabel;
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label label1;
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.CustomerComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.projectDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.projectFullAmountTextBox = new System.Windows.Forms.TextBox();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.radDateTimePicker1 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.object_77c47ca6_f4db_413a_9876_66f5e21071bc = new Telerik.WinControls.RootRadElement();
            projectNameLabel = new System.Windows.Forms.Label();
            projectFullAmountLabel = new System.Windows.Forms.Label();
            projectDescriptionLabel = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // projectNameLabel
            // 
            projectNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            projectNameLabel.AutoSize = true;
            projectNameLabel.Location = new System.Drawing.Point(254, 33);
            projectNameLabel.Name = "projectNameLabel";
            projectNameLabel.Size = new System.Drawing.Size(82, 13);
            projectNameLabel.TabIndex = 0;
            projectNameLabel.Text = "اسم المشرورع:";
            // 
            // projectFullAmountLabel
            // 
            projectFullAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            projectFullAmountLabel.AutoSize = true;
            projectFullAmountLabel.Location = new System.Drawing.Point(254, 63);
            projectFullAmountLabel.Name = "projectFullAmountLabel";
            projectFullAmountLabel.Size = new System.Drawing.Size(83, 13);
            projectFullAmountLabel.TabIndex = 2;
            projectFullAmountLabel.Text = "موازنة المشروع:";
            // 
            // projectDescriptionLabel
            // 
            projectDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            projectDescriptionLabel.AutoSize = true;
            projectDescriptionLabel.Location = new System.Drawing.Point(255, 89);
            projectDescriptionLabel.Name = "projectDescriptionLabel";
            projectDescriptionLabel.Size = new System.Drawing.Size(80, 13);
            projectDescriptionLabel.TabIndex = 4;
            projectDescriptionLabel.Text = "وصف المشروع:";
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
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(label1);
            this.radGroupBox1.Controls.Add(this.radDateTimePicker1);
            this.radGroupBox1.Controls.Add(this.AddBtn);
            this.radGroupBox1.Controls.Add(this.CustomerComboBox);
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
            this.radGroupBox1.Size = new System.Drawing.Size(349, 257);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "radGroupBox1";
            this.radGroupBox1.ThemeName = "Office2013Light";
            // 
            // CustomerComboBox
            // 
            this.CustomerComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerComboBox.BackColor = System.Drawing.SystemColors.Menu;
            // 
            // CustomerComboBox.NestedRadGridView
            // 
            this.CustomerComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.CustomerComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CustomerComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CustomerComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // CustomerComboBox.NestedRadGridView
            // 
            this.CustomerComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.CustomerComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.CustomerComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
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
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Location = new System.Drawing.Point(234, 216);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(110, 36);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "اضافة";
            this.AddBtn.ThemeName = "Office2013Light";
            // 
            // radDateTimePicker1
            // 
            this.radDateTimePicker1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.radDateTimePicker1.Location = new System.Drawing.Point(126, 144);
            this.radDateTimePicker1.Name = "radDateTimePicker1";
            this.radDateTimePicker1.Size = new System.Drawing.Size(124, 21);
            this.radDateTimePicker1.TabIndex = 7;
            this.radDateTimePicker1.TabStop = false;
            this.radDateTimePicker1.Text = "12 يناير, 2015";
            this.radDateTimePicker1.ThemeName = "Office2013Light";
            this.radDateTimePicker1.Value = new System.DateTime(2015, 1, 12, 23, 5, 45, 544);
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radDateTimePicker1.GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(254, 147);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 13);
            label1.TabIndex = 8;
            label1.Text = "تار يخ التسليم:";
            // 
            // object_77c47ca6_f4db_413a_9876_66f5e21071bc
            // 
            this.object_77c47ca6_f4db_413a_9876_66f5e21071bc.Name = "object_77c47ca6_f4db_413a_9876_66f5e21071bc";
            this.object_77c47ca6_f4db_413a_9876_66f5e21071bc.StretchHorizontally = true;
            this.object_77c47ca6_f4db_413a_9876_66f5e21071bc.StretchVertically = true;
            // 
            // FrmAddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 257);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "FrmAddProject";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddProject";
            this.ThemeName = "Office2013Light";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox CustomerComboBox;
        private System.Windows.Forms.TextBox projectDescriptionTextBox;
        private System.Windows.Forms.TextBox projectFullAmountTextBox;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker1;
        private Telerik.WinControls.RootRadElement object_77c47ca6_f4db_413a_9876_66f5e21071bc;
    }
}