using System;

namespace Office.Entities
{
    public class Director : Worker, IDirector
    {
        public Worker forceToWork(Worker[] positions) //события?
        {
            var rand = new Random();
            int curPos = rand.Next(5); //5 чтобы не заставлять директора работать
            return positions[curPos];
        }
    }
}