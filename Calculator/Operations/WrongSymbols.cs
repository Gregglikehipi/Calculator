using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    internal class WrongSymbols : IOperation
    {
        readonly string GoodSymbols = "1234567890(),*-+^ ";

        public WrongSymbols(String symbols) 
        {
            this.GoodSymbols = symbols;
        }
        public WrongSymbols() { }

        public List<String> Apply(List<String> list)
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
