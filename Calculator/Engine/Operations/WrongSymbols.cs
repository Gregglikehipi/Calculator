using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Engine.Operations
{
    internal class WrongSymbols : IOperation
    {
        readonly string GoodSymbols = "1234567890(),*-+^/ ";

        public WrongSymbols(string symbols)
        {
            GoodSymbols = symbols;
        }
        public WrongSymbols() { }

        public List<string> Apply(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (GoodSymbols.IndexOf(list[i].ToString()) == -1)
                {
                    throw new InvalidOperationException("Eсть некоректные символы");
                }
            }
            return list;
        }
    }
}
