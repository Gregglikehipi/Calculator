using System;
using System.Runtime.CompilerServices;
using Calculator.Menu;


[assembly: InternalsVisibleTo("CalculatorTests")]
namespace Calculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleMenu.Screen();
        }
    }
}
