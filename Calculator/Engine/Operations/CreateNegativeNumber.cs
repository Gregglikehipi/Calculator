using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Engine.Operations
{
    internal class CreateNegativeNumber : IOperation
    {
        public CreateNegativeNumber() { }
        public List<string> Apply(List<string> list)
        {
            double blank;
            double calc;
            if (list.Count > 1 && list[0].Equals("-") && double.TryParse(list[1], out blank))
            {
                calc = -1 * double.Parse(list[1]);
                list.RemoveRange(0, 2);
                list.Insert(0, Math.Round(calc, 2).ToString());
            }
            return list;
        }
    }
}
