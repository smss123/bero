using bero_System.ReportSystem.ReportOBj;
using DataLayer;
using DataLayer.XCustomer;
using DataLayer.XProject;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bero_System.ReportSystem.ReportCommand
{
    public   class AllProjectsCmd
    {

        public AllProjectsCmd() { }
       
        public void Statistic()
        {
            List<AllProjectObjcet> LstStatitic = new List<AllProjectObjcet>();

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
                //%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

                LstStatitic.Add(new AllProjectObjcet()
                {
                      ProjectName = Prj.ProjectName,
                      FullAmount = Convert.ToDouble (Prj.ProjectFullAmount),
                      TotalExpensses = Convert.ToDouble(SumExpensses),
                      TotalSelles = SumSelles,
                      TotalInstallments = SumInstallments 
    
                 });
  
            } // End Loop

            
                ReportDataSource rs = new ReportDataSource();
 
                rs.Name = "DataSet1";
                rs.Value = LstStatitic;
                FrmReportViewer frm = new FrmReportViewer();
                frm.reportViewer1.LocalReport.DataSources.Clear();
                frm.reportViewer1.LocalReport.DataSources.Add(rs);
                frm.reportViewer1.LocalReport.ReportEmbeddedResource = "bero_System.ReportSystem.ReportDesign.hhhhhhhhhhhhh.rdlc";
                frm.ShowDialog();
            } 
   

    }
}
