﻿namespace bero_System.ProjectForms
{
    partial class FrmManageProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageProject));
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.DGVProducts = new Telerik.WinControls.UI.RadGridView();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBtn,
            this.toolStripSeparator1,
            this.RefreshBtn,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(907, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddBtn
            // 
            this.AddBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddBtn.Image")));
            this.AddBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(89, 22);
            this.AddBtn.Text = "اضافة مشروع";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("RefreshBtn.Image")));
            this.RefreshBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RefreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(95, 22);
            this.RefreshBtn.Text = "تحديث السجلات";
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 535);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(907, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // DGVProducts
            // 
            this.DGVProducts.BackColor = System.Drawing.Color.White;
            this.DGVProducts.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGVProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVProducts.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DGVProducts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DGVProducts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DGVProducts.Location = new System.Drawing.Point(2, 18);
            // 
            // DGVProducts
            // 
            this.DGVProducts.MasterTemplate.AllowAddNewRow = false;
            this.DGVProducts.MasterTemplate.AllowSearchRow = true;
            this.DGVProducts.MasterTemplate.AutoGenerateColumns = false;
            this.DGVProducts.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
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
            gridViewTextBoxColumn1.Width = 99;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "ProjectDescription";
            gridViewTextBoxColumn2.HeaderText = "وصف المشروع";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "ProjectDescription";
            gridViewTextBoxColumn2.Width = 99;
            gridViewDecimalColumn2.DataType = typeof(System.Nullable<double>);
            gridViewDecimalColumn2.EnableExpressionEditor = false;
            gridViewDecimalColumn2.FieldName = "ProjectFullAmount";
            gridViewDecimalColumn2.HeaderText = "موازنة المشروع";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "ProjectFullAmount";
            gridViewDecimalColumn2.Width = 99;
            gridViewDateTimeColumn1.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "createdDate";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.HeaderText = "تاريخ الاضافة";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "createdDate";
            gridViewDateTimeColumn1.Width = 99;
            gridViewDateTimeColumn2.DataType = typeof(System.Nullable<System.DateTime>);
            gridViewDateTimeColumn2.EnableExpressionEditor = false;
            gridViewDateTimeColumn2.FieldName = "DeliverDate";
            gridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn2.HeaderText = "تاريخ التسليم";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "DeliverDate";
            gridViewDateTimeColumn2.Width = 99;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "Customer.CustomerName";
            gridViewTextBoxColumn3.HeaderText = "العميل";
            gridViewTextBoxColumn3.Name = "CustomerName";
            gridViewTextBoxColumn3.Width = 78;
            gridViewTextBoxColumn4.DataType = typeof(System.Nullable<System.Guid>);
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "SerialNumber";
            gridViewTextBoxColumn4.HeaderText = "SerialNumber";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "SerialNumber";
            gridViewTextBoxColumn4.Width = 176;
            gridViewCommandColumn1.EnableExpressionEditor = false;
            gridViewCommandColumn1.HeaderText = "تعديل";
            gridViewCommandColumn1.Name = "EditCol";
            gridViewCommandColumn1.Width = 66;
            gridViewCommandColumn2.EnableExpressionEditor = false;
            gridViewCommandColumn2.HeaderText = "حذف";
            gridViewCommandColumn2.Name = "DleteCol";
            gridViewCommandColumn2.Width = 71;
            this.DGVProducts.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDecimalColumn2,
            gridViewDateTimeColumn1,
            gridViewDateTimeColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewCommandColumn1,
            gridViewCommandColumn2});
            this.DGVProducts.MasterTemplate.EnableFiltering = true;
            sortDescriptor1.PropertyName = "ID";
            this.DGVProducts.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.DGVProducts.Name = "DGVProducts";
            this.DGVProducts.ReadOnly = true;
            this.DGVProducts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGVProducts.Size = new System.Drawing.Size(903, 490);
            this.DGVProducts.TabIndex = 3;
            this.DGVProducts.Text = "radGridView1";
            this.DGVProducts.ThemeName = "Office2013Light";
            this.DGVProducts.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.DGVProducts_CommandCellClick);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.DGVProducts);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "سجلات المشاريع";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 25);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(907, 510);
            this.radGroupBox1.TabIndex = 4;
            this.radGroupBox1.Text = "سجلات المشاريع";
            this.radGroupBox1.ThemeName = "Office2013Light";
            // 
            // FrmManageProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 557);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmManageProject";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmManageProject";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.FrmManageProject_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton RefreshBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Telerik.WinControls.UI.RadGridView DGVProducts;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
    }
}