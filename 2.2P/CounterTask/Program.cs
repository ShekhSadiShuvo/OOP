﻿namespace CounterTask;

class Program

{


    public static void Main(string[] args)
    {
        Counter[] myCounters = new Counter[3];
        int i;

        myCounters[0] = new Counter("Counter 1");
        myCounters[1] = new Counter("Counter 2");
        myCounters[2] = myCounters[0];

        for (i = 0; i < 10; i++)
        {
            myCounters[0].Increment();
        }

        for (i = 0; i < 15; i++)
        {
            myCounters[1].Increment();
        }

        PrintCounters(myCounters);

        myCounters[2].Reset();

        PrintCounters(myCounters);

        Console.ReadLine();
    }
    private static void PrintCounters(Counter[] counters)
    {
        foreach (Counter c in counters)
        {
            Console.WriteLine("{0} is {1}", c.Name, c.Ticks);
        }
    }

}