using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClockClass
{
    public class Clock
    {
        private Counter hoursCounter;
        private Counter minutesCounter;
        private Counter secondsCounter;

        public Clock()
        {
            hoursCounter = new Counter("hours");
            minutesCounter = new Counter("minutes");
            secondsCounter = new Counter("seconds");
        }

        public void Tick()
        {
            secondsCounter.Increment();
            if (secondsCounter.Ticks == 60)
            {
                secondsCounter.Reset();
                minutesCounter.Increment();
            }
            if (minutesCounter.Ticks == 60)
            {
                minutesCounter.Reset();
                hoursCounter.Increment();
            }
            if (hoursCounter.Ticks == 24)
            {
                hoursCounter.Reset();
            }
        }

        public void Reset()
        {
            hoursCounter.Reset();
            minutesCounter.Reset();
            secondsCounter.Reset();
        }

        public string GetTime()
        {
            return $"{hoursCounter.Ticks:00}:{minutesCounter.Ticks:00}:{secondsCounter.Ticks:00}";
        }
    }


}