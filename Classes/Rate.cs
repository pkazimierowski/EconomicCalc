using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicCalc
{
    public class Rate
    {
        public string currency { get; set; }
        public string code { get; set; }
        public double bid { get; set; }
        public double ask { get; set; }
    }
}
