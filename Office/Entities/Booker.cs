using System;
using System.Collections.Generic;

namespace Office.Entities
{
    public class Booker : Worker, IBooker
    {
        const int moneyPerMonth = 2100;
        const bool isFixedPaymen = true;;
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