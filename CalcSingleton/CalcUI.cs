using Calc;
using Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleCalc
{
    public class CalcUI
    {
        private readonly ILogSingleton logger; 

        
        Calculator calc = new Calculator(logger);
        



        public void Start()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Zadaj cislo");
                string num1;
                num1 = calc.GetNumber(Convert.ToString(Console.ReadLine()));
                if (!Regex.IsMatch(num1.ToString(), @"^\d+$"))
                {
                    Console.WriteLine("Zly vstup");
                    Console.WriteLine("Kalkulacia sa resetuje");
                    Console.WriteLine();

                    continue;
                }

                Console.WriteLine("Zadaj operaciu");
                string opp = calc.GetOpperation(Convert.ToString(Console.ReadLine()));
                if (Regex.IsMatch(opp, "\\+\\-\\*\\/"))
                {
                    Console.WriteLine("Zly vstup");
                    Console.WriteLine("Kalkulacia sa resetuje");
                    Console.WriteLine();

                    continue;
                }

                Console.WriteLine("Zadaj cislo");
                string num2;
                num2 = calc.GetNumber(Convert.ToString(Console.ReadLine()));
                if (!Regex.IsMatch(num1.ToString(), @"^\d+$"))
                {
                    Console.WriteLine("Zly vstup");
                    Console.WriteLine("Kalkulacia sa resetuje");
                    Console.WriteLine();

                    continue;
                }

                Console.WriteLine(calc.Calculation(Convert.ToDouble(num1), Convert.ToDouble(num2), opp));

                Console.WriteLine("Pre pokracovanie stlac ENTER, Pre ukoncenie stlac x");

                string znak = Convert.ToString(Console.ReadLine());
                if (znak.ToLower().Equals("x"))
                {

                    exit = true;
                    break;
                }



            }







        }
    }
}
