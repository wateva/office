using System.Collections.Generic;
using System.Collections;
using System;

namespace Office.Entities
{
    public class Firm
    {
        public Worker[] posiblePositions = new Worker[6]
        {
           new Booker(), new Manager(), new Designer(), new Programmer(), 
           new Tester(), new Director()
        };

        //sorry for this.
        public ArrayList listOfEmployees;
        public ArrayList listOfBookers;
        public ArrayList listOfDesigners;
        public ArrayList listOfManagers;
        public ArrayList listOfProgrammers;
        public ArrayList listOfTesters;

        public Firm()
        {
            //создать список сотрудников и список для каждой должности кроме директора
            listOfEmployees = new ArrayList();
            listOfBookers = new ArrayList();
            listOfDesigners = new ArrayList();
            listOfManagers = new ArrayList();
            listOfProgrammers = new ArrayList();
            listOfTesters = new ArrayList();
            
            var rand = new Random();
            for (int i = 0; i < rand.Next(10, 101); i++)
            {
                //todo:fill list of employees with random count of random workers
                //todo:pass throught the array of employees and add links on neccessaty object to suitable lists
                listOfEmployees.Add(new posiblePositions[rand.Next(6)].GetType()); // не работает.
            }
        }

        public void workflow()
        {

        }
    }
}