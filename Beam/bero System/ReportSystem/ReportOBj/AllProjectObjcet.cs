using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bero_System.ReportSystem.ReportOBj
{
   public  class AllProjectObjcet
    {

        public string ProjectName { get; set; }
        public string  CustomerName { get; set; }       
        public DateTime  CreationDate { get; set; }
        public DateTime DeliverDate { get; set; }

        public double FullAmount { get; set; }
        public double Expensses { get; set; }
        public double Selles { get; set; }
        public double Installments { get; set; }

        public string  Status { get; set; }

    }
}
