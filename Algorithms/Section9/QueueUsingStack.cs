using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Section9
{
    public class QueueUsingStack<T>
    {
        public Stack<T> Stack1 = new Stack<T>();
        public Stack<T> Stack2 = new Stack<T>();
        public QueueUsingStack() { }

        public T Push(T value)
        {
            Stack1.Push(value);
            return value;
        }

        public T? Pop()
        {
            if (Stack2.Count == 0 && Stack1.Count > 0)
            {
                while (Stack1.Count != 0)
                {
                    Stack2.Push(Stack1.Pop());
                }
                return Stack2.Pop();
            }
            if (Stack2.Count > 0)
            {
                return Stack2.Pop();
            }

            return default;

        }

        public T? Peek()
        {
            if (Stack2.Count == 0 && Stack1.Count > 0)
            {
                while (Stack1.Count != 0)
                {
                    Stack2.Push(Stack1.Pop());
                }
                return Stack2.Peek();
            }
            if (Stack2.Count > 0)
            {
                return Stack2.Peek();
            }

            return default;
        }

        public bool Empty()
        {
            return Stack2.Count > 0 || Stack1.Count > 0 ? false : true;
        }

        public List<T> QueueList()
        {

            List<T> list2 = Stack2.ToList();

            List<T> list1 = Stack1.ToList();
            list1.Reverse();

            return [.. list1, .. list2];
        }
    }
}
