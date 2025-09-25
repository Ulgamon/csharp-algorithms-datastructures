using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Section7
{
    public class FirstRecurringCharacter
    {
        // Google Question
        // Given an array = [2,5,1,2,3,5,1,2,4]
        // It should return 2

        // Given an array = [2,1,1,2,3,5,1,2,4]
        // It should return 1

        // Given an array = [2,3,4,5]
        // It should return null

        // O(n) is desired time complexity
        // O(n^2) Algorithm with nested for loops
        public static int? FirstRecurringCharacterMethod(int[] array)
        {
            // Two variables that will check for recurrence and distance between two recurrences
            // The idea is that on first recurrence I will take it as a result
            // and then use it as a boundary and only check for recurrences between
            // those index boundaries which if exist will gice me recurrence
            // with smaller distance which is automatically the first recurrence
            int? result = null;
            int lastIndex = array.Length;

            for (int i = 0; i < lastIndex; i++)
            {
                for (int j = i + 1; j < lastIndex; j++)
                {
                    if (array[i] == array[j])
                    {
                        result = array[i];
                        lastIndex = j;
                    }
                }
            }

            return result;
        }
    }
}
