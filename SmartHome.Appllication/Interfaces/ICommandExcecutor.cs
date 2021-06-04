using System.Collections;
using System.IO;
using Microsoft.VisualBasic;
using SmartHome.Data.Interfaces;

namespace SmartHome.Appllication.Interfaces
{
    public interface ICommandExcecutor
    {
        void ExcecuteCommand(string message, TextWriter writer);
    }
}