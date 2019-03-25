using Microsoft.Extensions.Configuration;
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

        public static LogSingleton GetLog(string path)
        {
            if(singleton == null)
            {
                singleton = new LogSingleton();
                
            }

            return singleton;
        }

        public void Logging(string message)
        {
            using (StreamWriter writer = new StreamWriter(FilePath(), true))
            {

                writer.Write(message);
            }
        }
       
        private static string FilePath()
        {
            var builder = new ConfigurationBuilder()
               //.SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", true, true);

            var config = builder.Build();

            string path = config["filePath"];

            return path;

        }
    }
}
