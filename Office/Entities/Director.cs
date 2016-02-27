using System;

namespace Office.Entities
{
    public class Director : Worker, IDirector
    {
        public Worker forceToWork() //события?
        {
            throw new NotImplementedException();
        }
    }
}