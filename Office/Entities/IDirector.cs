namespace Office.Entities
{
    public interface IDirector : IWorker
    {
        Worker forceToWork();
    }
}