namespace bero_System.MainScenarioForms
{
    partial class FrmMainProjectsCustomer
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
            System.Windows.Forms.Label no_buildingLabel;
            System.Windows.Forms.Label no_permissibilityLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label customerNameLabel;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.no_buildingTextBox = new System.Windows.Forms.TextBox();
            this.no_permissibilityTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.ProjectGridView = new Telerik.WinControls.UI.RadGridView();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            no_buildingLabel = new System.Windows.Forms.Label();
            no_permissibilityLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            customerNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // no_buildingLabel
            // 
            no_buildingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            no_buildingLabel.AutoSize = true;
            no_buildingLabel.Location = new System.Drawing.Point(491, 75);
            no_buildingLabel.Name = "no_buildingLabel";
            no_buildingLabel.Size = new System.Drawing.Size(63, 13);
            no_buildingLabel.TabIndex = 14;
            no_buildingLabel.Text = "رقم المبنى:";
            // 
            // no_permissibilityLabel
            // 
            no_permissibilityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            no_permissibilityLabel.AutoSize = true;
            no_permissibilityLabel.Location = new System.Drawing.Point(190, 75);
            no_permissibilityLabel.Name = "no_permissibilityLabel";
            no_permissibilityLabel.Size = new System.Drawing.Size(101, 13);
            no_permissibilityLabel.TabIndex = 12;
            no_permissibilityLabel.Text = "رقم الوحدة السكنية:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(754, 75);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(59, 13);
            phoneNumberLabel.TabIndex = 9;
            phoneNumberLabel.Text = "رقم الهاتف:";
            // 
            // customerNameLabel
            // 
            customerNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new System.Drawing.Point(750, 35);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(70, 13);
            customerNameLabel.TabIndex = 7;
            customerNameLabel.Text = " اسم العميل:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(819, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 476);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(819, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(no_buildingLabel);
            this.radGroupBox1.Controls.Add(this.no_buildingTextBox);
            this.radGroupBox1.Controls.Add(no_permissibilityLabel);
            this.radGroupBox1.Controls.Add(this.no_permissibilityTextBox);
            this.radGroupBox1.Controls.Add(phoneNumberLabel);
            this.radGroupBox1.Controls.Add(this.phoneNumberTextBox);
            this.radGroupBox1.Controls.Add(customerNameLabel);
            this.radGroupBox1.Controls.Add(this.customerNameTextBox);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "بيانات الزبون";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 25);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(819, 121);
            this.radGroupBox1.TabIndex = 2;
            this.radGroupBox1.Text = "بيانات الزبون";
            this.radGroupBox1.ThemeName = "Office2013Light";
            // 
            // no_buildingTextBox
            // 
            this.no_buildingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.no_buildingTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.no_buildingTextBox.Location = new System.Drawing.Point(295, 72);
            this.no_buildingTextBox.Name = "no_buildingTextBox";
            this.no_buildingTextBox.Size = new System.Drawing.Size(194, 20);
            this.no_buildingTextBox.TabIndex = 11;
            // 
            // no_permissibilityTextBox
            // 
            this.no_permissibilityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.no_permissibilityTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.no_permissibilityTextBox.Location = new System.Drawing.Point(12, 72);
            this.no_permissibilityTextBox.Name = "no_permissibilityTextBox";
            this.no_permissibilityTextBox.Size = new System.Drawing.Size(176, 20);
            this.no_permissibilityTextBox.TabIndex = 13;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneNumberTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.phoneNumberTextBox.Location = new System.Drawing.Point(558, 72);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(194, 20);
            this.phoneNumberTextBox.TabIndex = 10;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customerNameTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.customerNameTextBox.Location = new System.Drawing.Point(500, 33);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(248, 20);
            this.customerNameTextBox.TabIndex = 8;
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.ProjectGridView);
            this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox2.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox2.HeaderText = "قائمة مشاريع الزبون";
            this.radGroupBox2.Location = new System.Drawing.Point(0, 146);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(819, 330);
            this.radGroupBox2.TabIndex = 3;
            this.radGroupBox2.Text = "قائمة مشاريع الزبون";
            this.radGroupBox2.ThemeName = "Office2013Light";
            // 
            // ProjectGridView
            // 
            this.ProjectGridView.BackColor = System.Drawing.Color.White;
            this.ProjectGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProjectGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectGridView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProjectGridView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProjectGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProjectGridView.Location = new System.Drawing.Point(2, 18);
            // 
            // ProjectGridView
            // 
            this.ProjectGridView.MasterTemplate.AllowAddNewRow = false;
            this.ProjectGridView.MasterTemplate.AllowSearchRow = true;
            this.ProjectGridView.MasterTemplate.AutoGenerateColumns = false;
            this.ProjectGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID";
            gridViewDecimalColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewDecimalColumn1.Width = 61;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ProjectName";
            gridViewTextBoxColumn1.HeaderText = "اسم المشروع";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "ProjectName";
            gridViewTextBoxColumn1.Width = 107;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "ProjectDescription";
            gridViewTextBoxColumn2.HeaderText = "وصف المشروع";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "ProjectDescription";
            gridViewTextBoxColumn2.Width = 107;
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "ProjectFullAmount";
            gridViewDecimalColumn2.HeaderText = "موازنة المشروع";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "ProjectFullAmount";
            gridViewDecimalColumn2.Width = 107;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "createdDate";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.HeaderText = "تاريخ الاضافة";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "createdDate";
            gridViewDateTimeColumn1.Width = 107;
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.FieldName = "DeliverDate";
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn2.HeaderText = "تاريخ التسليم";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "DeliverDate";
            gridViewDateTimeColumn2.Width = 107;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "SerialNumber";
            gridViewTextBoxColumn3.HeaderText = "SerialNumber";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "SerialNumber";
            gridViewTextBoxColumn3.Width = 191;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "دخول";
            gridViewCommandColumn1.Name = "Enter";
            gridViewCommandColumn1.Width = 70;
            this.ProjectGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn2,
            gridViewDateTimeColumn1,
            gridViewDateTimeColumn2,
            gridViewTextBoxColumn3,
            gridViewCommandColumn1});
            this.ProjectGridView.MasterTemplate.EnableFiltering = true;
            sortDescriptor1.PropertyName = "ID";
            this.ProjectGridView.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.ProjectGridView.Name = "ProjectGridView";
            this.ProjectGridView.ReadOnly = true;
            this.ProjectGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ProjectGridView.Size = new System.Drawing.Size(815, 310);
            this.ProjectGridView.TabIndex = 4;
            this.ProjectGridView.Text = "radGridView1";
            this.ProjectGridView.ThemeName = "Office2013Light";
            // 
            // FrmMainProjectsCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 498);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmMainProjectsCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMainProjectsCustomer";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.FrmMainProjectsCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.TextBox no_buildingTextBox;
        private System.Windows.Forms.TextBox no_permissibilityTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGridView ProjectGridView;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
    }
}