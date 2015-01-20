namespace bero_System.ProjectQuantityForms
{
    partial class frmEditProjectQuantity
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
            System.Windows.Forms.Label qtyLabel;
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.ItemComboBox = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.SaveBtn = new Telerik.WinControls.UI.RadButton();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            qtyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemComboBox.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemComboBox.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // qtyLabel
            // 
            qtyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            qtyLabel.AutoSize = true;
            qtyLabel.Location = new System.Drawing.Point(258, 77);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new System.Drawing.Size(40, 13);
            qtyLabel.TabIndex = 2;
            qtyLabel.Text = "الكمية:";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.ItemComboBox);
            this.radGroupBox1.Controls.Add(this.SaveBtn);
            this.radGroupBox1.Controls.Add(qtyLabel);
            this.radGroupBox1.Controls.Add(this.qtyTextBox);
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "radGroupBox1";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(309, 151);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "radGroupBox1";
            this.radGroupBox1.ThemeName = "Office2013Light";
            // 
            // ItemComboBox
            // 
            this.ItemComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemComboBox.DisplayMember = "ItemName";
            // 
            // ItemComboBox.NestedRadGridView
            // 
            this.ItemComboBox.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.ItemComboBox.EditorControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.ItemComboBox.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.ItemComboBox.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ItemComboBox.EditorControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ItemComboBox.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.ItemComboBox.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.ItemComboBox.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.ItemComboBox.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.ItemComboBox.EditorControl.MasterTemplate.AutoGenerateColumns = false;
            this.ItemComboBox.EditorControl.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.EnableExpressionEditor = false;
            gridViewDecimalColumn1.FieldName = "ID";
            gridViewDecimalColumn1.HeaderText = "ID";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "ID";
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ItemName";
            gridViewTextBoxColumn1.HeaderText = "الصنف";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "ItemName";
            gridViewTextBoxColumn1.Width = 79;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "ItemDescription";
            gridViewTextBoxColumn2.HeaderText = "الوصف";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "ItemDescription";
            gridViewTextBoxColumn2.Width = 67;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "ItemSummery";
            gridViewTextBoxColumn3.HeaderText = "اختصار الصنف";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "ItemSummery";
            gridViewTextBoxColumn3.Width = 38;
            gridViewTextBoxColumn4.DataType = typeof(System.Nullable<System.Guid>);
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "SerialNumber";
            gridViewTextBoxColumn4.HeaderText = "SerialNumber";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "SerialNumber";
            gridViewTextBoxColumn4.Width = 39;
            this.ItemComboBox.EditorControl.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.ItemComboBox.EditorControl.MasterTemplate.EnableGrouping = false;
            this.ItemComboBox.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.ItemComboBox.EditorControl.Name = "NestedRadGridView";
            this.ItemComboBox.EditorControl.ReadOnly = true;
            this.ItemComboBox.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ItemComboBox.EditorControl.ShowGroupPanel = false;
            this.ItemComboBox.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.ItemComboBox.EditorControl.TabIndex = 0;
            this.ItemComboBox.Location = new System.Drawing.Point(22, 40);
            this.ItemComboBox.Name = "ItemComboBox";
            this.ItemComboBox.Size = new System.Drawing.Size(236, 20);
            this.ItemComboBox.TabIndex = 3;
            this.ItemComboBox.TabStop = false;
            this.ItemComboBox.ThemeName = "Office2013Light";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.Location = new System.Drawing.Point(183, 110);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(110, 36);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "حفظ";
            this.SaveBtn.ThemeName = "Office2013Light";
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.qtyTextBox.Location = new System.Drawing.Point(133, 74);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(124, 20);
            this.qtyTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "الصنف:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // frmEditProjectQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 151);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "frmEditProjectQuantity";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditProjectQuantity";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.frmEditProjectQuantity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemComboBox.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemComboBox.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton SaveBtn;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadMultiColumnComboBox ItemComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
    }
}