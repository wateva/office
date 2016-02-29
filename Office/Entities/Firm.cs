using System.Collections.Generic;
using System.Collections;
using System;
using System.Linq;

namespace Office.Entities
{
    public class Firm
    {
        static public string[] posiblePositions = 
        {
            "programmer", "tester", "designer", "manager", "booker", "director"
        };

        public static Dictionary<string, int> paymentTable = new Dictionary<string, int>()
        {
            {"programmer", 20},
            {"tester", 15},
            {"designer", 20},
            {"manager", 25},
            {"booker", 30},
            {"director", 35}
        };
        public Employee[] listOfEmployees;

        public Firm()
        {
            //в начале работы программы формируется список сотрудников, им назначаются должности, зарплаты и количество рабочих часов
            listOfEmployees = new Employee[new Random().Next(10, 101)];
            for(int i = 0; i < listOfEmployees.Count(); i++)
            {
                listOfEmployees[i] = new Employee();
            }
            //на случай если не сгенерировалось ни одного директора, бухгалтера или менеджера (допустимо больше одного - без проверки)
                listOfEmployees[0].positionsSet.Add("director");            
                listOfEmployees[1].positionsSet.Add("booker");
                listOfEmployees[2].positionsSet.Add("manager");
        }

        public void workflow()
        {

        }
    }
}