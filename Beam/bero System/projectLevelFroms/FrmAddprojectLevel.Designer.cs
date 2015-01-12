namespace bero_System.projectLevelFroms
{
    partial class FrmAddprojectLevel
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
            System.Windows.Forms.Label levelNameLabel;
            System.Windows.Forms.Label levelAmountLabel;
            System.Windows.Forms.Label descripotionLabel;
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.AddBtn = new Telerik.WinControls.UI.RadButton();
            this.descripotionTextBox = new System.Windows.Forms.TextBox();
            this.projectLevelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.levelAmountTextBox = new System.Windows.Forms.TextBox();
            this.levelNameTextBox = new System.Windows.Forms.TextBox();
            levelNameLabel = new System.Windows.Forms.Label();
            levelAmountLabel = new System.Windows.Forms.Label();
            descripotionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // levelNameLabel
            // 
            levelNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            levelNameLabel.AutoSize = true;
            levelNameLabel.Location = new System.Drawing.Point(263, 33);
            levelNameLabel.Name = "levelNameLabel";
            levelNameLabel.Size = new System.Drawing.Size(80, 13);
            levelNameLabel.TabIndex = 0;
            levelNameLabel.Text = "اسم المستوى:";
            // 
            // levelAmountLabel
            // 
            levelAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            levelAmountLabel.AutoSize = true;
            levelAmountLabel.Location = new System.Drawing.Point(263, 63);
            levelAmountLabel.Name = "levelAmountLabel";
            levelAmountLabel.Size = new System.Drawing.Size(43, 13);
            levelAmountLabel.TabIndex = 2;
            levelAmountLabel.Text = "التكلفة:";
            // 
            // descripotionLabel
            // 
            descripotionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            descripotionLabel.AutoSize = true;
            descripotionLabel.Location = new System.Drawing.Point(263, 89);
            descripotionLabel.Name = "descripotionLabel";
            descripotionLabel.Size = new System.Drawing.Size(82, 13);
            descripotionLabel.TabIndex = 4;
            descripotionLabel.Text = "وصف المستوى:";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.AddBtn);
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
            this.radGroupBox1.Size = new System.Drawing.Size(352, 219);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "radGroupBox1";
            this.radGroupBox1.ThemeName = "Office2013Light";
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBtn.Location = new System.Drawing.Point(232, 170);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(110, 36);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "اضافة";
            this.AddBtn.ThemeName = "Office2013Light";
            // 
            // descripotionTextBox
            // 
            this.descripotionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descripotionTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.descripotionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectLevelBindingSource, "Descripotion", true));
            this.descripotionTextBox.Location = new System.Drawing.Point(25, 82);
            this.descripotionTextBox.Multiline = true;
            this.descripotionTextBox.Name = "descripotionTextBox";
            this.descripotionTextBox.Size = new System.Drawing.Size(232, 64);
            this.descripotionTextBox.TabIndex = 5;
            // 
            // projectLevelBindingSource
            // 
            this.projectLevelBindingSource.DataSource = typeof(DataLayer.projectLevel);
            // 
            // levelAmountTextBox
            // 
            this.levelAmountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.levelAmountTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.levelAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectLevelBindingSource, "LevelAmount", true));
            this.levelAmountTextBox.Location = new System.Drawing.Point(99, 56);
            this.levelAmountTextBox.Name = "levelAmountTextBox";
            this.levelAmountTextBox.Size = new System.Drawing.Size(158, 20);
            this.levelAmountTextBox.TabIndex = 3;
            // 
            // levelNameTextBox
            // 
            this.levelNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.levelNameTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.levelNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectLevelBindingSource, "LevelName", true));
            this.levelNameTextBox.Location = new System.Drawing.Point(25, 30);
            this.levelNameTextBox.Name = "levelNameTextBox";
            this.levelNameTextBox.Size = new System.Drawing.Size(232, 20);
            this.levelNameTextBox.TabIndex = 1;
            // 
            // FrmAddprojectLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 219);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "FrmAddprojectLevel";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddprojectLevel";
            this.ThemeName = "Office2013Light";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectLevelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.TextBox descripotionTextBox;
        private System.Windows.Forms.BindingSource projectLevelBindingSource;
        private System.Windows.Forms.TextBox levelAmountTextBox;
        private System.Windows.Forms.TextBox levelNameTextBox;
        private Telerik.WinControls.UI.RadButton AddBtn;
    }
}