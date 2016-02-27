using System;
using System.Collections.Generic;

namespace Office
{
    public class Firm
    {
        public string[] posiblePositions = new string[6]
        {
            "programmer", "designer", "tester", "manager", "director", "booker"
        };

        public Dictionary<string, int> paymentDepence = new Dictionary<string, int>()
        {
            {"programmer", 50},
            {"designer", 40},
            {"tester", 30},
            {"manager", 2000},
            {"director", 2400},
            {"booker", 2400}
        };

        public Firm()
        {
        }
    }
}