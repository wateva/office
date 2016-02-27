using System;
using System.Collections;
using System.Collections.Generic;

public class Employee
{
    private ArrayList positionsList;
    private int paymeent;
    private bool isFixedPayment;
    private int shedule;
    private string[] posiblePositions = new string[6]
    {
        "programmer", "designer", "tester", "manager", "director","booker"
    };

    private var paymentDepence = new Dictionary<string, int>()
    {
        {"programmer", 50},
        {"designer", 40},
        {"tester", 30},
        {"manager", 20},
        {"director", 2400},
        {"booker", 2400}
    };
	public Employee()
	{
        var rand = new Random();
	    this.shedule = rand.Next(40) + 1;
        //генерирование должностей для сотрудника
        int posCount = rand.Next(1 , 7);//количество должностей сотрудника
        positionsList = new ArrayList();
        int curPos;
        for (int i = 0; i < posCount; i++)
        {
            curPos = rand.Next(6);
            if (this.positionsList.Contains(posiblePositions[curPos]) == false) // должности не должны повторяться
                this.positionsList[i] = posiblePositions[curPos];
            if (this.positionsList[i] == "")
        }

	}
}
