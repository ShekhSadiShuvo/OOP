using NUnit.Framework;
using System.Diagnostics.Metrics;

namespace ClockClass;

public class CounterTests
{
    [Test]
    public void Counter_Initialises_At_Zero()
    {
        
        Counter counter = new Counter("testCounter");

        
        int count = counter.Ticks;

        
        Assert.That(count, Is.EqualTo(0));
    }

    [Test]
    public void Counter_Increment_Adds_One_To_Count()
    {

        Counter counter = new Counter("testCounter");


        counter.Increment();
        int count = counter.Ticks;


        Assert.That(count, Is.EqualTo(1));
    }

    [Test]
    public void Counter_Increment_Multiple_Times_Increases_Count_To_Match()
    {

        Counter counter = new Counter("testCounter");


        counter.Increment();
        counter.Increment();
        counter.Increment();
        int count = counter.Ticks;


        Assert.That(count, Is.EqualTo(3));
    }

    [Test]
    public void Counter_Reset_Sets_Count_To_Zero()
    {

        Counter counter = new Counter("testCounter");
        counter.Increment();
        counter.Increment();


        counter.Reset();
        int count = counter.Ticks;


        Assert.That(count, Is.EqualTo(0));
    }
}


