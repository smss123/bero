using bero_System.ReportSystem.ReportOBj;
using DataLayer.XEmployees;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bero_System.ReportSystem.ReportCommand
{
   public class HolyDayCommandRpt
    {
       public HolyDayCommandRpt() { }

       public void HolyDayByEmpId(int emp)
        {
            var q = HolyDayCmd.GetByEmployeeID(emp);
            ReportDataSource rs = new ReportDataSource();
            List<HolyDayObj> ls = new List<HolyDayObj>();

            foreach (var item in q)
            {

                ls.Add(new HolyDayObj()
                {////////////
                    /// information Customer
                   
                  ID=item.ID,
                  EmployeeName=item.Employee.EmployeeName,
                  fromDate=item.fromDate.Value,
                  ToDatetime=item.ToDatetime.Value,
                  commint=item.commint,
                  Staus=item.status




                });
            }
            rs.Name = "DataSet1";
            rs.Value = ls;
            FrmReportViewer frm = new FrmReportViewer();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "bero_System.ReportSystem.ReportDesign.RptHolyDay.rdlc";
            frm.ShowDialog();


        }



       public void AllHolyDays()
       {

           var q = HolyDayCmd.GetAllHolyDays();
           ReportDataSource rs = new ReportDataSource();
           List<HolyDayObj> ls = new List<HolyDayObj>();

           foreach (var item in q)
           {

               ls.Add(new HolyDayObj()
               {             
                   ID = item.ID,
                   EmployeeName = item.Employee.EmployeeName,
                   fromDate = item.fromDate.Value,
                   ToDatetime = item.ToDatetime.Value,
                   commint = item.commint,
                   Staus = item.status
               });
           }
           rs.Name = "DataSet1";
           rs.Value = ls;
           FrmReportViewer frm = new FrmReportViewer();
           frm.reportViewer1.LocalReport.DataSources.Clear();
           frm.reportViewer1.LocalReport.DataSources.Add(rs);
           frm.reportViewer1.LocalReport.ReportEmbeddedResource = "bero_System.ReportSystem.ReportDesign.RptAllHolyDay.rdlc";
           frm.ShowDialog();

       }

       public void AllHolyDaysBetween2Dates(DateTime strtdate, DateTime enddate)
       {

           var q = HolyDayCmd.GetHolydaysBetween2Days(strtdate ,enddate );
           ReportDataSource rs = new ReportDataSource();
           List<HolyDayObj> ls = new List<HolyDayObj>();

           foreach (var item in q)
           {

               ls.Add(new HolyDayObj()
               {
                   ID = item.ID,
                   EmployeeName = item.Employee.EmployeeName,
                   fromDate = item.fromDate.Value,
                   ToDatetime = item.ToDatetime.Value,
                   commint = item.commint,
                   Staus = item.status
               });
           }
           rs.Name = "DataSet1";
           rs.Value = ls;
           FrmReportViewer frm = new FrmReportViewer();
           frm.reportViewer1.LocalReport.DataSources.Clear();
           frm.reportViewer1.LocalReport.DataSources.Add(rs);
           frm.reportViewer1.LocalReport.ReportEmbeddedResource = "bero_System.ReportSystem.ReportDesign.RptAllHolyDayBetween2dates.rdlc";
           frm.ShowDialog();

       }

    }
}
