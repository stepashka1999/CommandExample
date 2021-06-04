using System;
using System.Globalization;
using System.IO;
using SmartHome.Data.Models;

namespace SmartHome.Data.Interfaces
{
    public interface ICommand
    {
        public string Command { get; }
        public string Description { get; }

        public void Excecute(string message, TextWriter writer);

        public bool Contains(string message)
        {
            return message.Contains(Command);
        }
    }
}