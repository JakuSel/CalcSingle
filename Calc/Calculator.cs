using Logging;
using System;

namespace Calc
{
    public class Calculator
    {

        //private readonly ILogSingleton _log;
        //public Calculator()
        //{
        //    _log = LogSingleton.GetLog();
        //}
        public double GetNumber()
        {
            Console.WriteLine("Zadaj číslo: ");
            double number = Convert.ToDouble(Console.ReadLine());
            //_log.Logging(number.ToString());
            LogSingleton.GetLog(number.ToString());
            return number;            
        }

        public string GetOpperation()
        {
            while (true)
            {
                Console.WriteLine("Operacia: ");
                string opp = Console.ReadLine();
                Console.Clear();

                if((opp =="+") || (opp == "-") || (opp == "*") || (opp == "/"))
                {
                    //_log.Logging(opp.ToString());
                    LogSingleton.GetLog(opp.ToString());

                    return opp;
                }
                Console.WriteLine("Zlá operácia");
            }
        }

        public double Calculation(double number1, double number2, string opp)
        {
            switch (opp)
            {
                case "+":                  
                    double resPlus = number1 + number2;
                    //_log.Logging(resPlus.ToString());
                    LogSingleton.GetLog(resPlus.ToString());

                    return resPlus;           
                    
                case "-":
                    double resMin = number1 - number2;
                    //_log.Logging(resMin.ToString());
                    LogSingleton.GetLog(resMin.ToString());

                    return resMin;
                case "*":
                    double resKr = number1 * number2;
                    //_log.Logging(resKr.ToString());
                    LogSingleton.GetLog(resKr.ToString());

                    return resKr;
                case "/":
                    double resDel = number1 / number2;
                    //_log.Logging(resDel.ToString());
                    LogSingleton.GetLog(resDel.ToString());

                    return resDel;
                default: throw new InvalidOperationException("Zlá operácia");
            }
        }
    }
}
