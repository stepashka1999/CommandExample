using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using SmartHome.Appllication.Interfaces;
using SmartHome.Data.Commands;
using SmartHome.Data.Interfaces;

namespace SmartHome.Appllication.Models
{
    public class CommandExcecutor : ICommandExcecutor
    {
        private HelpCommand _helpCommand;
        private IList<ICommand> _commands = new List<ICommand>()
        {
            new WeatherCommand(),
            new RepeatCommand(),
            new TimeCommand()
        };

        public CommandExcecutor()
        {
            _helpCommand = new();
            _commands.Add(_helpCommand);
            UpdateCommandDescriptions();
        }

        public void ExcecuteCommand(string message, TextWriter writer)
        {
            foreach(var command in _commands)
            {
                if(command.Contains(message))
                    command.Excecute(message, writer);
            }
        }

        private void UpdateCommandDescriptions()
        {
            foreach(var command in _commands)
            {
                var commandKey = command.Command.Substring(1); //Gettinng command strign without "/"
                if (!_helpCommand.CommandDescriptions.TryAdd(commandKey, command.Description))
                    _helpCommand.CommandDescriptions[commandKey] = command.Description;
            }
        }
    
    
    }
}