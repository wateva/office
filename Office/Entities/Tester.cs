using System;

namespace Office.Entities
{
    public class Tester: Worker, ITester
    {
        public int payment = 40;
        public bool isFixedPay = false;
        public Worker RealWorker;

        public bool toTestProgramm(int hours)
        {
            throw new NotImplementedException();
        }
    }
}