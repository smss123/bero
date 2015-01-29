namespace bero_System.ReportSystem.ReportOption
{
    partial class frmReportOptionBalanceSheet
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
            this.AllYearcheckBox = new System.Windows.Forms.CheckBox();
            this.SaveBtn = new Telerik.WinControls.UI.RadButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // AllYearcheckBox
            // 
            this.AllYearcheckBox.AutoSize = true;
            this.AllYearcheckBox.Location = new System.Drawing.Point(183, 81);
            this.AllYearcheckBox.Name = "AllYearcheckBox";
            this.AllYearcheckBox.Size = new System.Drawing.Size(81, 17);
            this.AllYearcheckBox.TabIndex = 9;
            this.AllYearcheckBox.Text = "كل السنوات";
            this.AllYearcheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveBtn.Location = new System.Drawing.Point(211, 117);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(109, 37);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "عرض";
            this.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveBtn.ThemeName = "Office2013Light";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Controls.Add(this.AllYearcheckBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 166);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "حتى تاريخ";
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(64, 45);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(200, 20);
            this.dtTo.TabIndex = 0;
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(64, 19);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(200, 20);
            this.dtFrom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "من تاريخ";
            // 
            // frmReportOptionBalanceSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 166);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReportOptionBalanceSheet";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportOptionBalanceSheet";
            this.ThemeName = "Office2013Light";
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox AllYearcheckBox;
        private Telerik.WinControls.UI.RadButton SaveBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
    }
}