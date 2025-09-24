using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Section6
{
    public static class ReverseString
    {
        // create a function that reverses a string:
        // "Hi my name is Justin" should be:
        // "nitsuJ si eman ym iH"
        // Time complexity is O(n) and space complexity is O(1) because we use
        // reference to an object and it works in place so it could be void type
        // and still change the value
        // I used StringBuilder class to create string because the string type itself is immutable

        public static StringBuilder StringReverse(StringBuilder input)
        {
            int start = 0;
            int end = input.Length - 1;

            char temp;

            while (start < end)
            {
                temp = input[start];
                input[start] = input[end];
                input[end] = temp;
                start++;
                end--;
            }
            return input;
        }
    }
}
