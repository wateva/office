using System.Collections.Generic;

namespace Office.Entities
{
    public interface IBooker : IWorker
    {
        int moneyPerMonth;
        bool toMakeReport(int hours);
        Dictionary<Employee, int> toCalculateSalary();
    }

}

