using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bero_System.ReportSystem.ReportOBj
{
    public class PaymentVoucherReportObj
    {


        public int PaymentVoucherNumber { get; set; }
        public string PaymentVoucherName { get; set; }
        public string Date { get; set; }
        public double Cost { get; set; }
        public double Remaining { get; set; }
    }
}
