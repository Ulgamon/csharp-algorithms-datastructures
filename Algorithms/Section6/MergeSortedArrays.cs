using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Section6
{
    public class MergeSortedArrays
    {
        //int[] arr1 = [0, 3, 4, 31];
        //int[] arr2 = [4, 6, 30];
        // Whiile loop will exit on the first index that goes out of bounds
        // so what that means is that one array is finished and other is not
        // so I need to loop through that second array and append remaining elements.

        // Time complexity is O(a + b)

        public static int[] MergeSortedArraysMethod(int[] arr1, int[] arr2)
        {
            int[] mergedArray = new int[arr1.Length + arr2.Length];

            int i = 0;
            int j = 0;

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    mergedArray[i + j] = arr1[i];
                    i++;
                }
                else
                {
                    mergedArray[i + j] = arr2[j];
                    j++;
                }
            }
            if (i < arr1.Length)
            {
                for (; i < arr1.Length; i++)
                {
                    mergedArray[i + j] = arr1[i];
                }
            }
            else
            {
                for (; j < arr2.Length; j++)
                {
                    mergedArray[i + j] = arr2[j];
                }
            }
            return mergedArray;
        }
    }
}
