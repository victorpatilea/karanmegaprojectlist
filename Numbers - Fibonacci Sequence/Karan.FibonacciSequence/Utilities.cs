using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karan.FibonacciSequence
{
    public static class Utilities
    {
        public static string GetFibonacciSequence(int n)
        {
            if(n < 0 || n > 1000)
            {
                throw new ArgumentException("Must be between 0 and 100", nameof(n));
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("0 1 ");
            int previous = 0;
            int current = 1;
            int toWrite = 0;
            while(previous + current <= n)
            { 
                toWrite = previous + current;
                sb.Append(toWrite.ToString() + " ");
                previous = current;
                current = toWrite;
            }

            return sb.ToString();
        }
    }
}
