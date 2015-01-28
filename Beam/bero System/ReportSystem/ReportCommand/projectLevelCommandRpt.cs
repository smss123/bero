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
   public class projectLevelCommandRpt
    {
       public projectLevelCommandRpt() { }

       public void projectLevelByProId(int ProId)
        {
            var q = projectLevelCommand.GetByProjectProfileID(ProId);
            ReportDataSource rs = new ReportDataSource();
            List<projectLevelObj> ls = new List<projectLevelObj>();

            foreach (var item in q)
            {

                ls.Add(new projectLevelObj()
                {////////////
                    /// information Level
                   
                   LevelName=item.LevelName,
                   Descripotion=item.Descripotion,
                   LevelAmount=item.LevelAmount.Value,
                    /// information Projcet
                    ProjectName=item.ProjectProfile.ProjectName,
                    ProjectDescription = item.ProjectProfile.ProjectDescription,
                    ProjectFullAmount = item.ProjectProfile.ProjectFullAmount.Value,
                    createdDate = item.ProjectProfile.createdDate.Value,
                    DeliverDate = item.ProjectProfile.DeliverDate.Value,




                });
            }
            rs.Name = "DataSet1";
            rs.Value = ls;
            FrmReportViewer frm = new FrmReportViewer();
            frm.reportViewer1.LocalReport.DataSources.Clear();
            frm.reportViewer1.LocalReport.DataSources.Add(rs);
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = "bero_System.ReportSystem.ReportDesign.RptprojectLevel.rdlc";
            frm.ShowDialog();


        }

    }
}
