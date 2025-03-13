using System;
using ClockClass;



class Program
{
    static void Main(string[] args)
    {
        Clock clock = new Clock();

        
        for (int i = 0; i < 100; i++)
        {
            clock.Tick();
            Console.WriteLine(clock.GetTime());
        }

       
        clock.Reset();
        Console.WriteLine(clock.GetTime());

        
        Console.ReadLine();
    }
}
