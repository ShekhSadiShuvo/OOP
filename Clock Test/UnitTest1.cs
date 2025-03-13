using ClockClass;

namespace ClockClass;
public class ClockTests
{
    [Test]
    public void Clock_Initialises_At_Zero()
    {
        // Arrange
        Clock clock = new Clock();

        // Act
        string time = clock.GetTime();

        // Assert
        Assert.That(time, Is.EqualTo("00:00:00"));
    }

    [Test]
    public void Clock_Tick_Increases_Seconds_By_One()
    {

        Clock clock = new Clock();


        clock.Tick();
        string time = clock.GetTime();


        Assert.That(time, Is.EqualTo("00:00:01"));
    }

    [Test]
    public void Clock_Tick_60_Times_Increases_Minutes_By_One()
    {

        Clock clock = new Clock();


        for (int i = 0; i < 60; i++)
        {
            clock.Tick();
        }
        string time = clock.GetTime();


        Assert.That(time, Is.EqualTo("00:01:00"));
    }

    [Test]
    public void Clock_Tick_3600_Times_Increases_Hours_By_One()
    {

        Clock clock = new Clock();


        for (int i = 0; i < 3600; i++)
        {
            clock.Tick();
        }
        string time = clock.GetTime();


        Assert.That(time, Is.EqualTo("01:00:00"));
    }

    [Test]
    public void Clock_Reset_Sets_Time_To_Zero()
    {

        Clock clock = new Clock();
        clock.Tick();
        clock.Tick();
        clock.Tick();


        clock.Reset();
        string time = clock.GetTime();


        Assert.That(time, Is.EqualTo("00:00:00"));
    }
}