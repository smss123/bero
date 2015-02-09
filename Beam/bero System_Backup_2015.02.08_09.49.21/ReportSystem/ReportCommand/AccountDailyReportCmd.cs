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
public    class AccountDailyReportCmd
    {
        public AccountDailyReportCmd() { }

        public void GetAccountDaily()
        {//
            var q = AccountDailyCommand.GetAll();
            ReportDataSource rs = new ReportDataSource();
            List<AccountDailyObj> ls = new List<AccountDailyObj>();

            foreach (var item in q)
            {

                ls.Add(new AccountDailyObj()
                {
                    AccountName = item.Account.AccountName,
                    DateOfProcess = item.DateOfProcess.Value,
                    TotalIn = item.TotalIn.Value,
                    TotalOut = item.TotalOut.Value,
                    Description = item.Description,
                    CommandArg = item.CommandArg,
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

        //GetByAccount
        public void GetAccountDailyByAccountID(int AccountID)
        {//
            var q = AccountDailyCommand.GetAllAccountDailyByAccountID(AccountID);
            ReportDataSource rs = new ReportDataSource();
            List<AccountDailyObj> ls = new List<AccountDailyObj>();

            foreach (var item in q)
            {

                ls.Add(new AccountDailyObj()
                {
                    AccountName = item.Account.AccountName,
                    DateOfProcess = item.DateOfProcess.Value,
                    TotalIn = item.TotalIn.Value,
                    TotalOut = item.TotalOut.Value,
                    Description = item.Description,
                    CommandArg = item.CommandArg,
                });
            }
            rs.Name = "DataSet1";
            rs.Value = ls;
            FrmReportViewer frm = new FrmReportViewer();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "bero_System.ReportSystem.ReportDesign.RpttAccountDaily.rdlc";
            frm.ShowDialog();


        }

    }
}
