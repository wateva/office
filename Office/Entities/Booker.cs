using System;
using System.Collections.Generic;

namespace Office.Entities
{
    public class Booker : Worker, IBooker
    {

        public int payment = 2300;
        public bool isFixedPay = true;
        public Worker RealWorker;

        public  bool toMakeReport(int hours)
        {
            throw new NotImplementedException();
        }

        public Dictionary<Employee, int> toCalculatePayments()
        {
            throw new NotImplementedException();
        }
    }
}