using Calculator.Operations;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal static class Сalculation
    {
        // Настройка очередности операций
        static List<IOperation> orderList = new List<IOperation>() 
        { 
            new WrongSymbols(),
            new CreateNumbers(),
            new CreateNegativeNumber(),
            new Exponentiation(),
            new DivideMultiply(),
            new PlusMinus()
        };
        internal static List<String> Calculate(List<String> list)
        {
            foreach (var operation in orderList) 
                list = operation.Apply(list);
            return list;
        }
    }
}
