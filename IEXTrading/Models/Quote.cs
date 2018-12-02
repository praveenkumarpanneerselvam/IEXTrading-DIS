using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IEXTrading.Models
{
    public class Quote
    {

        public float? close { get; set; }
        public float?  week52low { get; set; }
        public float? week52High { get; set; }
        public float? week52Low { get; set; }
        public string symbol { get; set; }
        public string companyName { get; set; }

    }
}
