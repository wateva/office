using System.Collections.Generic;
using System.Collections;
using System;
using System.Linq;
using System.Reflection;


namespace Office.Entities
{
    public class Firm
    {
        public Type[] posiblePositions =
        {
            typeof (Booker), typeof (Manager), typeof (Designer), typeof (Programmer), typeof (Tester),
            typeof (Director)
        };

        public HashSet<Worker> EmployeePositionsSet;
        public ArrayList EmployeeList;

        public Firm()
        {
            EmployeeList = new ArrayList();
            EmployeePositionsSet = new HashSet<Worker>();
            generateEmployees();
            checkForImportantPositions();
        }


        public void generateEmployees()
        {
            var rand = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < rand.Next(10, 101); i++)
            {
                var worker = new Worker();
                EmployeeList.Add(worker);
                for (int j = 0; j < rand.Next(1, 5); j++)
                {
                    Worker specWorker = (Worker) Activator.CreateInstance(posiblePositions[rand.Next(6)]);
                    specWorker.RealWorker = worker;
                    EmployeePositionsSet.Add(specWorker);
                }
            }
        }

        public void checkForImportantPositions()
        {
            if (!EmployeePositionsSet.OfType<Director>().Any())
                EmployeePositionsSet.Add(new Director
                {
                    RealWorker = (Worker) EmployeeList[0]
                });
            if (!EmployeePositionsSet.OfType<Booker>().Any())
                EmployeePositionsSet.Add(new Booker
                {
                    RealWorker = (Worker) EmployeeList[0]
                });
            if (!EmployeePositionsSet.OfType<Manager>().Any())
                EmployeePositionsSet.Add(new Manager
                {
                    RealWorker = (Worker) EmployeeList[0]
                });
        }



        public void workflow()
        {
            minusOneDay();
            ordersFromDirectors(EmployeePositionsSet);

        }

        public void ordersFromDirectors(HashSet<Worker> EmployeePositions)
        {
            foreach (var director in EmployeePositions.OfType<Director>())
            {
                var task = director.forceToWork();
                for (int i = 0; i < task.howManyPeopleToWork;)
                {
                    int startIter = i;
                    if (director.giveTaskForBooker(EmployeePositions, task.howMuchTimeToWork)) i++;
                    if (director.giveTaskForDesigner(EmployeePositions, task.howMuchTimeToWork)) i++;
                    if (director.giveTaskForManager(EmployeePositions, task.howMuchTimeToWork)) i++;
                    if (director.giveTaskForProgrammer(EmployeePositions, task.howMuchTimeToWork)) i++;
                    if (director.giveTaskForTester(EmployeePositions, task.howMuchTimeToWork)) i++;
                    if (i==startIter) break; //на аутсорс
                }
            }
        }

        public void minusOneDay()
        {
            foreach (var worker in EmployeePositionsSet.Where(x => x.RealWorker.hoursRemainToWork != 0))
            {
                worker.RealWorker.hoursAlreadyWorked++;
                worker.RealWorker.hoursRemainToWork--;
                //worker.earnedMoney += worker.
            }
        }

        
    }

    public struct newTask
    {
        public int howManyPeopleToWork;
        public int howMuchTimeToWork;
    }
}