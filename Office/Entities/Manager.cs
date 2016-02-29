using System;

namespace Office.Entities
{
    public class Manager : Worker, IManager
    {
        public bool toSellServices(int hours)
        {
            throw new NotImplementedException();
        }
    }
}