using System;
using System.Collections.Generic;
using System.Text;

namespace AlarmSystem
{
    public abstract class HazardSensor : IHazardSensor
    {
        protected const double _MaxBattery = 100;
        protected const double _MinBattery = 0;

        protected string _location;
        protected double _batteryPercent;

        public abstract bool IsTriggered { get; set; }

        public HazardSensor(string location)
        {
            _location = location ?? throw new ArgumentNullException("Location must not be null.");

            _batteryPercent = _MaxBattery;
        }

        public string GetLocation()
        {
            return _location;
        }

        public abstract string GetSensorType();

        public double GetBatteryPercentage()
        {
            return _batteryPercent;
        }
    }
}
