namespace Office.Entities
{
    public interface IDirector : IWorker
    {
        newTask forceToWork(Employee[] list, string[] posiblePositions);
    }
}