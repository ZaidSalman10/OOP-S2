using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class ClockType
    {
        public int hours;
        public int minutes;
        public int seconds; 

        public ClockType(int hours = 0, int minutes = 0, int seconds = 0)
        {
            SetTime(hours, minutes, seconds);
        }
        public void SetTime(int hours, int minutes, int seconds)
        {
            this.hours = (hours >= 0 && hours < 24) ? hours : 0;
            this.minutes = (minutes >= 0 && minutes < 60) ? minutes : 0;
            this.seconds = (seconds >= 0 && seconds < 60) ? seconds : 0;
        }
        public void GetTime(out int hours, out int minutes, out int seconds)
        {
            hours = this.hours;
            minutes = this.minutes;
            seconds = this.seconds;
        }
        public int GetElapsedSeconds()
        {
            return hours * 3600 + minutes * 60 + seconds;
        }
        public int GetRemainingSeconds()
        {
            const int secondsInDay = 86400; 
            return secondsInDay - GetElapsedSeconds();
        }
        public int GetTimeDifference(ClockType otherClock)
        {
            return Math.Abs(GetElapsedSeconds() - otherClock.GetElapsedSeconds());
        }
        public void DisplayTime()
        {
            Console.WriteLine($"{hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
