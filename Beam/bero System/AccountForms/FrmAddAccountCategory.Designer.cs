namespace bero_System.AccountForms
{
    partial class FrmAddAccountCategory
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
            System.Windows.Forms.Label accountCategoryNameLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.accountCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountCategoryNameTextBox = new System.Windows.Forms.TextBox();
            accountCategoryNameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // accountCategoryNameLabel
            // 
            accountCategoryNameLabel.AutoSize = true;
            accountCategoryNameLabel.Location = new System.Drawing.Point(227, 30);
            accountCategoryNameLabel.Name = "accountCategoryNameLabel";
            accountCategoryNameLabel.Size = new System.Drawing.Size(128, 13);
            accountCategoryNameLabel.TabIndex = 0;
            accountCategoryNameLabel.Text = "Account Category Name:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(227, 56);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(descriptionLabel);
            this.radGroupBox1.Controls.Add(this.descriptionTextBox);
            this.radGroupBox1.Controls.Add(accountCategoryNameLabel);
            this.radGroupBox1.Controls.Add(this.accountCategoryNameTextBox);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "radGroupBox1";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGroupBox1.Size = new System.Drawing.Size(358, 235);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "radGroupBox1";
            this.radGroupBox1.ThemeName = "Office2013Light";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountCategoryBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 53);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(209, 69);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // accountCategoryBindingSource
            // 
            this.accountCategoryBindingSource.DataSource = typeof(DataLayer.AccountCategory);
            // 
            // accountCategoryNameTextBox
            // 
            this.accountCategoryNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountCategoryBindingSource, "AccountCategoryName", true));
            this.accountCategoryNameTextBox.Location = new System.Drawing.Point(12, 27);
            this.accountCategoryNameTextBox.Name = "accountCategoryNameTextBox";
            this.accountCategoryNameTextBox.Size = new System.Drawing.Size(209, 20);
            this.accountCategoryNameTextBox.TabIndex = 1;
            // 
            // FrmAddAccountCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 235);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "FrmAddAccountCategory";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddAccountCategory";
            this.ThemeName = "Office2013Light";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.BindingSource accountCategoryBindingSource;
        private System.Windows.Forms.TextBox accountCategoryNameTextBox;
    }
}