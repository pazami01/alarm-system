using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlarmSystem.Tests
{
    [TestClass]
    public class FireSensorTest
    {
        [TestMethod]
        public void Test_New_Sensor_With_Null_Location_Throws_ArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new FireSensor(null));
        }

        [TestMethod]
        public void Test_New_Sensor_With_NonNull_Location()
        {
            Assert.AreEqual("Location1", new FireSensor("Location1").GetLocation());
        }

        [TestMethod]
        public void Test_New_Sensor_With_No_Location()
        {
            Assert.AreEqual("Unknown Location", new FireSensor().GetLocation());
        }

        [TestMethod]
        public void Test_GetSensorType_Returns_FireSensor()
        {
            Assert.AreEqual("FireSensor", new FireSensor().GetSensorType());
        }

        [TestMethod]
        public void Test_New_Sensor_Battery_Is_One_Hundred()
        {
            Assert.AreEqual(100, new FireSensor().GetBatteryPercentage());
        }

        [TestMethod]
        public void Test_GetBatteryPercentage_After_First_Poll()
        {
            var sensor = new FireSensor();
            var poll = sensor.IsTriggered;

            Assert.AreEqual(90, sensor.GetBatteryPercentage());
        }

        [TestMethod]
        public void Test_GetBatteryPercentage_After_Two_Polls()
        {
            var sensor = new FireSensor();
            var poll = sensor.IsTriggered;
            poll = sensor.IsTriggered;

            Assert.AreEqual(81, sensor.GetBatteryPercentage());
        }
    }
}
