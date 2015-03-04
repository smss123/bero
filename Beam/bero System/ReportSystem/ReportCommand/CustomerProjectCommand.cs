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
     public  class CustomerProjectCommand
    {


         public CustomerProjectCommand() { }
        
         public void CustomerProjectByCusId(int CusId)
        {
            var q = ProjectProfileCommand.GetAllByCustomerId(CusId);
            ReportDataSource rs = new ReportDataSource();
            List<CustomerProjectObj> ls = new List<CustomerProjectObj>();

            foreach (var item in q)
            {

                ls.Add(new CustomerProjectObj()
                {////////////
                    /// information Customer
                   
                    CustomerName=item.Customer.CustomerName,
                    PhoneNumber=item.Customer.PhoneNumber,
                  
                    Total_Need=item.Customer.Total_Need.Value,
                    /// information Projcet
                    ProjectName=item.ProjectName,
                    ProjectDescription=item.ProjectDescription,
                    ProjectFullAmount=item.ProjectFullAmount.Value,
                    createdDate=item.createdDate.Value,
                    DeliverDate=item.DeliverDate.Value,




                });
            }
            rs.Name = "DataSet1";
            rs.Value = ls;
            FrmReportViewer frm = new FrmReportViewer();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "bero_System.ReportSystem.ReportDesign.RptCustomerProject.rdlc";
            frm.ShowDialog();


        }
    }
}
