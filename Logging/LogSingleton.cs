using System;
using System.IO;

namespace Logging
{
    public class LogSingleton : ILogSingleton
    {
        private static LogSingleton singleton;
        private static string filePath;

        private LogSingleton()
        {            
        }

        public static LogSingleton GetLog(string path)
        {
            if(singleton == null)
            {
                singleton = new LogSingleton();
                
            }
            filePath = path;
            return singleton;
        }

        public void Logging(string message)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {

                writer.Write(message);
            }
        }
       
        
    }
}
