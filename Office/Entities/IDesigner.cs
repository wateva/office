using System;
using System;

namespace Office
{   
    public interface IDesigner : IWorker
    {
        int moneyPerHour;
        bool toDrawMaket(int hours);
    }
}