using System;
using System.Collections.Generic;
using System.Text;

namespace AlarmSystem
{
    public class SecurityControlUnit : ControlUnit
    {
        public SecurityControlUnit(List<ISensor> securitySensors) : base (securitySensors)
        {
        }

        public override void PollSensors()
        {
            TimeSpan pollStartTime = TimeSpan.Parse("22:00");
            TimeSpan pollEndTime = TimeSpan.Parse("06:00");
            TimeSpan currentTime = DateTime.Now.TimeOfDay;

            if (currentTime >= pollStartTime || currentTime <= pollEndTime)
            {
                base.PollSensors();
            }
            else
            {
                Console.WriteLine("Sensors can only be polled between 22:00 and 06:00.");
            }
        }
    }
}
