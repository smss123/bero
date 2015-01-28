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
     public  class ProjectQuantityCommandRpt
    {
         public ProjectQuantityCommandRpt() { }

         public void rojectQuantityByProId(int ProId)
        {
            var q = ProjectQuantityCommand.GetByPojectProfileID(ProId);
            ReportDataSource rs = new ReportDataSource();
            List<ProjectQuantityObj> ls = new List<ProjectQuantityObj>();

            foreach (var item in q)
            {

                ls.Add(new ProjectQuantityObj()
                {////////////
                    /// information Customer
                   
                    CustomerName=item.ProjectProfile.Customer.CustomerName,
                    ProjectName=item.ProjectProfile.ProjectName,

                   ItemName=item.BulidItem.ItemName,
                    Qty=item.Qty

                    
                });
            }
            rs.Name = "DataSet1";
            rs.Value = ls;
            FrmReportViewer frm = new FrmReportViewer();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "bero_System.ReportSystem.ReportDesign.RptProjectQuantity.rdlc";
            frm.ShowDialog();


        }

    }
}
