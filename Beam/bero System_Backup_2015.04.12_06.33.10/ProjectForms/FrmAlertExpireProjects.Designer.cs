namespace bero_System.ProjectForms
{
    partial class FrmAlertExpireProjects
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
            this.DgvExpiers = new System.Windows.Forms.DataGridView();
            this.ColProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDeliver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgvExpiers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvExpiers
            // 
            this.DgvExpiers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvExpiers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvExpiers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProjectName,
            this.ColDeliver});
            this.DgvExpiers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvExpiers.Location = new System.Drawing.Point(0, 59);
            this.DgvExpiers.Name = "DgvExpiers";
            this.DgvExpiers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DgvExpiers.Size = new System.Drawing.Size(427, 392);
            this.DgvExpiers.TabIndex = 0;
            // 
            // ColProjectName
            // 
            this.ColProjectName.HeaderText = "المشاريع";
            this.ColProjectName.Name = "ColProjectName";
            // 
            // ColDeliver
            // 
            this.ColDeliver.HeaderText = "تاريخ التسليم";
            this.ColDeliver.Name = "ColDeliver";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "شاشة تنـــــبيهات شهرية للمشاريع";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmAlertExpireProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(427, 451);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvExpiers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAlertExpireProjects";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".";
            this.ThemeName = "Office2013Light";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmAlertExpireProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvExpiers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvExpiers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDeliver;
    }
}