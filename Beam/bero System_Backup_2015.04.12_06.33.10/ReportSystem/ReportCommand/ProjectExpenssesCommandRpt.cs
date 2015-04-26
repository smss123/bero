using bero_System.ReportSystem.ReportOBj;
using DataLayer.XProject;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bero_System.ReportSystem.ReportCommand
{
   public    class ProjectExpenssesCommandRpt
    {

       public ProjectExpenssesCommandRpt() { }

       public void ProjectExpenssesByProId(int ProId)
        {
            var q = ProjectExpenssesCommand.GetAll(ProId);
            ReportDataSource rs = new ReportDataSource();
            List<ProjectExpenssesObj> ls = new List<ProjectExpenssesObj>();

            foreach (var item in q)
            {

                ls.Add(new ProjectExpenssesObj()
                {////////////
                    /// information Customer
                   
                 CustomerName=item.projectLevel.ProjectProfile.Customer.CustomerName,
                 ProjectName = item.projectLevel.ProjectProfile.ProjectName,

                 ExpenssesName=item.Expenss.ExpenssesName,
                 Amount=item.Amount.Value,
                 DateOfProcess=item.dateOfExpensses.Value,
                 Description=item.Description,
                 ProjectLevelName=item.projectLevel.LevelName,

                    
                });
            }
            rs.Name = "DataSet1";
            rs.Value = ls;
            FrmReportViewer frm = new FrmReportViewer();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "bero_System.ReportSystem.ReportDesign.RptProjectExpensses.rdlc";
            frm.ShowDialog();


        }
    }
}
