using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    internal class Brackets : IOperation
    {
        private static String BRC = "()";

        public Brackets() { }

        public List<String> Apply(List<String> list) 
        {
            double blank;
            bool flag = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (BRC.IndexOf(list[i].ToString()) != -1)
                {
                    if (list[i].Equals(BRC[1]))
                        throw new InvalidOperationException("Проблемы со скобками");
                    if (i != 0 && double.TryParse(list[i - 1], out blank))
                        flag = true;
                    int count = 1;
                    int j = i + 1;
                    for (; j < list.Count; j++)
                    {
                        if (list[j].Equals("("))
                            count++;
                        if (list[j].Equals(")"))
                            count--;
                        if (count == 0)
                            break;
                        if (count == -1)
                            throw new InvalidOperationException("Проблемы со скобками");
                    }
                    if (j < list.Count && double.TryParse(list[j + 1], out blank))
                        throw new InvalidOperationException("Проблемы со скобками");
                    string num = Сalculation.Calculate(list.GetRange(i + 1, j - i - 1))[0];
                    list.RemoveRange(i, j - i + 1);
                    list.Insert(i, num);
                    if (flag)
                    {
                        list.Insert(i, "*");
                        i++;
                    }
                }
            }
            return list;
        }
    }
}
