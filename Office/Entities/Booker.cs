using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Office.Entities
{
    public class Booker : Worker, IBooker
    {
        public int payment = 2300;
        public bool isFixedPay = true;
        public new Worker RealWorker;
        private int hoursRemainToWork;
        private int shedule;
        private int earnedMoney;
        private int hoursAlreadyWorked;

        public Booker(Worker worker)
        {
            RealWorker = worker;
        }

        public bool toMakeReport(int hours)
        {
            hoursRemainToWork = hours;
            return true;
        }

        static public string CalculatePaymentsForAWeek(HashSet<Worker> employeesSet, ArrayList employeeList)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < employeeList.Count; i++)
            {
                int earnedMoney;
                var shedule = (employeeList[i] as Worker).shedule;
                var hoursAlreadyWorked = (employeeList[i] as Worker).hoursAlreadyWorked;
                if (employeeList[i] is Director) earnedMoney = (employeeList[i] as Director).payment;
                else if (employeeList[i] is Manager) earnedMoney = (employeeList[i] as Manager).payment;
                earnedMoney = (employeeList[i] as Worker).earnedMoney;

                sb.AppendLine(String.Format("worker №{0} - max hours/week - {1}, hours worked - {2}, money earned {3}",
                    i, shedule, hoursAlreadyWorked, earnedMoney));

                (employeeList[i] as Worker).earnedMoney = 0;
                (employeeList[i] as Worker).hoursAlreadyWorked = 0;
                (employeeList[i] as Worker).hoursRemainToWork = 0;
            }
            return sb.ToString();
        }

        static public string monthReport()
        {
            throw new NotImplementedException();
        }
    }
}