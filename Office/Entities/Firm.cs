using System.Collections.Generic;
using System.Collections;
using System;
using System.Linq;

namespace Office.Entities
{
    public class Firm
    {

        public Worker[] posiblePositions = 
        {
           new Booker(), new Manager(), new Designer(), new Programmer(), 
           new Tester(), new Director()
        };

        //через типы? 
        public Type[] pos = 
        {
            typeof(Booker), typeof(Manager), typeof(Designer), typeof(Programmer), typeof(Tester), typeof(Director)
        };


        public Firm()
        {
       
        }

        public void workflow()
        {

        }
    }
}