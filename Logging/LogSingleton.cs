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

        public static LogSingleton GetLog(/*string message*/)
        {
            if(singleton == null)
            {
                singleton = new LogSingleton();
                
            }
            //singleton.Logging(message);
            return singleton;
        }

        public void Logging(string message)
        {
            //Console.WriteLine(path);
            using (StreamWriter writer = new StreamWriter(FilePath(), true))
            {
                writer.Write(message);
            }
        }
        public void ResLog(double resOpp)
        {
            singleton.Logging("=" + resOpp.ToString() + Environment.NewLine);
            singleton.Logging(DateTime.Now.ToUniversalTime().ToString() + Environment.NewLine);
        }

        public void ExceptionLog()
        {
            singleton.Logging(new InvalidOperationException("Znak nie je cislo").ToString() + Environment.NewLine);
            singleton.Logging(DateTime.Now.ToLocalTime().ToString() + Environment.NewLine);

        }

        private string FilePath()
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
