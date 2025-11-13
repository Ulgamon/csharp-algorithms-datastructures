using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Section8;

namespace Algorithms.Tests.Section8Tests
{
    public class LinkedListsTests
    {
        [Fact]
        public void TestLinkedLists1()
        {
            // Creating array of links for Linked List constructor
            Link<int>[] test = [new Link<int>(1), new Link<int>(2), new Link<int>(3), new Link<int>(4), new Link<int>(0), new Link<int>(-1), new Link<int>(80)];

            LinkedListImplementation<int> ints = new LinkedListImplementation<int>(test);

            // Creating a test list
            List<int> list = new List<int> { 1, 2, 3, 4, 0, -1, 80 };

            Assert.Equal(ints.ReturnListForTesting(), list);
        }

        [Fact]
        public void TestLookupCorrectValue()
        {
            // Creating array of links for Linked List constructor
            Link<int>[] test = [new Link<int>(1), new Link<int>(2), new Link<int>(3), new Link<int>(4), new Link<int>(0), new Link<int>(-1), new Link<int>(80)];

            LinkedListImplementation<int> ints = new LinkedListImplementation<int>(test);

            int result = 80;

            Assert.Equal(ints.Lookup(result).Value, result);
        }

        [Fact]
        public void TestLookupIncorrectValue()
        {
            // Creating array of links for Linked List constructor
            Link<int>[] test = [new Link<int>(1), new Link<int>(2), new Link<int>(3), new Link<int>(4), new Link<int>(0), new Link<int>(-1), new Link<int>(80)];

            LinkedListImplementation<int> ints = new LinkedListImplementation<int>(test);

            Assert.Equal(ints.Lookup(69), null);
        }


        [Fact]
        public void TestLinkedListsPrepend()
        {
            // Creating array of links for Linked List constructor
            Link<int>[] test = [new Link<int>(1), new Link<int>(2), new Link<int>(3), new Link<int>(4), new Link<int>(0), new Link<int>(-1), new Link<int>(80)];

            LinkedListImplementation<int> ints = new LinkedListImplementation<int>(test);

            // Creating a test list
            List<int> list = new List<int> { 69, 1, 2, 3, 4, 0, -1, 80 };

            ints.Prepend(new Link<int>(69));

            Assert.Equal(ints.ReturnListForTesting(), list);
        }

        [Fact]
        public void TestLinkedListsAppend()
        {
            // Creating array of links for Linked List constructor
            Link<int>[] test = [new Link<int>(1), new Link<int>(2), new Link<int>(3), new Link<int>(4), new Link<int>(0), new Link<int>(-1), new Link<int>(80)];

            LinkedListImplementation<int> ints = new LinkedListImplementation<int>(test);

            // Creating a test list
            List<int> list = new List<int> { 1, 2, 3, 4, 0, -1, 80, 69 };

            ints.Append(new Link<int>(69));

            Assert.Equal(ints.ReturnListForTesting(), list);
        }

        [Fact]
        public void TestLinkedListsInsert()
        {
            // Creating array of links for Linked List constructor
            Link<int>[] test = [new Link<int>(1), new Link<int>(2), new Link<int>(3), new Link<int>(4), new Link<int>(0), new Link<int>(-1), new Link<int>(80)];

            LinkedListImplementation<int> ints = new LinkedListImplementation<int>(test);

            // Creating a test list
            List<int> list = new List<int> { 1, 2, 3, 4, 100, 0, -1, 80 };

            ints.Insert(4, new Link<int>(100));

            Assert.Equal(ints.ReturnListForTesting(), list);
        }
    }
}
