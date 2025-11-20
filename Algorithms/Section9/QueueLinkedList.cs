using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Section9
{
    public class QueueLinkedList<T>
    {
        public LinkedList<T> QueueList = new LinkedList<T>();
        public QueueLinkedList() { }

        public T Enqueue(T value)
        {
            return QueueList.AddLast(value).Value;
        }

        public T Dequeue()
        {
            T result = QueueList.First();
            QueueList.RemoveFirst();
            return result;
        }

        public T Peek()
        {
            return QueueList.First();
        }
    }
}
