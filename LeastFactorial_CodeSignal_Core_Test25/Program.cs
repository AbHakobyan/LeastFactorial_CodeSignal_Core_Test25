using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeastFactorial_CodeSignal_Core_Test25
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = leastFactorial(17);
            Console.WriteLine(n);
        }

        static int leastFactorial(int n)
        {
            int count = 1;
            for (int i = 1; i < n; i++)
            {
                if (count < n)
                {
                    count *= i;
                    continue;
                }
            }
            return count;
        }
    }
}
