using System;
using System.IO;
using System.Configuration;
using Calc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace ConsoleCalc
{
    class Program
    {
        public readonly int iro;

        static void Main(string[] args)
        {


            //readonly int iro1;
            Calculator calc = new Calculator();


            Console.WriteLine("Zadaj cislo");
            double num1;
            num1 = calc.GetNumber(Convert.ToString(Console.ReadLine()));

            Console.WriteLine("Zadaj operaciu");
            string opp = calc.GetOpperation(Convert.ToString(Console.ReadLine()));

            Console.WriteLine("Zadaj cislo");
            double num2 = calc.GetNumber(Convert.ToString(Console.ReadLine()));

            Console.WriteLine(calc.Calculation(num1, num2, opp));

           
            Console.Read();
        }
    }
}
