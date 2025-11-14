using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Section8;

namespace Algorithms.Tests.Section8Tests
{
    public class DoublyLinkedListTests
    {
        [Fact]
        public void TestLinkedLists1()
        {
            // Creating array of links for Linked List constructor
            DoublyLink<int>[] test = [new DoublyLink<int>(1), new DoublyLink<int>(2), new DoublyLink<int>(3), new DoublyLink<int>(4), new DoublyLink<int>(0), new DoublyLink<int>(-1), new DoublyLink<int>(80)];

            DoublyLinkedList<int> ints = new DoublyLinkedList<int>(test);

            // Creating a test list
            List<int> list = new List<int> { 1, 2, 3, 4, 0, -1, 80 };

            Assert.Equal(ints.ReturnList(), list);
        }

        [Fact]
        public void TestLinkedListsAppend()
        {
            // Creating array of links for Linked List constructor
            DoublyLink<int>[] test = [new DoublyLink<int>(1), new DoublyLink<int>(2), new DoublyLink<int>(3), new DoublyLink<int>(4), new DoublyLink<int>(0), new DoublyLink<int>(-1), new DoublyLink<int>(80)];

            DoublyLinkedList<int> ints = new DoublyLinkedList<int>(test);

            // Creating a test list
            List<int> list = new List<int> { 1, 2, 3, 4, 0, -1, 80, 69 };

            ints.Append(new DoublyLink<int>(69));

            Assert.Equal(ints.ReturnList(), list);
        }

        [Fact]
        public void TestLinkedListsPrepend()
        {
            // Creating array of links for Linked List constructor
            DoublyLink<int>[] test = [new DoublyLink<int>(1), new DoublyLink<int>(2), new DoublyLink<int>(3), new DoublyLink<int>(4), new DoublyLink<int>(0), new DoublyLink<int>(-1), new DoublyLink<int>(80)];

            DoublyLinkedList<int> ints = new DoublyLinkedList<int>(test);

            // Creating a test list
            List<int> list = new List<int> { 69, 1, 2, 3, 4, 0, -1, 80 };

            ints.Prepend(new DoublyLink<int>(69));

            Assert.Equal(ints.ReturnList(), list);
        }

        [Fact]
        public void TestLinkedListsDeleteFirstItem()
        {
            // Creating array of links for Linked List constructor
            DoublyLink<int>[] test = [new DoublyLink<int>(1), new DoublyLink<int>(2), new DoublyLink<int>(3), new DoublyLink<int>(4), new DoublyLink<int>(0), new DoublyLink<int>(-1), new DoublyLink<int>(80)];

            DoublyLinkedList<int> ints = new DoublyLinkedList<int>(test);

            // Creating a test list
            List<int> list = new List<int> { 2, 3, 4, 0, -1, 80 };

            ints.DeleteFirstItem();

            Assert.Equal(ints.ReturnList(), list);
        }
    }
}
