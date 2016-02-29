using System.Collections.Generic;
using System.Collections;
using System;
using System.Linq;
using System.Runtime.Remoting.Metadata;

namespace Office.Entities
{
    public class Firm
    {
//    //на случай если не сгенерировалось ни одного директора, бухгалтера или менеджера (допустимо больше одного - без проверки)
        //        listOfEmployees[0].positionsSet.Add("director");            
        //        listOfEmployees[1].positionsSet.Add("booker");
        //        listOfEmployees[2].positionsSet.Add("manager");
        //}

        //public void workflow()
        //{

        //}

        //private void newHour(Employee[] list)
        //{

        //}

        //private void minusOneHourToAll(Employee[] list)
        //{
        //    foreach (var worker in listOfEmployees)
        //    {
        //        if (worker.toWork > 0)
        //        {
        //            worker.toWork--;
        //            worker.timeSpent++;
        //        }
        //    }
        //}
        public Type[] posiblePositions =
        {
            typeof (Booker), typeof (Manager), typeof (Designer), typeof (Programmer), typeof (Tester),
            typeof (Director)
        };

        public HashSet<Worker> EmployeePosiionsSet;
        public ArrayList EmployeeList;

        public Firm()
        {
            generateEmployees();
            checkForImportantPositions();

        }


        public void generateEmployees()
        {
            var rand = new Random();
            for (int i = 0; i < rand.Next(10, 101); i++)
            {
                var worker = new Worker();
                EmployeeList.Add(worker);
                for (int j = 0; j < rand.Next(1, 5); j++)
                {
                    Worker specWorker = (Worker)Activator.CreateInstance(posiblePositions[rand.Next(6)]);
                    specWorker.RealWorker = worker;
                    EmployeePosiionsSet.Add(specWorker);
                }
            }
        }

        public void checkForImportantPositions()
        {
            if (!EmployeePosiionsSet.OfType<Director>().Any())
                EmployeePosiionsSet.Add(new Director
                {
                    RealWorker = (Worker)EmployeeList[0]
                });
            if (!EmployeePosiionsSet.OfType<Booker>().Any())
                EmployeePosiionsSet.Add(new Booker
                {
                    RealWorker = (Worker)EmployeeList[0]
                });
            if (!EmployeePosiionsSet.OfType<Manager>().Any())
                EmployeePosiionsSet.Add(new Manager
                {
                    RealWorker = (Worker)EmployeeList[0]
                });
        }

        public struct newTask
        {
            public string whoToWork;
            public int howMuchTimeToWork;
        }
    }
}