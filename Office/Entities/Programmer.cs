using System;

namespace Office.Entities
{
    public class Programmer : Worker, IProgrammer
    {
        public bool toWriteCode(int hours)
        {
            throw new NotImplementedException();
        }
    }
}