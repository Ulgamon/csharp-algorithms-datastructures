using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Section9;

namespace Algorithms.Tests.Section9Tests
{
    public class QueueTests
    {
        [Fact]
        public void TestQueue()
        {
            QueueLinkedList<int> ints = new QueueLinkedList<int>();

            ints.Enqueue(1);
            ints.Enqueue(2);
            ints.Enqueue(3);
            ints.Enqueue(4);
            ints.Enqueue(0);
            ints.Enqueue(-1);
            ints.Enqueue(80);

            // Creating a test list
            List<int> list = new List<int> { 1, 2, 3, 4, 0, -1, 80 };

            Assert.Equal(ints.QueueList, list);
        }

        [Fact]
        public void TestStackDequeue()
        {
            QueueLinkedList<int> ints = new QueueLinkedList<int>();

            ints.Enqueue(1);
            ints.Enqueue(2);
            ints.Enqueue(3);
            ints.Enqueue(4);
            ints.Enqueue(0);
            ints.Enqueue(-1);
            ints.Enqueue(80);

            ints.Dequeue();
            ints.Dequeue();

            // Creating a test list
            List<int> list = new List<int> { 3, 4, 0, -1, 80 };

            Assert.Equal(ints.QueueList, list);
        }

        [Fact]
        public void TestStackPeek()
        {
            QueueLinkedList<int> ints = new QueueLinkedList<int>();

            ints.Enqueue(1);
            ints.Enqueue(2);
            ints.Enqueue(3);
            ints.Enqueue(4);
            ints.Enqueue(0);
            ints.Enqueue(-1);
            ints.Enqueue(80);

            Assert.Equal(1, ints.Peek());
        }
    }
}
