using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomicCalc
{
    class RootObject
    {
        public string tradingDate { get; set; }
        public string effectiveDate { get; set; }
        public List<Rate> rates { get; set; }
    }
}
