using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Section12
{
    public static class Fibonacci
    {
        public static int FibonacciFunction(int n)
        {
            int current = 1;
            int prev = 0;
            int temp = 0;
            for (int i = 1; i < n; i++)
            {
                temp = current;
                current += prev;
                prev = temp;
            }

            return current;
        }

        public static int FibonacciRecursive(int n)
        {
            if (n < 2) return n ;


            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
    }
}
