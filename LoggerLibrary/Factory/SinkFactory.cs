using LoggerLibrary.Implementation;
using LoggerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLibrary.Factory
{
    public static class SinkFactory
    {
        public static ISink CreateSink(string sinkType, string parameter = null)
        {
            switch (sinkType.ToLower())
            {
                case "console":
                    return new ConsoleSink();
                case "file":
                    return new FileSink(parameter);
                // Add other cases for additional sink types, like database
                default:
                    throw new ArgumentException($"Unknown sink type: {sinkType}");
            }
        }
    }
}
