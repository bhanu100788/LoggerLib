using LoggerLibrary.Common;
using LoggerLibrary.Interfaces;
using System.IO;

namespace LoggerLibrary.Implementation
{
    public class FileSink : ISink
    {
        private readonly string _filePath;

        public FileSink(string filePath)
        {
            _filePath = filePath;
        }

        public void Log(LogMessage message)
        {
            File.AppendAllText(_filePath, $"{message.Level}: {message.Namespace}: {message.Content}\n");
        }
    }

    // Additional sinks like DatabaseSink can be implemented similarly.

}
