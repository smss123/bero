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
   public class ProjectInstallmentCommandRpt
    {

       public static string xProject;
       public static string xCustomerName;
       public ProjectInstallmentCommandRpt() { }

       public void ProjectInstallmentByProId(int ProId)
        {
            var q = ProjectInstallmentCommand.GetAllProjectInstallmentByProjectId(ProId);
            ReportDataSource rs = new ReportDataSource();
            List<ProjectInstallmentObj> ls = new List<ProjectInstallmentObj>();

            foreach (var item in q)
            {

                ls.Add(new ProjectInstallmentObj()
                {                   
                    /// information Level
                   
                   ProjectLevelName=item.projectLevel.LevelName,
                   ProjectLevelID = item.projectLevel.id,
                  
                    /// information Projcet
                    ProjectName=item.projectLevel.ProjectProfile.ProjectName,
                    CustomerName = item.projectLevel.ProjectProfile.Customer.CustomerName,
                   //

                   Installments_name=item.Installments_name,
                   Amount=item.Amount.Value,
                   DateOfInstallments=item.DateOfInstallments.Value,
                   ActiveStatus=item.ActiveStatus,
                   PayBy=item.PayBy,
                   PayDescription=item.PayDescription,

                   
                });
            }
            rs.Name = "DataSet1";
            rs.Value = ls;
            FrmReportViewer frm = new FrmReportViewer();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "bero_System.ReportSystem.ReportDesign.RptProjectInstallment.rdlc";
            frm.ShowDialog();


        }


       public void PrintCurrentInstallment(int xId)
       {
           
           var q = ProjectInstallmentCommand.GetById(xId);
           ReportDataSource rs = new ReportDataSource();
           List<ProjectInstallmentObj> ls = new List<ProjectInstallmentObj>();



     

               ls.Add(new ProjectInstallmentObj()
               {
                   /// information Level
                   /// 
                   
                   ProjectName = xProject ,
                   CustomerName = xCustomerName ,
                  Installments_name = q.Installments_name,
                   Amount = q.Amount.Value,
                   DateOfInstallments = q.DateOfInstallments.Value,
                   ActiveStatus = q.ActiveStatus,
                   PayBy = q.PayBy,
                   PayDescription = q.PayDescription,
                   

               });
         
       
           rs.Name = "DataSet1";
           rs.Value = ls;
           FrmReportViewer frm = new FrmReportViewer();
           frm.reportViewer1.LocalReport.DataSources.Clear();
           frm.reportViewer1.LocalReport.DataSources.Add(rs);
           frm.reportViewer1.LocalReport.ReportEmbeddedResource = "bero_System.ReportSystem.ReportDesign.RptProjectInstallment.rdlc";
           frm.ShowDialog();


       }
    }
}
