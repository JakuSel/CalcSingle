using Logging;
using System;
using System.Text.RegularExpressions;

namespace Calc
{
    public class Calculator
    {
        private readonly ILogSingleton _log;

        public Calculator()
        {
            _log = LogSingleton.GetLog();
        }
        
        public double GetNumber(string number)
        {
            while(true)
            {
                if (Regex.IsMatch(number.ToString(), @"^\d+$"))
                {
                    _log.Logging(number);
                    //LogSingleton.GetLog(number);
                    return Convert.ToDouble(number);
                } else
                {
                    _log.ExceptionLog();
                    throw new InvalidOperationException("Zlá operácia");

                }

            }
        }

        public string GetOpperation(string opp)
        {
            while (true)
            {

                if ((opp == "+") || (opp == "-") || (opp == "*") || (opp == "/"))
                {
                    //LogSingleton.GetLog(opp.ToString());
                    _log.Logging(opp);
                    return opp;
                }
                else
                {
                    _log.ExceptionLog();
                    throw new InvalidOperationException("Zlá operácia");

                }
            }
        }

        public double Calculation(double number1, double number2, string opp)
        {
            switch (opp)
            {
                case "+":                  
                    double resPlus = number1 + number2;

                    _log.ResLog(resPlus);

                    return resPlus;           
                    
                case "-":
                    double resMin = number1 - number2;

                    _log.ResLog(resMin);

                    return resMin;
                case "*":
                    double resKr = number1 * number2;

                    _log.ResLog(resKr);

                    return resKr;
                case "/":
                    double resDel = number1 / number2;

                    _log.ResLog(resDel);

                    return resDel;

                default: throw new InvalidOperationException("Zlá operácia");
            }
        }
        
    }
}
