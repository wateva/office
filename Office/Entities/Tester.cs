using System;

namespace Office.Entities
{
    public class Tester: Worker, ITester
    {
        const bool isFixedPayment = false;
        const int moneyPerHour = 40;
        private bool toTestProgramm()
        {
            throw new NotImplementedException();
        }
    }
}