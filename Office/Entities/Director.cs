using System;
using System.Collections.Generic;
using System.Linq;

namespace Office.Entities
{
    public class Director : Worker, IDirector
    {
        public int payment = 2500;
        public bool isFixedPay = true;
        public Worker RealWorker;

        public newTask forceToWork()
        {
            return new newTask()
            {
                howMuchTimeToWork = new Random((int)DateTime.Now.Ticks).Next(1, 3),
                howManyPeopleToWork = new Random((int)DateTime.Now.Ticks).Next(1, 20)
            };
        }
        //ниже идут функции для поиска свободного работника. среди всего множества работнков берется конкретная должность, далее выбираются те, 
        //которые не заняты и не будут перерабатывать. После чего задание выдается одному работнику и происходит выхожд из фунции. При повторном заходе 
        // в нее задание будет выдано уже следующему свободному работнику.
        public bool giveTaskForManager(HashSet<Worker> EmployeePositions, int hours)
        {
            foreach (
                var manager in
                    EmployeePositions.OfType<Manager>()
                        .Where(manager => manager.RealWorker.hoursRemainToWork == 0 &&
                                          manager.RealWorker.hoursAlreadyWorked + hours <=
                                          manager.RealWorker.shedule))
            {
                manager.toSellServices(hours);
                return true;
            }
            return false;
        }

        public bool giveTaskForDesigner(HashSet<Worker> EmployeePositions, int hours)
        {
            foreach (
                var designer in
                    EmployeePositions.OfType<Designer>()
                        .Where(designer => designer.RealWorker.hoursRemainToWork == 0 &&
                                           designer.RealWorker.hoursAlreadyWorked + hours <=
                                           designer.RealWorker.shedule))
            {
                designer.toDrawLayout(hours);
                return true;
            }
            return false;
        }

        public bool giveTaskForBooker(HashSet<Worker> EmployeePositions, int hours)
        {
            foreach (
                var booker in
                    EmployeePositions.OfType<Booker>()
                        .Where(booker => booker.RealWorker.hoursRemainToWork == 0 &&
                                         booker.RealWorker.hoursAlreadyWorked + hours <=
                                         booker.RealWorker.shedule))
            {
                booker.toMakeReport(hours);
                return true;
            }
            return false;
        }

        public bool giveTaskForTester(HashSet<Worker> EmployeePositions, int hours)
        {
            foreach (
                var tester in
                    EmployeePositions.OfType<Tester>()
                        .Where(tester => tester.RealWorker.hoursRemainToWork == 0 &&
                                         tester.RealWorker.hoursAlreadyWorked + hours <=
                                         tester.RealWorker.shedule))
            {
                tester.toTestProgramm(hours);
                return true;
            }
            return false;
        }

        public bool giveTaskForProgrammer(HashSet<Worker> EmployeePositions, int hours)
        {
            foreach (
                var programmer in
                    EmployeePositions.OfType<Programmer>()
                        .Where(programmer => programmer.RealWorker.hoursRemainToWork == 0 &&
                                             programmer.RealWorker.hoursAlreadyWorked + hours <=
                                             programmer.RealWorker.shedule))
            {
                programmer.toWriteCode(hours);
                return true;
            }
            return false;
        }

    }
}