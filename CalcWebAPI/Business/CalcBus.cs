using Calc;
using CalcWebAPI.Model;
using Logging;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CalcWebAPI.Business
{
    public class CalcBus
    {
        private static ILogSingleton logger;
        private static string FilePath()
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", true, true);

            var config = builder.Build();

            string path = config["filePath"];

            return path;

        }
        public string Calculation(CalcModel model)
        {
            logger = LogSingleton.GetLog(FilePath());
            Calculator calc = new Calculator(logger);
            return calc.Calculation(model.Num1, model.Num2, model.Operator);
        }
    }
}
