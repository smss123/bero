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
        public void AllProjectsStatistic()
        {
            var AllProjects = ProjectProfileCommand.GetAll();

            double _FullAmount = 0;
            double _FullExpensses = 0;
            double _FullInstallments = 0;
            double _FullSelles = 0 ;
            foreach (var Prj in AllProjects)
            { // Start loop
                var q = ProjectProfileCommand.GetAll();
                List<ProjectExpenss> AllExp = ProjectExpenssesCommand.GetAll(Prj.ID);
                List<ProjectInstallment> AllInstalments = ProjectInstallmentCommand.GetAllProjectInstallmentByProjectId(Prj.ID);
                List<projectLevelSell> AllProjectSells = projectLevelSellCommand.GetAllByProjectId(Prj.ID);
                foreach (var  exp  in AllExp )
                {
                    _FullExpensses +=  Convert.ToDouble (exp.Amount);

                }

                foreach (var install in AllInstalments )
                {
                    _FullInstallments += Convert.ToDouble(install.Amount);
                }


                foreach (var sell in AllProjectSells )
                {
                    _FullSelles += Convert.ToDouble(sell.Amount);
                }
                // ^^^^^ Populate Object By Values :  
                ReportDataSource rs = new ReportDataSource();
                List<AllProjectObjcet> ls = new List<AllProjectObjcet>();

                foreach (var item in q)
                {
                    
                    var cst = CustomerCommand.GetCustomerByID(Convert.ToInt32 (item .CustomerID ) );
                    ls.Add(new AllProjectObjcet()
                    {
                         CustomerName = cst .CustomerName ,
                         FullAmount = _FullAmount ,
                          Selles = _FullSelles ,
                           Expensses = _FullExpensses ,
                           Installments = _FullInstallments 

                    });
                }
                rs.Name = "DataSet1";
                rs.Value = ls;
                FrmReportViewer frm = new FrmReportViewer();
                frm.reportViewer1.LocalReport.DataSources.Clear();
                frm.reportViewer1.LocalReport.DataSources.Add(rs);
                frm.reportViewer1.LocalReport.ReportEmbeddedResource = "bero_System.ReportSystem.ReportDesign.hhhhhhhhhhhhh.rdlc";
                frm.ShowDialog();
            } // End loop
        }

    }
}
