using System;
using System.IO;

namespace Logging
{
    public class LogSingleton : ILogSingleton
    {
        private static LogSingleton singleton;

        private LogSingleton()
        {
        }

        public static LogSingleton GetLog(string message)
        {
            if(singleton == null)
            {
                singleton = new LogSingleton();
                
            }
            singleton.Logging(message);
            return singleton;
        }

        public void Logging(string message)
        {
            using(StreamWriter writer = new StreamWriter("log.txt", true))
            {
                writer.Write(message);
            }
        }
    }
}
