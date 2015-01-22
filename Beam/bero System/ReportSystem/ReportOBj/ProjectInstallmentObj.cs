using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bero_System.ReportSystem.ReportOBj
{
   public class ProjectInstallmentObj
    {

     
        public string Installments_name { get; set; }
        public double Amount { get; set; }
        public DateTime DateOfInstallments { get; set; }
        public string ActiveStatus { get; set; }
        public string PayBy { get; set; }
        public string PayDescription { get; set; }
        public string SerialNumber { get; set; }

        //
        public string ProjectName { get; set; }
        public string CustomerName { get; set; }
    }
}
