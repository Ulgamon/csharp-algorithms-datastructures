using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Section6;

namespace Algorithms.Tests.Section6Tests
{
    public class MergeSortedArraysTests
    {
        [Fact]
        public void TestMergeSortedArrays()
        {
            int[] arr1 = [0, 3, 4, 31];
            int[] arr2 = [4, 6, 30];

            int[] correctResult = [0, 3, 4, 4, 6, 30, 31];

            int[] result = MergeSortedArrays.MergeSortedArraysMethod(arr1, arr2);

            Assert.Equal(correctResult, result);

        }

        [Fact]
        public void TestMergeSortedArraysOneElement()
        {
            int[] arr1 = [0];
            int[] arr2 = [4];

            int[] correctResult = [0, 4];

            int[] result = MergeSortedArrays.MergeSortedArraysMethod(arr1, arr2);

            Assert.Equal(correctResult, result);

        }

        [Fact]
        public void TestMergeSortedArraysEmptyArrays()
        {
            int[] arr1 = [];
            int[] arr2 = [];

            int[] correctResult = [];

            int[] result = MergeSortedArrays.MergeSortedArraysMethod(arr1, arr2);

            Assert.Equal(correctResult, result);

        }

    }
}
