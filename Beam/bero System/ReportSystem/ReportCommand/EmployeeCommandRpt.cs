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
  public  class EmployeeCommandRpt
  {
      public EmployeeCommandRpt() { }

      public void GetAllEmployees()
      {//
          var q = EmployeesCmd.GetAllEmployees();
          ReportDataSource rs = new ReportDataSource();
          List<EmployeeObj> ls = new List<EmployeeObj>();

          foreach (var item in q)
          {

              ls.Add(new EmployeeObj()
              {
              EmpId=item.id,
              EmpName=item.EmployeeName,
              nationalty=item.nationalty,
              peronaltyNumber=item.peronaltyNumber,
              personaltyExpiredDate=item.PassportExpierdDate.Value,
              Salary=item.Salary.Value,
              PassportExpierdDate=item.PassportExpierdDate.Value,
              PassportNumber=item.PassportNumber,
              Status=item.Status,
              



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
