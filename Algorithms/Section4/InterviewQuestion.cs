using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Algorithms.Exercises
{
    public class InterviewQuestion
    {
        // Given 2 arrays, create a function that let's user know (true/false) whether these two arrays contain any
        // common items
        // for example:
        // const array1 = ['a', 'b', 'c', 'x'];
        // const array2 = ['z', 'y', 'i'];
        // should return false.
        // --------------
        // const array1 = ['a', 'b', 'c', 'x'];
        // const array2 = ['z', 'y', 'x'];
        // should return true.


        // I created this funtion to have O(n) time and space complexity so it is scaling pretty well
        public static bool FindCommonItem(char[] array1, char[] array2)
        {
            // If length of first or second array is empty
            if (array1.Length == 0 || array2.Length == 0) return false;

            // Create a dictionary and add all values from array1 as keys
            HashSet<char> set = new HashSet<char>();
            for (int i = 0; i < array1.Length; i++)
            {
                set.Add(array1[i]);
            }

            // Loop through array2 and check if elements from array2
            // exists as keys in dictionary and on first one exit with returning true
            for (int y = 0; y < array2.Length; y++)
            {
                if (set.Contains(array2[y]))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool FindCommonItemBuiltInMethods(char[] array1, char[] array2)
        {
            return array1.Any(element => array2.Contains(element));
        }

    }
}
