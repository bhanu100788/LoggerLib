using LoggerLibrary.Enums;

namespace LoggerLibrary.Common
{
    public class LogMessage
    {
        public string Content { get; set; }
        public LogLevel Level { get; set; }
        public string Namespace { get; set; }

        public LogMessage(string content, LogLevel level, string ns)
        {
            Content = content;
            Level = level;
            Namespace = ns;
        }
    }
}
