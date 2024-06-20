﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    internal class PlusMinus : IOperation
    {
        public PlusMinus() { }
        public List<String> Apply(List<String> list)
        {
            double blank;
            double calc;
            for (int i = 0; i < list.Count; i++)
            {
                switch (list[i])
                {
                    case "-":
                        if (i == 0 || i == list.Count - 1 || !double.TryParse(list[i - 1], out blank) || !double.TryParse(list[i + 1], out blank))
                            throw new InvalidOperationException("Невозможно вычесть");
                        calc = double.Parse(list[i - 1]) - double.Parse(list[i + 1]);
                        list.RemoveRange(i - 1, 3);
                        list.Insert(i - 1, Math.Round(calc, 2).ToString());
                        break;
                    case "+":
                        if (i == 0 || i == list.Count - 1 || !double.TryParse(list[i - 1], out blank) || !double.TryParse(list[i + 1], out blank))
                            throw new InvalidOperationException("Невозможно сложить");
                        calc = double.Parse(list[i - 1]) + double.Parse(list[i + 1]);
                        list.RemoveRange(i - 1, 3);
                        list.Insert(i - 1, Math.Round(calc, 2).ToString());
                        break;
                }
            }
            return list;
        }
    }
}
