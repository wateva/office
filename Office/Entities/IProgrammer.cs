using System;

namespace Office
{
    public interface IProgrammer : IWorker
    {
        bool toWriteCode(int hours);
    }
}