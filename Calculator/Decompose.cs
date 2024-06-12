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
        private static String NUM = "1234567890";
        private static String SYM = "*-+/()";
        private static String BRC = "()";
        internal static List<String> DecomposeString(String arg)
        {
            List<String> decomposedString = new List<String>();
            String past = "";
            if (arg.Length == 0)
            {
                return new List<String>() {"0"};
            }
            if (SYM.IndexOf(arg[0].ToString()) != -1)
                return Exceptions.Call("Symbol on first pos");
            else 
                past = arg[0].ToString();

            for (int i = 1; i < arg.Length; i++)
            {
                if (BRC.IndexOf(arg[i].ToString()) != -1)
                { 

                }
                if (SYM.IndexOf(arg[i].ToString()) != -1)
                {
                    if (past[past.Length - 1].Equals('*'))
                    {
                        if (past.Length == 1)
                            past += arg[i];
                        else
                            return Exceptions.Call("Too many symbols");
                        continue;
                    }
                    if (NUM.IndexOf(past[past.Length - 1].ToString()) != -1)
                    {
                        decomposedString.Add(past);
                        past = arg[i].ToString();
                    }
                    else
                        return Exceptions.Call("Too many different symbols");
                }
                else
                {
                    if (SYM.IndexOf(past[past.Length - 1].ToString()) != -1)
                    {
                        decomposedString.Add(past);
                        past = "";
                    }
                    past += arg[i];
                }
            }
            if (NUM.IndexOf(past[past.Length - 1].ToString()) != -1)
                decomposedString.Add(past);
            else
                return Exceptions.Call("Symbol on last pos");
            return decomposedString;
        }
    }
}
