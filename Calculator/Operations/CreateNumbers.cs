using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    internal class CreateNumbers : IOperation
    {
        readonly string numbers = "1234567890";
        readonly string stopPoint = ",";
        readonly string all = "1234567890,";

        public CreateNumbers() { }
        public List<String> Apply(List<String> list)
        {
            bool flag = false;
            string num = "";
            for (int i = 0; i < list.Count; i++)
            {
                if (all.IndexOf(list[i].ToString()) != -1)
                {
                    if (stopPoint.IndexOf(list[i].ToString()) != -1)
                        throw new InvalidOperationException("Неправильное число");
                    num += list[i];
                    for (int j = i + 1;  j < list.Count; j++)
                    {
                        if (all.IndexOf(list[j].ToString()) != -1)
                        {
                            if (stopPoint.IndexOf(list[j].ToString()) != -1)
                            {
                                if (flag)
                                    throw new InvalidOperationException("Неправильное число");
                                flag = true;
                                num += list[j];
                            }
                            if (numbers.IndexOf(list[j].ToString()) != -1)
                                num += list[j];
                        }
                        else
                        {
                            list.RemoveRange(i, j - i);
                            list.Insert(i, num);
                            num = "";
                            break;
                        }
                    }
                    if (num.Length != 0)
                        list.Insert(i, num);
                    break;
                }
            }
            return list;
        }
    }
}
