using System;
using System.Collections;
using System.Collections.Generic;

namespace Office
{
    public class Employee
    {
        private HashSet<Worker> positionsSet;
        private int paymeent;
        private int earnedMoney;
        private bool isFixedPayment;
        private int shedule;

        public Employee()
        {
            var rand = new Random();
            shedule = rand.Next(40) + 1;
            positionsSet = generatePosions(Firm.posiblePositions);
        }

        private HashSet<Worker> generatePosions(string[] positions)
        {
            var rand = new Random();
            var result = new HashSet<Worker>();
            int currentPos;
            int posCount = rand.Next(1, 7); //количество должностей сотрудника

            for (int i = 0; i < posCount; i++)
            {
                currentPos = rand.Next(6);
                if (result.Contains(positions[currentPos]) == false) // должности не должны повторяться
                    result = positions[currentPos];

            }
            return result;
        }
    }
}