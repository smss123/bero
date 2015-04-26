namespace bero_System.AccountForms
{
    partial class FromPrivatewithdrawals
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbToAccount = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.CmbFromAccount = new Telerik.WinControls.UI.RadMultiColumnComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAvailableAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbToAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbToAccount.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbToAccount.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbFromAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbFromAccount.EditorControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbFromAccount.EditorControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.AddBtn);
            this.radGroupBox1.Controls.Add(this.label5);
            this.radGroupBox1.Controls.Add(this.txtDescription);
            this.radGroupBox1.Controls.Add(this.label4);
            this.radGroupBox1.Controls.Add(this.label3);
            this.radGroupBox1.Controls.Add(this.CmbToAccount);
            this.radGroupBox1.Controls.Add(this.CmbFromAccount);
            this.radGroupBox1.Controls.Add(this.label2);
            this.radGroupBox1.Controls.Add(this.txtAmount);
            this.radGroupBox1.Controls.Add(this.lblAvailableAmount);
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(369, 327);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.ThemeName = "Office2013Light";
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Image = global::bero_System.Properties.Resources.Add;
            this.AddBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.Location = new System.Drawing.Point(251, 286);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(110, 36);
            this.AddBtn.TabIndex = 21;
            this.AddBtn.Text = "اضافة";
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddBtn.ThemeName = "Office2013Light";
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "الوصف:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(29, 191);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(278, 74);
            this.txtDescription.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "الى حساب:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "من حساب:";
            // 
            // CmbToAccount
            // 
            this.CmbToAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // CmbToAccount.NestedRadGridView
            // 
            this.CmbToAccount.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.CmbToAccount.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CmbToAccount.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CmbToAccount.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.CmbToAccount.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.CmbToAccount.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.CmbToAccount.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.CmbToAccount.EditorControl.MasterTemplate.EnableGrouping = false;
            this.CmbToAccount.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.CmbToAccount.EditorControl.Name = "NestedRadGridView";
            this.CmbToAccount.EditorControl.ReadOnly = true;
            this.CmbToAccount.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbToAccount.EditorControl.ShowGroupPanel = false;
            this.CmbToAccount.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.CmbToAccount.EditorControl.TabIndex = 0;
            this.CmbToAccount.Location = new System.Drawing.Point(26, 138);
            this.CmbToAccount.Name = "CmbToAccount";
            this.CmbToAccount.Size = new System.Drawing.Size(281, 20);
            this.CmbToAccount.TabIndex = 16;
            this.CmbToAccount.TabStop = false;
            this.CmbToAccount.ThemeName = "Office2013Light";
            // 
            // CmbFromAccount
            // 
            this.CmbFromAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // CmbFromAccount.NestedRadGridView
            // 
            this.CmbFromAccount.EditorControl.BackColor = System.Drawing.SystemColors.Window;
            this.CmbFromAccount.EditorControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.CmbFromAccount.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CmbFromAccount.EditorControl.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.CmbFromAccount.EditorControl.MasterTemplate.AllowAddNewRow = false;
            this.CmbFromAccount.EditorControl.MasterTemplate.AllowCellContextMenu = false;
            this.CmbFromAccount.EditorControl.MasterTemplate.AllowColumnChooser = false;
            this.CmbFromAccount.EditorControl.MasterTemplate.EnableGrouping = false;
            this.CmbFromAccount.EditorControl.MasterTemplate.ShowFilteringRow = false;
            this.CmbFromAccount.EditorControl.Name = "NestedRadGridView";
            this.CmbFromAccount.EditorControl.ReadOnly = true;
            this.CmbFromAccount.EditorControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CmbFromAccount.EditorControl.ShowGroupPanel = false;
            this.CmbFromAccount.EditorControl.Size = new System.Drawing.Size(240, 150);
            this.CmbFromAccount.EditorControl.TabIndex = 0;
            this.CmbFromAccount.Location = new System.Drawing.Point(26, 91);
            this.CmbFromAccount.Name = "CmbFromAccount";
            this.CmbFromAccount.Size = new System.Drawing.Size(281, 20);
            this.CmbFromAccount.TabIndex = 15;
            this.CmbFromAccount.TabStop = false;
            this.CmbFromAccount.ThemeName = "Office2013Light";
            this.CmbFromAccount.SelectedIndexChanged += new System.EventHandler(this.CmbFromAccount_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "المبلغ:";
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(208, 37);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(113, 23);
            this.txtAmount.TabIndex = 13;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // lblAvailableAmount
            // 
            this.lblAvailableAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvailableAmount.BackColor = System.Drawing.Color.Gainsboro;
            this.lblAvailableAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAvailableAmount.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableAmount.Location = new System.Drawing.Point(24, 36);
            this.lblAvailableAmount.Name = "lblAvailableAmount";
            this.lblAvailableAmount.Size = new System.Drawing.Size(99, 25);
            this.lblAvailableAmount.TabIndex = 12;
            this.lblAvailableAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "المبلغ المتوفر:";
            // 
            // FromPrivatewithdrawals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 327);
            this.Controls.Add(this.radGroupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(377, 358);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(377, 358);
            this.Name = "FromPrivatewithdrawals";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(377, 358);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قيد يومية";
            this.ThemeName = "Office2013Light";
            this.Load += new System.EventHandler(this.FromPrivatewithdrawals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbToAccount.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbToAccount.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbToAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbFromAccount.EditorControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbFromAccount.EditorControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbFromAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAvailableAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadMultiColumnComboBox CmbToAccount;
        private Telerik.WinControls.UI.RadMultiColumnComboBox CmbFromAccount;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
    }
}