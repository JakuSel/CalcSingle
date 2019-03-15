using System;
using System.Collections.Generic;
using System.Text;

namespace Logging
{
    public interface ILogSingleton
    {
        void Logging(string message);
        void ResLog(double resOpp);
        void ExceptionLog();

    }

    //public abstract class absClass : ILogSingleton
    //{
    //    public void Logging(string message)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
