namespace Calc
{
    public interface ICalculator
    {
        string Calculation(double number1, double number2, string opp);
        string GetNumber(string number);
        string GetOpperation(string opp);
    }
}