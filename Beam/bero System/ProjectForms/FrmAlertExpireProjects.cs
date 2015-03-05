using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using DataLayer;
using DataLayer.XProject;
namespace bero_System.ProjectForms
{
    public partial class FrmAlertExpireProjects : Form
    {
        public FrmAlertExpireProjects()
        {
            InitializeComponent();
        }
        void PopulateGrid()
        {
          
            var LstExpiers = (from c in ProjectProfileCommand .GetAll ()
                                               orderby c.createdDate ascending 
                                               where c.DeliverDate > DateTime.Now                    
                                               select c).ToList();
            foreach (var item in LstExpiers )
            {
                DgvExpiers.Rows.Add(new string[] {item .ProjectName , item .DeliverDate .ToString () });
            }
            //===============================
            GridFullStyle(DgvExpiers);
            timer1.Start();
        }
        private void FrmAlertExpireProjects_Load(object sender, EventArgs e)
        {
            PopulateGrid();



         
        }


        public static void GridFullStyle(DataGridView Dgv)
        {
            Dgv.Cursor = Cursors.Hand;
            Dgv.ReadOnly = true;
            Dgv.AllowUserToAddRows = false;
            Dgv.GridColor = Color.Red;
            Dgv.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            Dgv.BackgroundColor = Color.Goldenrod;
            Dgv.DefaultCellStyle.SelectionBackColor = Color.Green;
            Dgv.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            Dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv.AllowUserToResizeColumns = false;
            Dgv.RowsDefaultCellStyle.BackColor = Color.Bisque;
            Dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            Dgv.RowHeadersWidth = 70;
            Dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewRow R in Dgv.Rows)
            {
                R.HeaderCell.Style.ForeColor = Color.Yellow;
                R.HeaderCell.Style.BackColor = Color.Goldenrod;

                R.HeaderCell.Value = (R.Index + 1).ToString();
            }
        }

        int counter = 20;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter -= 1;
            if (counter == 0)
            {
                timer1.Enabled = false;
                timer1.Stop();
                this.Hide();
            }
        }
    }
}
