using System.Collections.Generic;

namespace Office.Entities
{
    public interface IBooker : IWorker
    {
        bool toMakeReport(int hours);
        Dictionary<Worker, int> toCalculatePayments();
    }

}

