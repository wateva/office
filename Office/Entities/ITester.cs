using System;

namespace Office
{
    public interface ITester : IWorker
    {
        bool toTestProgramm(int hours);
    }
}