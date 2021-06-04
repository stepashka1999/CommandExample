using System;
using System.IO;
using SmartHome.Data.Interfaces;

namespace SmartHome.Data.Commands
{
    public class TimeCommand : ICommand
    {
        public string Command => "/time";
        public string Description => $"Command: {Command}\n"
                                    + "Returns current time\n"
                                    + "Samples: /time";

        public void Excecute(string message, TextWriter writer)
        {
            if (message.Split(' ').Length > 1)
                throw new ArgumentException("Count of parameters can be only 0");
            
            writer.WriteLine(DateTime.Now.ToShortTimeString());
        }

    }
}