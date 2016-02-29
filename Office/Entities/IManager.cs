using System;

namespace Office
{
    public interface IManager : IWorker
    {
        int moneyPerMonth;
        bool toSellServices(int hours);
    }
}