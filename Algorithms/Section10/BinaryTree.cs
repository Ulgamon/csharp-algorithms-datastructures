using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Section10
{
    public class BinaryTree<T>
    {
        public Node<T>? Root { get; set; }
        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(T value)
        {

        }

        public void Lookup(T value)
        {

        }

        public void Remove(T value)
        {

        }
    }

    public class Node<T>
    {
        public Node<T>? Left { get; set; }

        public Node<T>? Right { get; set; }

        public T Value { get; set; }
        public Node(T value)
        {
            Value = value;
        }
    }
}
