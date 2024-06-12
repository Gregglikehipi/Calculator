using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{

    internal class Decompose
    {
        internal static List<String> DecomposeString(String arg)
        {
            List<String> decomposedString = new List<String>();
            String past = "";
            if (arg.Length == 0)
            {
                return new List<String>() {"0"};
            }
            if ("*-+/".IndexOf(arg[0].ToString()) != -1)
            {
                Console.WriteLine("MATH GO WRONG1");
                return new List<String>() { "0" };
            }
            else 
                past = arg[0].ToString();

            for (int i = 1; i < arg.Length; i++)
            {
                if ("*-+/".IndexOf(arg[i].ToString()) != -1)
                {
                    if (past[past.Length - 1].Equals('*'))
                    {
                        if (past.Length == 1)
                            past += arg[i];
                        else
                        {
                            Console.WriteLine("MATH GO WRONG2");
                            return new List<String>() { "0" };
                        }
                        continue;
                    }
                    if ("1234567890".IndexOf(past[past.Length - 1].ToString()) != -1)
                    {
                        decomposedString.Add(past);
                        past = arg[i].ToString();
                    }
                    else
                    {
                        Console.WriteLine("MATH GO WRONG3");
                        return new List<String>() { "0" };
                    }
                }
                else
                {
                    if ("*-+/".IndexOf(past[past.Length - 1].ToString()) != -1)
                    {
                        decomposedString.Add(past);
                        past = "";
                    }
                    past += arg[i];
                }
            }
            if ("1234567890".IndexOf(past[past.Length - 1].ToString()) != -1)
                decomposedString.Add(past);
            else
            {
                Console.WriteLine("MATH GO WRONG4");
                return new List<String>() { "0" };
            }
            return decomposedString;
        }
    }
}
