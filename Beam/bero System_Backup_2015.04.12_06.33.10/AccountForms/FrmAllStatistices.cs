using DataLayer.XProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace bero_System.AccountForms
{
    public partial class FrmAllStatistices : RadForm
    {
        public FrmAllStatistices()
        {
            InitializeComponent();
        }

        private void FrmAllStatistices_Load(object sender, EventArgs e)
        {
            DgvStatistic.Rows.Clear();
            DgvStatistic.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvStatistic.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;




            var LstProjects = ProjectProfileCommand.GetAll();
            foreach (var Prj in LstProjects)
            { //Start Loop

                // Installments
                var AllInstallments = ProjectInstallmentCommand.GetAllProjectInstallmentByProjectId(Prj.ID);
                Double SumInstallments = 0;
                foreach (var InstallAmount in AllInstallments)
                {
                    SumInstallments += Convert.ToDouble(InstallAmount.Amount);
                }

                //======================================================================================================
                // Expensses :
                var AllExpensses = ProjectExpenssesCommand.GetAll(Prj.ID);
                double SumExpensses = 0;
                foreach (var ExpAmount in AllExpensses)
                {
                    SumExpensses += Convert.ToDouble(ExpAmount.Amount);
                }

                //======================================================================================================
                // Selles
                var AllSelles = projectLevelSellCommand.GetAllByProjectId(Prj.ID);
                double SumSelles = 0;
                foreach (var SellAmount in AllSelles)
                {
                    SumSelles += Convert.ToDouble(SellAmount.Amount);
                }
                // txtSells.Text = ; ;
                DgvStatistic.Rows.Add(new string[] { Prj.ProjectName, Prj.ProjectFullAmount.ToString(), SumExpensses.ToString(), SumSelles.ToString(), SumInstallments.ToString() });

            } // End Loop
            //===============================================================
            double _TotalFullAmount = (from DataGridViewRow r in DgvStatistic.Rows select Convert.ToInt32(r.Cells[1].Value)).Sum();
            double _TotalFullExpensses = (from DataGridViewRow r in DgvStatistic.Rows select Convert.ToInt32(r.Cells[2].Value)).Sum();
            double _TotalFullSells = (from DataGridViewRow r in DgvStatistic.Rows select Convert.ToInt32(r.Cells[3].Value)).Sum();
            double _TotalFullInstalments = (from DataGridViewRow r in DgvStatistic.Rows select Convert.ToInt32(r.Cells[4].Value)).Sum();
            DgvStatistic.Rows.Add(new string[] { "المجاميع", _TotalFullAmount.ToString(), _TotalFullExpensses.ToString(), _TotalFullSells.ToString(), _TotalFullInstalments.ToString() });

            //===============================================================


            foreach (DataGridViewRow r in DgvStatistic.Rows)
            {
                r.Cells[5].Value = Convert.ToDouble(r.Cells[4].Value) - Convert.ToDouble(Convert.ToDouble(r.Cells[2].Value) + Convert.ToDouble(r.Cells[3].Value));

                r.HeaderCell.Value = (r.Index + 1).ToString();

                r.HeaderCell.Value = (r.Index + 1).ToString();
                if (r.Cells[0].FormattedValue.ToString() == "المجاميع".ToString())
                {
                    r.DefaultCellStyle.ForeColor = Color.Yellow; r.DefaultCellStyle.BackColor = Color.Green;
                }

            }

        }
    }
}
