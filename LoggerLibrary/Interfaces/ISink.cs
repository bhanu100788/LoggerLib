using LoggerLibrary.Common;

namespace LoggerLibrary.Interfaces
{
   public interface ISink
    {
        void Log(LogMessage message);
    }
}
