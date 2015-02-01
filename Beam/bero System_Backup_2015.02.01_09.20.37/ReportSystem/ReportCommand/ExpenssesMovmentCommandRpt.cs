using bero_System.ReportSystem.ReportOBj;
using DataLayer.XAccountant;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bero_System.ReportSystem.ReportCommand
{
    public class ExpenssesMovmentCommandRpt
    {

        public ExpenssesMovmentCommandRpt() { }

        public void GetExpenssesMovmentByDate()
        {//
            var q = ExpenssesMovmentCommand.GetAll();
            ReportDataSource rs = new ReportDataSource();
            List<ExpenssesMovmentReportObj> ls = new List<ExpenssesMovmentReportObj>();

            foreach (var item in q)
            {

                ls.Add(new ExpenssesMovmentReportObj()
                {
                    ExpenssesName = item.Expenss.ExpenssesName,
                    ExpnessID = item.ID,
                    Amount = item.Amount.Value,
                    Description = item.Description,
                    DateOfProcess = item.DateOfProcess.Value,
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