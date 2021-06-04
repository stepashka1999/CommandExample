using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.IO;
using System.Text;
using SmartHome.Data.Interfaces;

namespace SmartHome.Data.Commands
{
    public class HelpCommand : ICommand
    {
        public IDictionary<string, string> CommandDescriptions = new Dictionary<string, string>();
        public string Command => "/help";

        public string Description => $"Command: {Command}\n"
                                    + "Returns info about concrete command or about all commands\n"
                                    + "Pattern: /help <command?>\n"
                                    + "Samples: /help time => returns info only about \"time\"\n"
                                    + "/help => returns info about all coomand";

        public void Excecute(string message, TextWriter writer)
        {
            var parameters = message.Split(' ');

            switch(parameters.Length)
            {
                case 1:
                {
                    var descriptions = string.Join($"\n{new string('=', 10)}\n", CommandDescriptions.Values);
                    writer.WriteLine("\nAll Commands:\n" + descriptions);
                    break;
                }
                case 2:
                {
                    var key = parameters[1];
                    writer.WriteLine(CommandDescriptions[key]);
                    break;
                }
                default:
                    throw new ArgumentException("Count of commands can be only 0 or 1");
            }
        }
    }
}