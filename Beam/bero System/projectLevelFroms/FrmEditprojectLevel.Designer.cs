namespace bero_System.projectLevelFroms
{
    partial class FrmEditprojectLevel
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
            System.Windows.Forms.Label descripotionLabel;
            System.Windows.Forms.Label levelAmountLabel;
            System.Windows.Forms.Label levelNameLabel;
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.EditBtn = new Telerik.WinControls.UI.RadButton();
            this.descripotionTextBox = new System.Windows.Forms.TextBox();
            this.levelAmountTextBox = new System.Windows.Forms.TextBox();
            this.levelNameTextBox = new System.Windows.Forms.TextBox();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            descripotionLabel = new System.Windows.Forms.Label();
            levelAmountLabel = new System.Windows.Forms.Label();
            levelNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // descripotionLabel
            // 
            descripotionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            descripotionLabel.AutoSize = true;
            descripotionLabel.Location = new System.Drawing.Point(255, 89);
            descripotionLabel.Name = "descripotionLabel";
            descripotionLabel.Size = new System.Drawing.Size(82, 13);
            descripotionLabel.TabIndex = 4;
            descripotionLabel.Text = "وصف المستوى:";
            // 
            // levelAmountLabel
            // 
            levelAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            levelAmountLabel.AutoSize = true;
            levelAmountLabel.Location = new System.Drawing.Point(255, 63);
            levelAmountLabel.Name = "levelAmountLabel";
            levelAmountLabel.Size = new System.Drawing.Size(43, 13);
            levelAmountLabel.TabIndex = 2;
            levelAmountLabel.Text = "التكلفة:";
            // 
            // levelNameLabel
            // 
            levelNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            levelNameLabel.AutoSize = true;
            levelNameLabel.Location = new System.Drawing.Point(255, 33);
            levelNameLabel.Name = "levelNameLabel";
            levelNameLabel.Size = new System.Drawing.Size(80, 13);
            levelNameLabel.TabIndex = 0;
            levelNameLabel.Text = "اسم المستوى:";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.EditBtn);
            this.radGroupBox1.Controls.Add(descripotionLabel);
            this.radGroupBox1.Controls.Add(this.descripotionTextBox);
            this.radGroupBox1.Controls.Add(levelAmountLabel);
            this.radGroupBox1.Controls.Add(this.levelAmountTextBox);
            this.radGroupBox1.Controls.Add(levelNameLabel);
            this.radGroupBox1.Controls.Add(this.levelNameTextBox);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderText = "radGroupBox1";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radGroupBox1.Size = new System.Drawing.Size(344, 211);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "radGroupBox1";
            this.radGroupBox1.ThemeName = "Office2013Light";
            // 
            // EditBtn
            // 
            this.EditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditBtn.Location = new System.Drawing.Point(224, 170);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(110, 36);
            this.EditBtn.TabIndex = 6;
            this.EditBtn.Text = "حفظ";
            this.EditBtn.ThemeName = "Office2013Light";
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // descripotionTextBox
            // 
            this.descripotionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descripotionTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.descripotionTextBox.Location = new System.Drawing.Point(17, 82);
            this.descripotionTextBox.Multiline = true;
            this.descripotionTextBox.Name = "descripotionTextBox";
            this.descripotionTextBox.Size = new System.Drawing.Size(232, 64);
            this.descripotionTextBox.TabIndex = 5;
            // 
            // levelAmountTextBox
            // 
            this.levelAmountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.levelAmountTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.levelAmountTextBox.Location = new System.Drawing.Point(91, 56);
            this.levelAmountTextBox.Name = "levelAmountTextBox";
            this.levelAmountTextBox.Size = new System.Drawing.Size(158, 20);
            this.levelAmountTextBox.TabIndex = 3;
            // 
            // levelNameTextBox
            // 
            this.levelNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.levelNameTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.levelNameTextBox.Location = new System.Drawing.Point(17, 30);
            this.levelNameTextBox.Name = "levelNameTextBox";
            this.levelNameTextBox.Size = new System.Drawing.Size(232, 20);
            this.levelNameTextBox.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // FrmEditprojectLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 211);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "FrmEditprojectLevel";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditprojectLevel";
            this.ThemeName = "Office2013Light";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton EditBtn;
        private System.Windows.Forms.TextBox descripotionTextBox;
        private System.Windows.Forms.TextBox levelAmountTextBox;
        private System.Windows.Forms.TextBox levelNameTextBox;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}