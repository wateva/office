using System.Collections.Generic;
using System.Collections;
using System;
using System.Linq;


namespace Office.Entities
{
    public class Firm
    {
        public Type[] posiblePositions =
        {
            typeof (Booker), typeof (Manager), typeof (Designer), typeof (Programmer), typeof (Tester), typeof (Director)
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

      

        public void workflow()
        {


        }
    }
    public struct newTask
    {
        public string whoToWork;
        public int howMuchTimeToWork;
    }
}