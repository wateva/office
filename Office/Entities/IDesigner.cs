using System;
using System;

namespace Office
{   
    public interface IDesigner : IWorker
    { 
        bool toDrawLayout(int hours);
    }
}