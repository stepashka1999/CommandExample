using System;
using SmartHome.Appllication;

namespace SmartHome.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var smartHome = new SmartHome.Appllication.SmartHome("Jeff");
            Console.WriteLine("Press any key to start ur smar home:");
            Console.ReadKey(true);
            smartHome.Start(Console.Out, Console.In);
        }
    }
}
