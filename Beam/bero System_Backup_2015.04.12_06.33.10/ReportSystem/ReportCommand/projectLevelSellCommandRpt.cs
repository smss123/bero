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
    public  class projectLevelSellCommandRpt
    {
        public projectLevelSellCommandRpt() { }

        public void projectLevelSellByProId(int ProId)
        {
            var q = projectLevelSellCommand.GetAllByProjectId(ProId);
            ReportDataSource rs = new ReportDataSource();
            List<projectLevelSellObj> ls = new List<projectLevelSellObj>();

            foreach (var item in q)
            {

                ls.Add(new projectLevelSellObj()
                {////////////
                    /// information Customer
                   
                    CustomerName=item.projectLevel.ProjectProfile.Customer.CustomerName,
                    ProjectName=item.projectLevel.ProjectProfile.ProjectName,

                    ItemName =item.Sell_Item,
                    Amount=item.Amount.Value,
                    DateOfSell=item.DateOfSell.Value,
                    Status=item.Status,
                    Description=item.Description

                    
                });
            }
            rs.Name = "DataSet1";
            rs.Value = ls;
            FrmReportViewer frm = new FrmReportViewer();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "bero_System.ReportSystem.ReportDesign.RptprojectLevelSell.rdlc";
            frm.ShowDialog();


        }


    }
}
