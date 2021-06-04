using System;
using System.IO;
using SmartHome.Data.Interfaces;
using SmartHome.Data.Models;

namespace SmartHome.Data.Commands
{
    public class WeatherCommand : ICommand
    {
        public string Command => "/weather";

        public string Description => $"Command: {Command}\n"
                                    + "Returns info about concrete command or about all commands\n"
                                    + "Samples: /weather";

        public void Excecute(string message, TextWriter writer)
        {
            if (message.Split(' ').Length > 1)
                throw new ArgumentException("Count of parameters can be only 0");

            var rnd = new Random();

            var weather = new Weather()
            {
                CurrentTemp = rnd.Next(10, 20),
                MaxTemp = rnd.Next(20, 30),
                MinTemp = rnd.Next(10, 20)
            };

            writer.WriteLine(weather);
        }
    }
}