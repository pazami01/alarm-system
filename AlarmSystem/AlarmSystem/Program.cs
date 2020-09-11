using System;
using System.Collections.Generic;

namespace AlarmSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<ISensor> sensors = new List<ISensor>();
            sensors.Add(new FireSensor("Room 1"));
            sensors.Add(new SmokeSensor("Room 2"));

            ControlUnit controlUnit = new ControlUnit(sensors);

            string input = string.Empty;
            while (!input.Equals("exit"))
            {
                Console.WriteLine("Type \"poll\" to poll all hazard sensors once or \"exit\" to exit");
                input = Console.ReadLine();
                if (input.Equals("poll"))
                {
                    controlUnit.PollSensors();
                }
            }

            List<ISensor> securitySensors = new List<ISensor>();
            securitySensors.Add(new MotionSensor("Room 3"));
            securitySensors.Add(new HeatSensor("Room 4"));

            var securityControlUnit = new SecurityControlUnit(securitySensors);

            string inputTwo = string.Empty;
            while (!inputTwo.Equals("exit"))
            {
                Console.WriteLine("Type \"poll\" to poll all security sensors once or \"exit\" to exit");
                inputTwo = Console.ReadLine();
                if (inputTwo.Equals("poll"))
                {
                    securityControlUnit.PollSensors();
                }
            }
        }
    }
}
