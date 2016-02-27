﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Office
{
    public class Employee
    {
        private Set<Worker> positionsSet;
        private int paymeent;
        private int earnedMoney;
        private bool isFixedPayment;
        private int shedule;

        public Employee()
        {
            var rand = new Random();
            this.shedule = rand.Next(40) + 1;
            this.positionsSet = generatePosions(Firm.posiblePositions);
        }

        private Set<Worker> generatePosions(string[] positions)
        {
            result = new ArrayList();
            int currentPos;
            int posCount = rand.Next(1, 7); //количество должностей сотрудника

            for (int i = 0; i < posCount; i++)
            {
                while (result[i] == null)
                {
                    currentPos = rand.Next(6);
                    if (this.result.Contains(positions[currentPos]) == false) // должности не должны повторяться
                        this.result[i] = positions[currentPos];
                }
            }
            return result;
        }
    }
}