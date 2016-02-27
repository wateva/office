using System;

namespace Office
{
    public interface ITester : IWorker
    {
        public bool toTestProgramm(int hours);
    }