using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    internal interface IOperation
    {
        List<String> Apply(List<String> list);
    }
}
