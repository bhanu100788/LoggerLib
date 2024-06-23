using LoggerLibrary.Common;
using LoggerLibrary.Interfaces;
using System;

namespace LoggerLibrary.Implementation
{
    public class ConsoleSink : ISink
    {
        public void Log(LogMessage message)
        {
            Console.WriteLine($"{message.Level}: {message.Namespace}: {message.Content}");
        }
    }
}
