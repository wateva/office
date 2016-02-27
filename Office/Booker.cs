using System;
using System.Collections.Generic;

namespace Office
{
    public class Booker : Worker, IBooker
    {
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