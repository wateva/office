using System;

namespace Office
{
    public class Worker : IWorker
    {
        public int hoursRemainToWork;
        public int shedule;
        public int earnedMoney;
        public int hoursAlreadyWorked;
        //public Worker RealWorker;
        public Worker() {}

        public Worker(int rand)
        {
            shedule = rand;
            hoursRemainToWork = 0;
            earnedMoney = 0;
            //Worker RealWorker = this;
        }
    }
}