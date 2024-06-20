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
            while (true)
            {
                string s = Console.ReadLine();
                Console.WriteLine(Warden.Observe(s));
            }
        }
    }
}
