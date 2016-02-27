using System;

namespace Office
{
    public interface IProgrammer : IWorker
    {
        public bool toWriteCode(int hours);
    }
}