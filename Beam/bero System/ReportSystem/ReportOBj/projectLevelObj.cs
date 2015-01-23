using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bero_System.ReportSystem.ReportOBj
{
  public  class projectLevelObj
    {
      public string LevelName { get; set; }
      public string Descripotion { get; set; }
      public double LevelAmount { get; set; }
      public string SerialNumberLevel { get; set; }



      //Project
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime DeliverDate { get; set; }
        public double ProjectFullAmount { get; set; }
        public string CustomerName { get; set; }

    }
}
