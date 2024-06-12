using System;

namespace Calculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 2)
                {
                    i = 5;
                    continue;
                }

                Console.WriteLine(i);
            }

            List<String> decomposedString = Decompose.DecomposeString("11+5**2");
            
            foreach (String str in decomposedString)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine(Сalculation.ListCalculation(decomposedString)[0]);
            Console.WriteLine("Hello World!");

        }
    }
}
