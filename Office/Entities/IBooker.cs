using System.Collections.Generic;
using System.Collections;

namespace Office.Entities
{
    public interface IBooker : IWorker
    {
        bool toMakeReport(int hours);
    }
}

