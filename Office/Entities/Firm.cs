using System.Collections.Generic;
using System.Collections;
using System;
using System.Linq;
using System.Reflection;


namespace Office.Entities
{
    public class Firm
    {
        public int days;
        public Type[] posiblePositions =
        {
            typeof (Booker), typeof (Manager), typeof (Designer), typeof (Programmer), typeof (Tester),
            typeof (Director)
        };
        public string[] reportArr;
        public HashSet<Worker> EmployeePositionsSet;
        public ArrayList EmployeeList;

        public Firm()
        {
            reportArr = new string[4];
            days = 0;
            EmployeeList = new ArrayList();
            EmployeePositionsSet = new HashSet<Worker>();
            generateEmployees();
            //checkForImportantPositions();
        }

        public void generateEmployees()
        {
            var rand = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < rand.Next(10, 101); i++)
            {
                var worker = new Worker(rand.Next(1, 41));
                EmployeeList.Add(worker);
                for (int j = 0; j < rand.Next(1, 5); j++)
                {
                    Worker specializedWorker =  Activator.CreateInstance(posiblePositions[rand.Next(6)], worker) as Worker;
                    //specializedWorker.RealWorker = worker;
                    EmployeePositionsSet.Add(specializedWorker);
                }
            }
        }

        public void checkForImportantPositions()
        {
            if (!EmployeePositionsSet.OfType<Director>().Any())
                EmployeePositionsSet.Add(new Director((Worker) EmployeeList[0]));
            if (!EmployeePositionsSet.OfType<Booker>().Any())
                EmployeePositionsSet.Add(new Booker((Worker) EmployeeList[1]));
            if (!EmployeePositionsSet.OfType<Manager>().Any())
                EmployeePositionsSet.Add(new Manager((Worker)EmployeeList[2]));
        }

        public void workflow()
        {
            if (days == 30) days = 0;
            minusOneDay(EmployeePositionsSet);
            ordersFromDirectors(EmployeePositionsSet);
            days++;
            if (days % 7 == 0)
            {
                foreach (var worker in EmployeePositionsSet.OfType<Director>())
                    worker.RealWorker.earnedMoney += worker.payment;
                foreach (var worker in EmployeePositionsSet.OfType<Manager>())
                    worker.RealWorker.earnedMoney += worker.payment;
                foreach (var worker in EmployeePositionsSet.OfType<Booker>())
                    worker.RealWorker.earnedMoney += worker.payment;
                
                reportArr[days / 7 - 1] = Booker.CalculatePaymentsForAWeek(EmployeePositionsSet, EmployeeList);
            }
        }

        public void ordersFromDirectors(HashSet<Worker> EmployeePositions)
        {
            foreach (var director in EmployeePositions.OfType<Director>())
            {
                var task = director.forceToWork();
                for (int i = 0; i < task.howManyPeopleToWork;)
                {
                    int startIter = i;
                    if (i <= task.howManyPeopleToWork && director.giveTaskForBooker(EmployeePositions, task.howMuchTimeToWork)) i++;
                    if (i <= task.howManyPeopleToWork && director.giveTaskForDesigner(EmployeePositions, task.howMuchTimeToWork)) i++;
                    if (i <= task.howManyPeopleToWork && director.giveTaskForManager(EmployeePositions, task.howMuchTimeToWork)) i++;
                    if (i <= task.howManyPeopleToWork && director.giveTaskForProgrammer(EmployeePositions, task.howMuchTimeToWork)) i++;
                    if (i <= task.howManyPeopleToWork && director.giveTaskForTester(EmployeePositions, task.howMuchTimeToWork)) i++;
                    if (i==startIter) break; //на аутсорс
                }
            }
        }

        public void minusOneDay(HashSet<Worker> EmployeePositions)
        {
            Worker realWorker;
            foreach (var worker in EmployeePositions.Where(x => x.hoursRemainToWork != 0))
            {
                realWorker = (Worker)worker.GetType().GetField("RealWorker").GetValue(worker);
                realWorker.hoursAlreadyWorked++;
                realWorker.hoursRemainToWork--;
                //realWorker.earnedMoney += (int)worker.GetType().GetProperty("payment").GetValue(worker);
                if(!(bool)worker.GetType().GetField("isFixedPay").GetValue(worker))
                    realWorker.earnedMoney += (int)worker.GetType().GetField("payment").GetValue(worker);
            }
        }       
    }

    public struct newTask
    {
        public int howManyPeopleToWork;
        public int howMuchTimeToWork;
    }
}