using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlarmSystem.Tests
{
    [TestClass]
    public class HeatSensorTest
    {
        [TestMethod]
        public void Test_New_Sensor_With_Null_Location_Throws_ArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new HeatSensor(null));
        }

        [TestMethod]
        public void Test_New_Sensor_With_NonNull_Location()
        {
            Assert.AreEqual("Location1", new HeatSensor("Location1").GetLocation());
        }

        [TestMethod]
        public void Test_New_Sensor_With_No_Location()
        {
            Assert.AreEqual("Unknown Location", new HeatSensor().GetLocation());
        }

        [TestMethod]
        public void Test_GetSensorType_Returns_HeatSensor()
        {
            Assert.AreEqual("HeatSensor", new HeatSensor().GetSensorType());
        }
    }
}
