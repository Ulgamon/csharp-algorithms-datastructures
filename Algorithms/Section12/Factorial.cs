using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Section12
{
    public static class Factorial
    {
        public static long FactorialFunction(int n)
        {
            if (n <= 0)
                throw new ArgumentOutOfRangeException();

            if (n == 1) return 1;
            return n * FactorialFunction(n - 1);
        }
    }
}
