using System;

namespace Office
{
    public interface IBooker : IWorker
    {
        public bool toMakeReport(int hours);
        public IDictionay<Employee, int> toCalculateSalary();
    }

}

