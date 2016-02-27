using System;

public class Firm
{
    protected string[] posiblePositions = new string[6]
    {
        "programmer", "designer", "tester", "manager", "director", "booker"
    };

    protected var paymentDepence = new Dictionary<string, int>()
    {
        {"programmer", 50},
        {"designer", 40},
        {"tester", 30},
        {"manager", 20},
        {"director", 2400},
        {"booker", 2400}
    };
    public Firm()
	{
	}
}
