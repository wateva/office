using System;

namespace Office.Entities
{
    public class Manager : Worker, IManager
    {
        public int payment = 2000;
        public bool isFixedPay = true;
        public Worker RealWorker;

        public bool toSellServices(int hours)
        {
            throw new NotImplementedException();
        }
    }
}