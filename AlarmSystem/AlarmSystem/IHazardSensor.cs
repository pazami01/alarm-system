using System;
using System.Collections.Generic;
using System.Text;

namespace AlarmSystem
{
    public interface IHazardSensor : ISensor
    {
        double GetBatteryPercentage();
    }
}
