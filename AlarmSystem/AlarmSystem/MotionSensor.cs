using System;
using System.Collections.Generic;
using System.Text;

namespace AlarmSystem
{
    public class MotionSensor : SecuritySensor
    {
        private const double _RaiseAlarmProb = 0.3;
        private const string _Type = "MotionSensor";

        private bool _isTriggered;
        private Random _random;

        public override bool IsTriggered
        {
            get
            {
                if (_isTriggered == true)
                {
                    IsTriggered = false;
                }

                RaiseAlarm();

                return _isTriggered;
            }
            set
            {
                _isTriggered = value;
            }
        }

        private void RaiseAlarm()
        {
            if (_random.NextDouble() <= _RaiseAlarmProb)
            {
                IsTriggered = true;
            }
        }

        public MotionSensor(string location = "Unknown Location") : base(location)
        {
            _random = new Random();
            IsTriggered = false;
        }

        public override string GetSensorType()
        {
            return _Type;
        }
    }
}
