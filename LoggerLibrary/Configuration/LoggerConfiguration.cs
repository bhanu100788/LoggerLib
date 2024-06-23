using LoggerLibrary.Enums;
using LoggerLibrary.Factory;
using LoggerLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLibrary.Configuration
{
    public class LoggerConfiguration
    {
        private readonly Dictionary<LogLevel, List<ISink>> _levelToSinks;

        public LoggerConfiguration()
        {
            _levelToSinks = new Dictionary<LogLevel, List<ISink>>();
        }

        public void AddSink(LogLevel level, string sinkType, string parameter = null)
        {
            var sink = SinkFactory.CreateSink(sinkType, parameter);
            if (!_levelToSinks.ContainsKey(level))
            {
                _levelToSinks[level] = new List<ISink>();
            }
            _levelToSinks[level].Add(sink);
        }

        public List<ISink> GetSinks(LogLevel level)
        {
            return _levelToSinks.ContainsKey(level) ? _levelToSinks[level] : new List<ISink>();
        }
    }
}
