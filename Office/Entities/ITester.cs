using System;

namespace Office
{
    public interface ITester : IWorker
    {
        int moneyPerHour;
        bool toTestProgramm(int hours);
    }
}