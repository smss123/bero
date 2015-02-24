namespace bero_System.AccountForms
{
    partial class FrmStatistic
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
            this.DgvStatistic = new System.Windows.Forms.DataGridView();
            this.ColProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColExpensses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSells = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInstallments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvStatistic
            // 
            this.DgvStatistic.AllowUserToAddRows = false;
            this.DgvStatistic.BackgroundColor = System.Drawing.Color.White;
            this.DgvStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStatistic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProjectName,
            this.ColAmount,
            this.ColExpensses,
            this.ColSells,
            this.ColInstallments,
            this.ColProfit});
            this.DgvStatistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DgvStatistic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvStatistic.Location = new System.Drawing.Point(0, 43);
            this.DgvStatistic.Name = "DgvStatistic";
            this.DgvStatistic.ReadOnly = true;
            this.DgvStatistic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvStatistic.Size = new System.Drawing.Size(789, 426);
            this.DgvStatistic.TabIndex = 0;
            // 
            // ColProjectName
            // 
            this.ColProjectName.HeaderText = "المشروع";
            this.ColProjectName.Name = "ColProjectName";
            this.ColProjectName.ReadOnly = true;
            this.ColProjectName.Width = 200;
            // 
            // ColAmount
            // 
            this.ColAmount.HeaderText = "ميزانية المشروع";
            this.ColAmount.Name = "ColAmount";
            this.ColAmount.ReadOnly = true;
            // 
            // ColExpensses
            // 
            this.ColExpensses.HeaderText = "المصروفات";
            this.ColExpensses.Name = "ColExpensses";
            this.ColExpensses.ReadOnly = true;
            // 
            // ColSells
            // 
            this.ColSells.HeaderText = "المشتريات";
            this.ColSells.Name = "ColSells";
            this.ColSells.ReadOnly = true;
            // 
            // ColInstallments
            // 
            this.ColInstallments.HeaderText = "االايرادات";
            this.ColInstallments.Name = "ColInstallments";
            this.ColInstallments.ReadOnly = true;
            // 
            // ColProfit
            // 
            this.ColProfit.HeaderText = "الفرق";
            this.ColProfit.Name = "ColProfit";
            this.ColProfit.ReadOnly = true;
            // 
            // FrmStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(789, 469);
            this.Controls.Add(this.DgvStatistic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmStatistic";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ميـــزان المراجــــــــعه";
            this.Load += new System.EventHandler(this.FrmStatistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvStatistic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvStatistic;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColExpensses;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSells;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInstallments;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProfit;
    }
}