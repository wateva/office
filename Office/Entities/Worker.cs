namespace Office
{
    public class Worker : IWorker
    {
        bool isFixedPayment;
        private int RemainHoursToWork;
        public int getRemaininghours {
            private set { }
            get { return RemainHoursToWork;}
        }
    }
}