using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bero_System.ReportSystem.ReportOBj
{
   public   class ProjectQuantityObj
    {
       public int ID { get; set; }          
        public string ItemName { get; set; }
        public int Qty { get; set; }
        public string SerialNumber { get; set; }
        //

        public string ProjectName { get; set; }
        public string CustomerName { get; set; }
    }
}
