using System;

namespace Office
{
    public interface IProgrammer : IWorker
    {
        int moneyPerHour;
        bool toWriteCode(int hours);
    }
}