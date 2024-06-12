using System;

namespace Calculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> decomposedString = Decompose.DecomposeString("11+5*5");
            
            foreach (String str in decomposedString)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("Hello World!");

        }
    }
}
