using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Section9;

namespace Algorithms.Tests.Section9Tests
{
    public class QueueUsingStackTests
    {
        public class QueueTests
        {
            [Fact]
            public void TestQueue()
            {
                QueueUsingStack<int> ints = new QueueUsingStack<int>();

                ints.Push(1);
                ints.Push(2);
                ints.Push(3);
                ints.Push(4);
                ints.Push(0);
                ints.Push(-1);
                ints.Push(80);

                // Creating a test list
                List<int> list = new List<int> { 1, 2, 3, 4, 0, -1, 80 };

                Assert.Equal(ints.QueueList(), list);
            }

            [Fact]
            public void TestStackDequeue()
            {
                QueueUsingStack<int> ints = new QueueUsingStack<int>();

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
                List<int> list = new List<int> { 3, 4, 0, -1, 80 };

                Assert.Equal(ints.QueueList(), list);
            }

            [Fact]
            public void TestStackPeek()
            {
                QueueUsingStack<int> ints = new QueueUsingStack<int>();

                ints.Push(1);
                ints.Push(2);
                ints.Push(3);
                ints.Push(4);
                ints.Push(0);
                ints.Push(-1);
                ints.Push(80);

                Assert.Equal(1, ints.Peek());
            }
        }
    }
}
