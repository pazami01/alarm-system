using System;
namespace AlarmSystem
{
    public class SmokeSensor : HazardSensor
    {
        private const double _BatteryDrainPercent = 0.2;
        private const double _RaiseAlarmProb = 0.1;
        private const string _Type = "SmokeSensor";

        private bool _isTriggered;
        private Random _random;

        public override bool IsTriggered
        {
            get
            {
                ReduceBattery();

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

        private void ReduceBattery()
        {
            double drainAmount = _batteryPercent * _BatteryDrainPercent;

            if (drainAmount <= _MinBattery) { throw new Exception("Sensor battery needs to be changed."); }

            _batteryPercent -= drainAmount;
        }

        public SmokeSensor(string location = "Unknown Location") : base(location)
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
