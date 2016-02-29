using System;

namespace Office.Entities
{
    public class Programmer : Worker, IProgrammer
    {
        public int payment = 50;
        public bool isFixedPay = false;
        public Worker RealWorker;

        public bool toWriteCode(int hours)
        {
            throw new NotImplementedException();
        }
    }
}