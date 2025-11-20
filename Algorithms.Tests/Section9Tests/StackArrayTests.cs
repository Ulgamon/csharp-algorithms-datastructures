using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Section9;

namespace Algorithms.Tests.Section9Tests
{
    public class StackArrayTests
    {
        [Fact]
        public void TestStack()
        {
            StackArray<int> ints = new StackArray<int>();

            ints.Push(1);
            ints.Push(2);
            ints.Push(3);
            ints.Push(4);
            ints.Push(0);
            ints.Push(-1);
            ints.Push(80);

            // Creating a test list
            List<int> list = new List<int> { 1, 2, 3, 4, 0, -1, 80 };

            Assert.Equal(ints.StackValues, list);
        }

        [Fact]
        public void TestStackPop()
        {
            StackArray<int> ints = new StackArray<int>();

            ints.Push(1);
            ints.Push(2);
            ints.Push(3);
            ints.Push(4);
            ints.Push(0);
            ints.Push(-1);
            ints.Push(80);

            ints.Pop();
            ints.Pop();

            // Creating a test list
            List<int> list = new List<int> { 1, 2, 3, 4, 0 };

            Assert.Equal(ints.StackValues, list);
        }

        [Fact]
        public void TestStackPeek()
        {
            StackArray<int> ints = new StackArray<int>();

            ints.Push(1);
            ints.Push(2);
            ints.Push(3);
            ints.Push(4);
            ints.Push(0);
            ints.Push(-1);
            ints.Push(80);

            Assert.Equal(80, ints.Peek());
        }
    }
}
