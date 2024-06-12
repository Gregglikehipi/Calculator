using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Exceptions
    {
        public static List<String> Call(string problem) {
            Console.WriteLine("The problem is: \n" + problem);
            return new List<String>() { "0" };
        }
    }
}
