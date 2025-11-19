using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Section8;
using Algorithms.Section9;

namespace Algorithms.Tests.Section9Tests
{
    public class StackImplementationTests
    {
        [Fact]
        public void TestStack()
        {
            // Creating array of links for Linked List constructor
            StackNode<int>[] test = [new StackNode<int>(1), new StackNode<int>(2), new StackNode<int>(3), new StackNode<int>(4), new StackNode<int>(0), new StackNode<int>(-1), new StackNode<int>(80)];

            StackImplementation<int> ints = new StackImplementation<int>();

            ints.Push(new StackNode<int>(80));
            ints.Push(new StackNode<int>(-1));
            ints.Push(new StackNode<int>(0));
            ints.Push(new StackNode<int>(4));
            ints.Push(new StackNode<int>(3));
            ints.Push(new StackNode<int>(2));
            ints.Push(new StackNode<int>(1));

            // Creating a test list
            List<int> list = new List<int> { 1, 2, 3, 4, 0, -1, 80 };

            Assert.Equal(ints.ReturnList(), list);
        }

        [Fact]
        public void TestStackPop()
        {
            // Creating array of links for Linked List constructor
            StackNode<int>[] test = [new StackNode<int>(1), new StackNode<int>(2), new StackNode<int>(3), new StackNode<int>(4), new StackNode<int>(0), new StackNode<int>(-1), new StackNode<int>(80)];

            StackImplementation<int> ints = new StackImplementation<int>();

            ints.Push(new StackNode<int>(80));
            ints.Push(new StackNode<int>(-1));
            ints.Push(new StackNode<int>(0));
            ints.Push(new StackNode<int>(4));
            ints.Push(new StackNode<int>(3));
            ints.Push(new StackNode<int>(2));
            ints.Push(new StackNode<int>(1));

            ints.Pop();
            ints.Pop();

            // Creating a test list
            List<int> list = new List<int> { 3, 4, 0, -1, 80 };

            Assert.Equal(ints.ReturnList(), list);
        }
    }
}
