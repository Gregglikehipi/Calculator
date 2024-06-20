using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal static class Warden
    {
        internal static string Observe(string line)
        {
            line = line.Trim();
            List<string> newLine = new List<string>();
            foreach (char c in line)
            {
                newLine.Add(c.ToString());
            }
            string ans;
            try
            {
                ans = Сalculation.Calculate(newLine)[0];
            }
            catch(Exception ex)
            {
                ans = ex.Message;
            }
            return ans;
        }

    }
}
