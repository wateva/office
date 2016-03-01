using System;
using System.Collections.Generic;

namespace Office.Entities
{
    public class Booker : Worker, IBooker
    {

        public int payment = 2300;
        public bool isFixedPay = true;
        public new Worker RealWorker;

        public Booker(Worker worker)
        {
            RealWorker = worker;
        }

        public bool toMakeReport(int hours)
        {
            hoursRemainToWork = hours;
            return true;
        }

        public Dictionary<Worker, int> toCalculatePayments()
        {
            throw new NotImplementedException();
        }
    }
}