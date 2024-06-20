using Calculator.Engine.Operations;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Engine
{
    internal static class Сalculation
    {
        // Настройка очередности операций
        static List<IOperation> orderList = new List<IOperation>()
        {
            new WrongSymbols(),
            new Brackets(),
            new CreateNumbers(),
            new CreateNegativeNumber(),
            new Exponentiation(),
            new DivideMultiply(),
            new PlusMinus()
        };
        internal static List<string> Calculate(List<string> list)
        {
            foreach (var operation in orderList)
                list = operation.Apply(list);
            return list;
        }
    }
}
