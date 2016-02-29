using System;

namespace Office.Entities
{
    public class Director : Worker, IDirector
    {
        public int payment = 2500;
        public bool isFixedPay = true;
        public Worker RealWorker;

        public newTask forceToWork(Employee[] list, string[]  posiblePositions) //события?
        {
            var rand = new Random();
            var result = new newTask
            {
                whoToWork = posiblePositions[rand.Next(6)],
                howMuchTimeToWork = rand.Next(1, 3)
            };
            return result;
        }
    }
}