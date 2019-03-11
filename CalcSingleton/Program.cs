using System;
using Calc;

namespace ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator number1 = new Calculator();
            Console.Write(number1.GetNumber());

           
            Console.Write(number1.GetOpperation());

           
            Console.Write(number1.GetNumber());

           
            //Console.Write(res.Calculation(number1.GetNumber(), number2.GetNumber(), opp.GetOpperation()));

            Console.Read();
        }
    }
}
