using System;
using System.Collections.Generic;
using System.Linq;

namespace Office.Entities
{
    public class Employee
    {
        public HashSet<string> positionsSet;
        private int paymeent;
        private int earnedMoney;
        private int timeSpent;
        private bool isFixedPayment;
        private int shedule;

        public Employee()
        {
            timeSpent = 0;
            var rand = new Random();
            shedule = rand.Next(40) + 1; //сгенерировать количетство часов в неделю
            //positionsSet = generatePosions(Firm.posiblePositions); //сгенерировать список должностьей работника
            if (positionsSet.Contains("director") || positionsSet.Contains("manager") || positionsSet.Contains("booker"))
            {
                isFixedPayment = true;
            }
            else
            {
                isFixedPayment = false;
            }

    }

        private HashSet<string> generatePosions(string[] positions)
        {
            var rand = new Random();
            var resultSet = new HashSet<string>();
            int posCount = rand.Next(1, 7); //количество должностей сотрудника

            for (int i = 0; i < posCount; i++)
            {
                var currentPos = rand.Next(6);
                if (resultSet.Contains(positions[currentPos]) == false) // должности не должны повторяться
                    resultSet.Add(positions[currentPos]);
            }
            return resultSet;
        }
    }
}