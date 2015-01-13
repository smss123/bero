namespace bero_System.BulidItemForms
{
    partial class FrmAddBulidItem
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
            System.Windows.Forms.Label itemNameLabel;
            System.Windows.Forms.Label itemDescriptionLabel;
            System.Windows.Forms.Label itemSummeryLabel;
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.itemSummeryTextBox = new System.Windows.Forms.TextBox();
            this.bulidItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            itemNameLabel = new System.Windows.Forms.Label();
            itemDescriptionLabel = new System.Windows.Forms.Label();
            itemSummeryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulidItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // itemNameLabel
            // 
            itemNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new System.Drawing.Point(256, 33);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new System.Drawing.Size(65, 13);
            itemNameLabel.TabIndex = 0;
            itemNameLabel.Text = "اسم الصنف:";
            // 
            // itemDescriptionLabel
            // 
            itemDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            itemDescriptionLabel.AutoSize = true;
            itemDescriptionLabel.Location = new System.Drawing.Point(258, 60);
            itemDescriptionLabel.Name = "itemDescriptionLabel";
            itemDescriptionLabel.Size = new System.Drawing.Size(41, 13);
            itemDescriptionLabel.TabIndex = 2;
            itemDescriptionLabel.Text = "الوصف:";
            // 
            // itemSummeryLabel
            // 
            itemSummeryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            itemSummeryLabel.AutoSize = true;
            itemSummeryLabel.Location = new System.Drawing.Point(257, 126);
            itemSummeryLabel.Name = "itemSummeryLabel";
            itemSummeryLabel.Size = new System.Drawing.Size(41, 13);
            itemSummeryLabel.TabIndex = 4;
            itemSummeryLabel.Text = "اختصار:";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.AddBtn);
            this.radGroupBox1.Controls.Add(itemSummeryLabel);
            this.radGroupBox1.Controls.Add(this.itemSummeryTextBox);
            this.radGroupBox1.Controls.Add(itemDescriptionLabel);
            this.radGroupBox1.Controls.Add(this.itemDescriptionTextBox);
            this.radGroupBox1.Controls.Add(itemNameLabel);
            this.radGroupBox1.Controls.Add(this.itemNameTextBox);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "radGroupBox1";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(343, 216);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "radGroupBox1";
            this.radGroupBox1.ThemeName = "Office2013Light";
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Location = new System.Drawing.Point(224, 168);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(110, 36);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "اضافة";
            this.AddBtn.ThemeName = "Office2013Light";
            // 
            // itemSummeryTextBox
            // 
            this.itemSummeryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemSummeryTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.itemSummeryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bulidItemBindingSource, "ItemSummery", true));
            this.itemSummeryTextBox.Location = new System.Drawing.Point(24, 122);
            this.itemSummeryTextBox.Name = "itemSummeryTextBox";
            this.itemSummeryTextBox.Size = new System.Drawing.Size(232, 20);
            this.itemSummeryTextBox.TabIndex = 3;
            // 
            // bulidItemBindingSource
            // 
            this.bulidItemBindingSource.DataSource = typeof(DataLayer.BulidItem);
            // 
            // itemDescriptionTextBox
            // 
            this.itemDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemDescriptionTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.itemDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bulidItemBindingSource, "ItemDescription", true));
            this.itemDescriptionTextBox.Location = new System.Drawing.Point(24, 57);
            this.itemDescriptionTextBox.Multiline = true;
            this.itemDescriptionTextBox.Name = "itemDescriptionTextBox";
            this.itemDescriptionTextBox.Size = new System.Drawing.Size(232, 57);
            this.itemDescriptionTextBox.TabIndex = 2;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemNameTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.itemNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bulidItemBindingSource, "ItemName", true));
            this.itemNameTextBox.Location = new System.Drawing.Point(24, 31);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(232, 20);
            this.itemNameTextBox.TabIndex = 1;
            // 
            // FrmAddBulidItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 216);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "FrmAddBulidItem";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddBulidItem";
            this.ThemeName = "Office2013Light";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulidItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.TextBox itemSummeryTextBox;
        private System.Windows.Forms.BindingSource bulidItemBindingSource;
        private System.Windows.Forms.TextBox itemDescriptionTextBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private Telerik.WinControls.UI.RadButton AddBtn;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
    }
}