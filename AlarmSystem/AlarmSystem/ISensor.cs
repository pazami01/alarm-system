using System;
using System.Collections.Generic;
using System.Text;

namespace AlarmSystem
{
    public interface ISensor
    {
        bool IsTriggered { get; set; }
        string GetLocation();
        string GetSensorType();
    }
}
