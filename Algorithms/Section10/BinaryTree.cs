using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Section10
{
    public class BinaryTree
    {
        public Node? Root { get; set; }
        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(int value)
        {
            Node valueToInsert = new Node(value);

            if (Root == null)
            {
                Root = valueToInsert;
                return;
            }

            Node? temp = Root;

            while (temp != null)
            {
                if (temp.Value < value)
                {
                    if (temp.Right == null)
                    {
                        temp.Right = valueToInsert;
                        return;
                    }
                    else
                    {
                        temp = temp.Right;
                    }
                }
                else
                {
                    if (temp.Left == null)
                    {
                        temp.Left = valueToInsert;
                        return;
                    }
                    else
                    {
                        temp = temp.Left;
                    }
                }
            }
        }

        public Node? Lookup(int value)
        {
            Node? temp = Root;
            while (temp != null)
            {
                if (temp.Value == value)
                {
                    return temp;
                }
                else if (temp.Value < value)
                {
                    temp = temp.Right;
                }
                else
                {
                    temp = temp.Left;
                }
            }
            return null;
        }

        //public bool Remove(int value)
        //{
        //    if (Root == null)
        //    {
        //        return false;
        //    }

        //    Node? currentNode = Root;
        //    Node? parentNode = null;

        //    while (currentNode != null)
        //    {
        //        if (value < currentNode.Value)
        //        {

        //        }
        //    }
        //}

        public List<int> Traverse()
        {
            List<int> result = new List<int>();

            PreOrder(Root, result);

            return result;
        }

        public void PreOrder(Node node, List<int> tree)
        {
            if (node == null) return;

            tree.Add(node.Value);

            PreOrder(node.Left, tree);

            PreOrder(node.Right, tree);

        }
    }

    public class Node
    {
        public Node? Left { get; set; }

        public Node? Right { get; set; }

        public int Value { get; set; }
        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}
