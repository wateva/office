using System;

namespace Office.Entities
{
    public class Manager : Worker, IManager
    {
        public int payment = 2000;
        public bool isFixedPay = true;
        public Worker RealWorker;

        public Manager(Worker worker)
        {
            RealWorker = worker;
        }

        public bool toSellServices(int hours)
        {
            RealWorker.hoursRemainToWork = hours;
            return true;
        }
    }
}