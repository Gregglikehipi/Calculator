using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Menu
    {
        public static void Screen()
        {
            String hi;
            for (int i = 0; i < 10; i++)
            {
                hi = Console.ReadLine();
                List<String> decomposedString = Decompose.DecomposeString(hi);

                foreach (String str in decomposedString)
                {
                    Console.WriteLine(str);
                }
                Console.WriteLine(Сalculation.List(decomposedString)[0]);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
