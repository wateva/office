using System;

namespace Office.Entities
{
    public interface IDirector : IWorker
    {
        newTask forceToWork();
    }
}