using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlarmSystem.Tests
{
    [TestClass]
    public class SmokeSensorTest
    {
        [TestMethod]
        public void Test_New_Sensor_With_Null_Location_Throws_ArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new SmokeSensor(null));
        }

        [TestMethod]
        public void Test_New_Sensor_With_NonNull_Location()
        {
            Assert.AreEqual("Location1", new SmokeSensor("Location1").GetLocation());
        }

        [TestMethod]
        public void Test_New_Sensor_With_No_Location()
        {
            Assert.AreEqual("Unknown Location", new SmokeSensor().GetLocation());
        }

        [TestMethod]
        public void Test_GetSensorType_Returns_SmokeSensor()
        {
            Assert.AreEqual("SmokeSensor", new SmokeSensor().GetSensorType());
        }

        [TestMethod]
        public void Test_New_Sensor_Battery_Is_One_Hundred()
        {
            Assert.AreEqual(100, new SmokeSensor().GetBatteryPercentage());
        }

        [TestMethod]
        public void Test_GetBatteryPercentage_After_First_Poll()
        {
            var sensor = new SmokeSensor();
            var poll = sensor.IsTriggered;

            Assert.AreEqual(80, sensor.GetBatteryPercentage());
        }

        [TestMethod]
        public void Test_GetBatteryPercentage_After_Two_Polls()
        {
            var sensor = new SmokeSensor();
            var poll = sensor.IsTriggered;
            poll = sensor.IsTriggered;

            Assert.AreEqual(64, sensor.GetBatteryPercentage());
        }
    }
}
