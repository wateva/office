using System;
using System.Collections.Generic;

namespace Office
{
    public interface IBooker : IWorker
    {
        bool toMakeReport(int hours);
        Dictionary<Employee, int> toCalculateSalary();
    }

}

