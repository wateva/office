using System;

namespace Office.Entities
{
    public class Designer : Worker, IDesigner
    {
        public int payment = 35;
        public bool isFixedPay = false;
        public new Worker RealWorker;

        public Designer(Worker worker)
        {
            RealWorker = worker;
        }

        public bool toDrawLayout(int hours)
        {
            RealWorker.hoursRemainToWork = hours;
            return true;
        }
    }
}