using System;
using System.IO;
using Microsoft.Extensions.Logging;

namespace NavyPqs.Logger
{
    public class LocalFileLogger : ILogger
    {
        public IDisposable BeginScope<TState>(TState state)
        {
            throw new NotImplementedException();
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            throw new NotImplementedException();
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, 
            Func<TState, Exception, string> formatter)
        {
            using StreamWriter sw = File.AppendText(@"C:\Users\LindsaySpencer\OneDrive - Logistyx Technologies LLC\Desktop\Navy App Stuff\NavyLog.txt");
            sw.WriteLine($"{logLevel}: {eventId} - {exception.Message}");
        }
    }
}
