using Calc;
using CalcWebAPI.Model;
using Logging;
using Microsoft.Extensions.Configuration;

namespace CalcWebAPI.Business
{
    public class CalcBus
    {
        private ILogSingleton Logger;

        public string Calculation(CalcModel model, ILogSingleton logger)
        {
            Logger = logger;
            Calculator calc = new Calculator(logger);
            return calc.Calculation(model.Number1, model.Number2, model.Operator);
        }
    }
}
