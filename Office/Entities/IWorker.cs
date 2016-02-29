using System;

namespace Office
{
    public interface IWorker
    {
        bool isFixedPayment;
        int getRemaininghours { get; }
    }
}
