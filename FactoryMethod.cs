using System; 

namespace DesignPatterns{
    interface ILogger{
        void Log(); 
    }
    interface ILoggerFactory{
        ILogger GenerateLogger(); 
    }
    class ConsoleLogger : ILogger
    {
        public void Log() => "logged to console".Print(); 
    }
    class DbLogger : ILogger{
        public void Log() => "logged to database".Print(); 
    }
    class ConsoleLoggerFactory : ILoggerFactory{
        public ILogger GenerateLogger() => new ConsoleLogger(); 
    }
    class DbLoggerFactory : ILoggerFactory{
        public ILogger GenerateLogger() => new DbLogger(); 
    }
}