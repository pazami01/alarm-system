using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AlarmSystem.Tests
{
    [TestClass]
    public class ControlUnitTest
    {
        [TestMethod]
        public void Test_New_ControlUnit_With_Null_Sensors_Throws_ArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new ControlUnit(null));
        }

        [TestMethod]
        public void Test_New_ControlUnit_With_Sensor_List_Containing_Null_Throws_ArgumentNullException()
        {
            var sensors = new List<ISensor>() { null };

            Assert.ThrowsException<ArgumentNullException>(() => new ControlUnit(sensors));
        }
    }
}
