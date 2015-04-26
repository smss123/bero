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
                     AccountName= item.AccountName,
                      Expensess = item.AccountDailies.Sum(p=>p.TotalOut).Value,
                     InCome = item.AccountDailies.Sum(p => p.TotalIn).Value ,
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
        public void GetBalanceSheet(DateTime StartDate , DateTime EndTime)
        {
            var q = AccountCommand.GetAll();//.GetAllAccountDailyByDate(date);




            ReportDataSource rs = new ReportDataSource();
            List<BalanceSheetObj> ls = new List<BalanceSheetObj>();

            foreach (var item in q)
            {

                ls.Add(new BalanceSheetObj()
                {
                    AccountName = item.AccountName,
                    Expensess = item.AccountDailies.Where(px=>px.DateOfProcess.Value.Year>=StartDate.Year&&px.DateOfProcess.Value.Month>=StartDate.Month&&px.DateOfProcess.Value.Day>=StartDate.Day &&
                        
                        px.DateOfProcess.Value.Year<=EndTime.Year&&px.DateOfProcess.Value.Month<=EndTime.Month &&px.DateOfProcess.Value.Day<=EndTime.Day
                        
                        ) .Sum(p => p.TotalOut).Value,
                    InCome = item.AccountDailies.Where(px => px.DateOfProcess.Value.Year >= StartDate.Year && px.DateOfProcess.Value.Month >= StartDate.Month && px.DateOfProcess.Value.Day >= StartDate.Day &&

                        px.DateOfProcess.Value.Year <= EndTime.Year && px.DateOfProcess.Value.Month <= EndTime.Month && px.DateOfProcess.Value.Day <= EndTime.Day

                        ).Sum(p => p.TotalIn).Value
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