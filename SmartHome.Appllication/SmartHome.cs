using System;
using System.IO;
using SmartHome.Appllication.Interfaces;
using SmartHome.Appllication.Models;

namespace SmartHome.Appllication
{
    public class SmartHome : ISmartHome
    {
        public string OwnerName { get; }
        private CommandExcecutor _excecutor;

        private bool _isRunning;
        public bool IsRunning => _isRunning;

        public SmartHome(string ownerName)
        {
            OwnerName = ownerName;
            _excecutor = new CommandExcecutor();
        }

        public void Start(TextWriter writer, TextReader reader)
        {
            _isRunning = true;
            writer.WriteLine("Ur Smart home is alive now 0_0");
            StartListen(writer, reader);
        }

        public void Stop()
        {
            _isRunning = false;
        }

        private void StartListen(TextWriter writer, TextReader reader)
        {
            while(IsRunning)
            {
                writer.WriteLine("\nWrite a command: ");
                var message = reader.ReadLine();
                Console.WriteLine();

                if(message == "/stop")
                {
                    Stop();
                    writer.WriteLine("Smart home is dead x_x");
                    break;
                }

                try
                {
                    _excecutor.ExcecuteCommand(message, writer);
                }
                catch(Exception e)
                {
                    writer.WriteLine($"Exception: {e.Message}\n");
                }
            }
        }
    }
}