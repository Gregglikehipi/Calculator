using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    internal class DivideMultiply : IOperation
    {
        public DivideMultiply() { }
        public List<String> Apply(List<String> list)
        {
            double calc;
            double blank;
            for (int i = 0; i < list.Count; i++)
            {
                switch (list[i])
                {
                    case "*":
                        if (i == 0 || i == list.Count - 1 || !double.TryParse(list[i - 1], out blank) || !double.TryParse(list[i + 1], out blank))
                            throw new InvalidOperationException("Невозможно возвести в ст");
                        calc = double.Parse(list[i - 1]) * double.Parse(list[i + 1]);
                        list.RemoveRange(i - 1, 3);
                        list.Insert(i - 1, Math.Round(calc, 2).ToString());
                        break;
                    case "/":
                        if (i == 0 || i == list.Count - 1 || !double.TryParse(list[i - 1], out blank) || !double.TryParse(list[i + 1], out blank))
                            throw new InvalidOperationException("Невозможно возвести в степень");
                        if (double.Parse(list[i + 1]) < 0.00000001)
                            throw new InvalidOperationException("Невозможно делить на ноль");
                        calc = double.Parse(list[i - 1]) / double.Parse(list[i + 1]);
                        list.RemoveRange(i - 1, 3);
                        list.Insert(i - 1, Math.Round(calc, 2).ToString());
                        break;
                }
            }
            return list;
        }
    }
}
