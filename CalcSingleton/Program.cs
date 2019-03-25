using System;
using System.IO;
using System.Configuration;
using Calc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Logging;

namespace ConsoleCalc
{
    class Program
    {
        private static readonly ILogSingleton log;
        public readonly int iro;
        //private readonly ILogSingleton _log;
        //public Program(ILogSingleton log)
        //{
        //    _log = log;
        //}
        static void Main(string[] args)
        {

            //readonly int iro1;
            //Calculator calc = new Calculator();


            //Console.WriteLine("Zadaj cislo");
            //double num1;
            //num1 = calc.GetNumber(Convert.ToString(Console.ReadLine()));

            //Console.WriteLine("Zadaj operaciu");
            //string opp = calc.GetOpperation(Convert.ToString(Console.ReadLine()));

            //Console.WriteLine("Zadaj cislo");
            //double num2 = calc.GetNumber(Convert.ToString(Console.ReadLine()));

            //Console.WriteLine(calc.Calculation(num1, num2, opp));

            CalcUI calcUI = new CalcUI();
            calcUI.Start();

           
            Console.Read();
        }
    }
}
