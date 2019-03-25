using Autofac;
using Calc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ConsoleCalc
{
    public static class ContainerConfig
    {
        public static IContainer Confugure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Calculator>().As<ICalculator>();

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(Logging))).As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }
    }
}
