using System.Collections.Generic;

namespace Office.Entities
{
    public class Firm
    {
        static public Worker[] posiblePositions = new Worker[6]
        {
           new Booker(), new Director(), new Manager(), new Designer(), new Programmer(), 
           new Tester()
        };

        static public Dictionary<string, int> paymentDepence = new Dictionary<string, int>()
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