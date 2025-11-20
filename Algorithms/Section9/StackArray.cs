using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Section9
{
    public class StackArray<T>
    {
        public List<T> StackValues = new List<T>();
        public StackArray() { }

        public T Peek()
        {
            return StackValues.Last();
        }

        public T Push(T value)
        {
            StackValues.Add(value);
            return value;
        }

        public T Pop()
        {
            T result = StackValues.Last();
            StackValues.RemoveAt(StackValues.Count - 1);
            return result;
        }
    }
}
