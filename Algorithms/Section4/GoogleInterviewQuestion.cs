using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Exercises
{
    public class GoogleInterviewQuestion
    {
        // https://www.youtube.com/watch?v=XKu_SEDAykw
        // sorted array of numbers
        // need to find a matching pair that equals to the sum that is given alongside array
        // array = [1, 2, 3, 9] sum = 8 false
        // array = [1, 2, 4, 4] sum = 8 true
        // we need to check if arrays are empty
        // output: boolean value which tells if we found it or not

        //// Brute force algorithm O(n^2)
        //public static bool hasPairWithSum(List<int> arr, int sum)
        //{
        //    for (int i = 0; i < arr.Count; i++)
        //    {
        //        for (int j = i + 1; j < arr.Count; j++)
        //        {
        //            if (arr[i] + arr[j] == sum) return true;
        //        }
        //    }
        //    return false;
        //}

        //// Solution O(n) with sorted elements
        //public static bool hasPairWithSum(List<int> arr, int sum)
        //{
        //    int low = 0;
        //    int high = arr.Count - 1;
        //    while (low < high)
        //    {
        //        int pairSum = arr[low] + arr[high];
        //        if (pairSum == sum)
        //        {
        //            return true;
        //        }
        //        else if (pairSum < sum)
        //        {
        //            low++;
        //        }
        //        else
        //        {
        //            high--;
        //        }
        //    }

        //    return false;
        //}

        // Solution O(n) with unsorted elements

        public static bool hasPairWithSum(List<int> arr, int sum)
        {
            // We will traverse through integer list and add complement number to HashSet
            // and check if current element exists in HashSet
            HashSet<int> complements = new HashSet<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                if (complements.Contains(arr[i]))
                {
                    return true;
                }
                else
                {
                    complements.Add(sum - arr[i]);
                }
            }
            return false;
        }

    }
}
