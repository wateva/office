using System;

namespace Office
{
    public interface IManager : IWorker
    {
        public bool toSellServices(int hours);
    }
}