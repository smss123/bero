using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bero_System.ReportSystem.ReportOBj
{
  public  class TotalExpensesandIncomeObj
    {

        ///مصروفات عامة
        ///
        public int ExpId { get; set; }
        public string ExpenssName { get; set; }
        public double ExpensessAmount { get; set; }

      ///مصروفات المشاريع

        public int expProId { get; set; }
        public string ExpenssProjectName { get; set; }
        public double ExpensessProjectAmount { get; set; }

      ///مشتريات مشاريع
      ///
        public int LevelSellID { get; set; }
        public string SellItem { get; set; }
        public string SellAmount { get; set; }



      //الايرادات  والتي هي اقساط المشروع

        public int ProjectInstallmentID { get; set; }
        public string Installments_name { get; set; }
        public double InstallmentAmount { get; set; }
    }
}
