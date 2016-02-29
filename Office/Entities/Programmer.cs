using System;

namespace Office.Entities
{
    public class Programmer : Worker, IProgrammer
    {
        const bool isFixedPayment = false;
        const int moneyPerHour = 50;
        public bool toWriteCode(int hours)
        {
            throw new NotImplementedException();
        }
    }s
}