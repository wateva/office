using System;
using System.Collections.Generic;

namespace Office.Entities
{
    public class Booker : Worker, IBooker
    {
        private const int moneyPerMonth = 2300;
        const bool isFixedPayment = true;s
       public  bool toMakeReport(int hours)
        {
            throw new NotImplementedException();
        }

        public Dictionary<Employee, int> toCalculateSalary()
        {
            throw new NotImplementedException();
        }
    }
}