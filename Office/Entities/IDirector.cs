namespace Office.Entities
{
    public interface IDirector : IWorker
    {
        int moneyPerMonth;
        Worker forceToWork();
    }
}