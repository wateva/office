using System;

namespace Office.Entities
{
    public class Tester: Worker, ITester
    {
        public int payment = 40;
        public bool isFixedPay = false;
        public new Worker RealWorker;

        public Tester(Worker worker)
        {
            RealWorker = worker;
        }

        public bool toTestProgramm(int hours)
        {
            RealWorker.hoursRemainToWork = hours;
            return true;
        }
    }
}