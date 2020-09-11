using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlarmSystem.Tests
{
    [TestClass]
    public class MotionSensorTest
    {
        [TestMethod]
        public void Test_New_Sensor_With_Null_Location_Throws_ArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new MotionSensor(null));
        }

        [TestMethod]
        public void Test_New_Sensor_With_NonNull_Location()
        {
            Assert.AreEqual("Location1", new MotionSensor("Location1").GetLocation());
        }

        [TestMethod]
        public void Test_New_Sensor_With_No_Location()
        {
            Assert.AreEqual("Unknown Location", new MotionSensor().GetLocation());
        }

        [TestMethod]
        public void Test_GetSensorType_Returns_MotionSensor()
        {
            Assert.AreEqual("MotionSensor", new MotionSensor().GetSensorType());
        }
    }
}
