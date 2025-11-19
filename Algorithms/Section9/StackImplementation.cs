using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Section9
{
    public class StackImplementation<T>
    {
        StackNode<T>? Top { get; set; }
        StackNode<T>? Bottom { get; set; }
        int Length { get; set; }

        public StackImplementation()
        {
            Top = null;
            Bottom = null;
            Length = 0;
        }

        //public StackNode<T>? Peek(int index)
        //{

        //}

        public StackNode<T>? Push(StackNode<T> value)
        {
            if (Length == 0)
            {
                Top = value;
                Bottom = value;
                Length++;
                return value;
            }
            value.Next = Top;
            Top = value;
            Length++;
            return value;
        }

        public StackNode<T>? Pop()
        {
            if (Length == 1 && Top != null)
            {
                StackNode<T> res = Top;
                Top = null;
                Bottom = null;
                Length = 0;
                return res;
            }
            if (Length == 0 || Top == null) return null;

            StackNode<T> result = Top;
            Top = Top.Next;
            result.Next = null;
            Length--;
            return result;

        }

        public List<T> ReturnList()
        {
            List<T> result = new List<T>();
            if (Top == null || Length == 0) return result;
            StackNode<T>? iter = Top;
            while (iter != null)
            {
                result.Add(iter.Value);
                iter = iter.Next;
            }
            return result;
        }
    }

    public class StackNode<T>
    {
        public T Value { get; set; }
        public StackNode<T>? Next { get; set; }

        public StackNode(T value, StackNode<T>? next = null)
        {
            Value = value;
            Next = next;
        }
    }
}
