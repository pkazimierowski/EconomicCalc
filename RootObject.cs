
using System.Collections.Generic;

namespace EconomicCalc
{
    class RootObject
    {
        public string tradingDate { get; set; }
        public string effectiveDate { get; set; }
        public List<Rate> rates { get; set; }
    }
}