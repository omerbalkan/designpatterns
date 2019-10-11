using System;

namespace DesignPatterns{
    class NetLoggerService{
        public void Log() => "logged to net via a netlogger service".Print(); 
    }
    class NetLoggerServiceAdapter : ILogger {
        private readonly NetLoggerService netLogger = new NetLoggerService(); 
        
        public void Log() => netLogger.Log(); 
    }
}