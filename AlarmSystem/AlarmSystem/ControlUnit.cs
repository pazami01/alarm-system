using System;
using System.Collections.Generic;

namespace AlarmSystem
{
    public class ControlUnit
    {
        private List<ISensor> _sensors;

        public ControlUnit(List<ISensor> sensors)
        {
            if (sensors == null) { throw new ArgumentNullException("List of sensors must not be null."); }

            foreach (var sensor in sensors)
            {
                if (sensor == null) { throw new ArgumentNullException("List of sensors must not contain null."); }
            }

            _sensors = sensors;
        }

        public virtual void PollSensors()
        {
            foreach (ISensor sensor in _sensors)
            {
                if (sensor.IsTriggered)
                {
                    Console.WriteLine("A " + sensor.GetSensorType() + " sensor was triggered at " + sensor.GetLocation());
                }
                else
                {
                    Console.WriteLine("Polled " + sensor.GetSensorType() + " at " + sensor.GetLocation() + " successfully");
                }
            }
        }
    }
}
