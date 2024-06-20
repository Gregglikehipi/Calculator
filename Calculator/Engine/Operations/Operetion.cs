using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Engine.Operations
{
    internal interface IOperation
    {
        List<string> Apply(List<string> list);
    }
}
