using System;

namespace Office
{
    public class Worker : IWorker
    {
        public int hoursRemainToWork;
        public int shedule;
        public int earnedMoney;
        public int hoursAlreadyWorked;
        public Worker RealWorker;

        public Worker()
        {
            shedule = new Random((int)DateTime.Now.Ticks).Next(1, 41);
            hoursRemainToWork = 0;
            earnedMoney = 0;
            Worker RealWorker = null;
        }
    }
}