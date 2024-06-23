using LoggerLibrary;
using LoggerLibrary.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace LoggerTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private LoggerConfiguration loggerConfiguration;
        private Logger _Logger;
        public WeatherForecastController()
        {
            loggerConfiguration = new LoggerConfiguration();
            loggerConfiguration.AddSink(LoggerLibrary.Enums.LogLevel.INFO, "console");
            loggerConfiguration.AddSink(LoggerLibrary.Enums.LogLevel.ERROR, "file", "errors.log");
            _Logger = new Logger(loggerConfiguration);
        }
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            _Logger.Log("This is an info message", LoggerLibrary.Enums.LogLevel.INFO, "MyApp.Namespace");
            _Logger.Log("This is an error message", LoggerLibrary.Enums.LogLevel.ERROR, "MyApp.Namespace");
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
