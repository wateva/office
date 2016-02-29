using System;

namespace Office.Entities
{
    public class Manager : Worker, IManager
    {
        const int moneyPerMonth = 2000;
        const bool isFixedPayment = true;
        public bool toSellServices(int hours)
        {
            throw new NotImplementedException();
        }
    }
}