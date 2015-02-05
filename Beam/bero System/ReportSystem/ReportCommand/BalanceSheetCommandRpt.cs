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
    class BalanceSheetCommandRpt
    {
        
        public void GetBalanceSheet()
        {
            var q = AccountCommand.GetAll();//.GetAllAccountDailyByDate(date);




            ReportDataSource rs = new ReportDataSource();
            List<BalanceSheetObj> ls = new List<BalanceSheetObj>();

            foreach (var item in q)
            {

                ls.Add(new BalanceSheetObj()
                {
                });
            }
            rs.Name = "DataSet1";
            rs.Value = ls;
            FrmReportViewer frm = new FrmReportViewer();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "bero_System.ReportSystem.ReportDesign.RptBalanceSheet.rdlc";
            frm.ShowDialog();
    }
}
}