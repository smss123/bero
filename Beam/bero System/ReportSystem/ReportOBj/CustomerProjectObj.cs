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
        public float ProjectFullAmount { get; set; }
        public string CustomerName { get; set; }
        public string SerialNumber { get; set; }


    }
}
