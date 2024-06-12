using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Сalculation
    {
        internal static List<String> List(List<String> list)
        {
            double calc;
            for (int i = 0; i < list.Count; i++)
            {
                switch (list[i])
                {
                    case "**":
                        calc = Math.Pow(double.Parse(list[i - 1]), double.Parse(list[i + 1]));
                        list.RemoveRange(i - 1, 3);
                        list.Insert(i - 1, Math.Round(calc, 2).ToString());
                        break;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                switch (list[i])
                {
                    case "*":
                        calc = double.Parse(list[i - 1]) * double.Parse(list[i + 1]);
                        list.RemoveRange(i - 1, 3);
                        list.Insert(i - 1, Math.Round(calc, 2).ToString());
                        break;
                    case "/":
                        if (double.Parse(list[i + 1]) < 0.00001)
                        {
                            return Exceptions.Call("Divide by 0");
                        }
                        calc = double.Parse(list[i - 1]) / double.Parse(list[i + 1]);
                        list.RemoveRange(i - 1, 3);
                        list.Insert(i - 1, Math.Round(calc, 2).ToString());
                        break;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                switch (list[i])
                {
                    case "-":
                        calc = double.Parse(list[i - 1]) - double.Parse(list[i + 1]);
                        list.RemoveRange(i - 1, 3);
                        list.Insert(i - 1, Math.Round(calc, 2).ToString());
                        break;
                    case "+":
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
