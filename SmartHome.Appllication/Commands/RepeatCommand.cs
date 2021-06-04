using System;
using System.IO;
using System.Linq;
using SmartHome.Data.Interfaces;

namespace SmartHome.Data.Commands
{
    public class RepeatCommand : ICommand
    {
        public string Command => "/repeat";

        public string Description => "Command: /repeat\n"
                                    + "Repeat message\n"
                                    + "Pattern: /repeat <message>\n"
                                    + "Sample: /repeat Repeat me!";

        public void Excecute(string message, TextWriter writer)
        {
            var splittedMessage = message.Split(' ');
            if(splittedMessage.Length == 1)
                throw new ArgumentException("Have no message to repeat");

            writer.WriteLine(string.Join(' ', splittedMessage.Skip(1)));
        }
    }
}