using System;

namespace Office.Entities
{
    public class Designer : Worker, IDesigner
    {
        const int moneyPerHour = 60;
        const bool isFixedPayment = false;
        public bool toDrawLayout(int hours)
        {
            throw  new NotImplementedException();
        }
    }
}