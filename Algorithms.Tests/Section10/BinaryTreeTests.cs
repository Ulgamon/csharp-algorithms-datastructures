using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Section10;

namespace Algorithms.Tests.Section10
{
    public class BinaryTreeTests
    {
        [Fact]
        public void BinaryTreeInsertTest()
        {
            BinaryTree tree = new BinaryTree();

            tree.Insert(9);
            tree.Insert(4);
            tree.Insert(6);
            tree.Insert(20);
            tree.Insert(170);
            tree.Insert(15);
            tree.Insert(1);


            List<int> treeTest = new List<int> { 9, 4, 1, 6, 20, 15, 170 };

            List<int> result = tree.Traverse();

            Assert.Equal(treeTest, result);

        }

        [Fact]
        public void BinaryTreeLookupTestTrue()
        {
            BinaryTree tree = new BinaryTree();

            tree.Insert(9);
            tree.Insert(4);
            tree.Insert(6);
            tree.Insert(20);
            tree.Insert(170);
            tree.Insert(15);
            tree.Insert(1);


            Assert.True(tree.Lookup(170));
        }

        [Fact]
        public void BinaryTreeLookupTestFalse()
        {
            BinaryTree tree = new BinaryTree();

            tree.Insert(9);
            tree.Insert(4);
            tree.Insert(6);
            tree.Insert(20);
            tree.Insert(170);
            tree.Insert(15);
            tree.Insert(1);


            Assert.False(tree.Lookup(1700));
        }

        [Fact]
        public void BinaryTreeRemoveTest()
        {

        }
    }
}
