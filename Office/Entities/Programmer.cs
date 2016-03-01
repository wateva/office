using System;

namespace Office.Entities
{
    public class Programmer : Worker, IProgrammer
    {
        public int payment = 50;
        public bool isFixedPay = false;
        public new Worker RealWorker;

        public Programmer(Worker worker)
        {
            RealWorker = worker;
        }
        public bool toWriteCode(int hours)
        {
            RealWorker.hoursRemainToWork = hours;
            return true;
        }
    }
}