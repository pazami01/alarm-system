using System;
using System.Collections.Generic;
using System.Text;

namespace AlarmSystem
{
    public abstract class SecuritySensor : ISecuritySensor
    {
        protected string _location;

        public abstract bool IsTriggered { get; set; }

        public SecuritySensor(string location)
        {
            _location = location ?? throw new ArgumentNullException("Location must not be null.");
        }

        public string GetLocation()
        {
            return _location;
        }

        public abstract string GetSensorType();
    }
}
