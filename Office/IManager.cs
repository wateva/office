using System;

namespace Office
{
    public interface IManager : IWorker
    {
        bool toSellServices(int hours);
    }
}