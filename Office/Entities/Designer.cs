using System;

namespace Office.Entities
{
    public class Designer : Worker, IDesigner
    {
        public int payment = 35;
        public bool isFixedPay = false;
        public Worker RealWorker;

        public bool toDrawLayout(int hours)
        {
            throw  new NotImplementedException();
        }
    }
}