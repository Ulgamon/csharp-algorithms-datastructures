using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Section9
{
    public class StackUsingQueues<T>
    {
        public Queue<T> Queue1 = new Queue<T>();
        public Queue<T> Queue2 = new Queue<T>();

        public StackUsingQueues() { }

        public void Push(T x)
        {
            Queue1.Enqueue(x);
        }

        public T Pop()
        {
            if (Queue1.Count > 0 && Queue2.Count == 0)
            {
                while (Queue1.Count > 1)
                {
                    Queue2.Enqueue(Queue1.Dequeue());
                }
                T result = Queue1.Dequeue();
                while (Queue2.Count > 0)
                {
                    Queue1.Enqueue(Queue2.Dequeue());
                }
                return result;
            }
            return default;
        }

        public T Top()
        {
            if (Queue1.Count > 0 && Queue2.Count == 0)
            {
                while (Queue1.Count > 1)
                {
                    Queue2.Enqueue(Queue1.Dequeue());
                }
                T result = Queue1.Dequeue();
                Queue2.Enqueue(result);
                while (Queue2.Count > 0)
                {
                    Queue1.Enqueue(Queue2.Dequeue());
                }
                return result;
            }
            return default;
        }

        public bool Empty()
        {
            return Queue1.Count > 0 || Queue2.Count > 0 ? false : true;
        }

        public List<T> QueueList()
        {

            List<T> list1 = Queue1.ToList();

            return list1;
        }
    }
}

