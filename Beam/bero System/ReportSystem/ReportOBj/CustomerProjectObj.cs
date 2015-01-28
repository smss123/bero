using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bero_System.ReportSystem.ReportOBj
{
   public class CustomerProjectObj
    {

        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime DeliverDate { get; set; }
        public double ProjectFullAmount { get; set; }
        public string SerialNumber { get; set; }

       //
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string No_building { get; set; }
        public string No_permissibility { get; set; }
        public double Total_Need { get; set; }
       



    }
}
