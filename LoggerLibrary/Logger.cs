using LoggerLibrary.Common;
using LoggerLibrary.Configuration;
using LoggerLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLibrary
{
    public class Logger
    {
        private readonly LoggerConfiguration _config;

        public Logger(LoggerConfiguration config)
        {
            _config = config;
        }

        public void Log(string content, LogLevel level, string ns)
        {
            var message = new LogMessage(content, level, ns);
            var sinks = _config.GetSinks(level);

            foreach (var sink in sinks)
            {
                sink.Log(message);
            }
        }
    }
    }
