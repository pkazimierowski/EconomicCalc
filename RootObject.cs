using System.Collections.Generic;

namespace EconomicCalc
{
    class RootObject
    {
       // public string table { get; set; }
        //public string no { get; set; }
        public string tradingDate { get; set; }
        public string effectiveDate { get; set; }
        public List<Rate> rates { get; set; }
    }
}
