using System.IO;

namespace SmartHome.Appllication.Interfaces
{
    public interface ISmartHome
    {
         public string OwnerName { get; }
         public bool IsRunning { get; }

         void Start(TextWriter writer, TextReader reader);
         void Stop();
    }
}