using Logging;
using System;
using System.Text.RegularExpressions;

namespace Calc
{
    public class Calculator : ICalculator
    {
        private readonly ILogSingleton _log;

        public Calculator(ILogSingleton log)
        {
            _log = log;
        }
        
        public string GetNumber(string number)
        {
            while(true)
            {
                if (Regex.IsMatch(number.ToString(), @"^\d+$"))
                {
                    _log.Logging(number);
                    return Convert.ToString(number);
                } else
                {
                _log.Logging(new InvalidOperationException("Znak nie je cislo").ToString() + Environment.NewLine);
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
                    _log.Logging(opp);
                    return opp;
                }
                else
                {
                    _log.Logging(new InvalidOperationException("Znak nie je cislo").ToString() + Environment.NewLine);
                    throw new InvalidOperationException("Zlá operácia");

                }
            }
        }


        public string Calculation(double number1, double number2, string opp)
        {
            switch (opp)
            {
                case "+":                  
                    double resPlus = number1 + number2;

                    _log.Logging(number1.ToString()+ "+" + number2.ToString() + "=" + resPlus.ToString() + Environment.NewLine);

                    return resPlus.ToString();           
                    
                case "-":
                    double resMin = number1 - number2;

                    _log.Logging(number1.ToString() + "-" + number2.ToString() + "=" + resMin.ToString() + Environment.NewLine);

                    return resMin.ToString();
                case "*":
                    double resKr = number1 * number2;

                    _log.Logging(number1.ToString() + "*" + number2.ToString() + "=" + resKr.ToString() + Environment.NewLine);
                    return resKr.ToString(); 
                case "/":
                    double resDel = number1 / number2;

                    _log.Logging(number1.ToString() + "/" + number2.ToString() + "=" + resDel.ToString() + Environment.NewLine);

                    return resDel.ToString(); 

                default: throw new InvalidOperationException("Zlá operácia");
            }
        }
        
    }
}
