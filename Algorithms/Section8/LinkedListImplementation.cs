using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Section8
{
    public class LinkedListImplementation<T>
    {
        public Link<T>? Head { get; set; }

        public Link<T>? Tail { get; set; }

        public int Length { get; set; }

        public LinkedListImplementation(params Link<T>[] values)
        {
            if (values == null || values.Length == 0)
            {
                Length = 0;
                Head = default;
                Tail = default;
            }
            else
            {
                Length = values.Length;
                Head = values.First();
                Tail = values.Last();

                for (int i = 0; i < values.Length - 1; i++)
                {
                    values[i].Reference = values[i + 1];
                }
                Tail.Reference = null;
            }

        }

        // O(1) time complexity
        // 
        public Link<T> Prepend(Link<T> element)
        {
            if (Length > 0)
            {
                element.Reference = Head;
                Head = element;
            }
            else
            {
                Tail = element;
                Head = element;
            }
            Length++;
            return element;
        }

        public Link<T> Append(Link<T> element)
        {
            if (Length > 0)
            {
                Tail.Reference = element;
                Tail = element;
                element.Reference = null;
            }
            else
            {
                Tail = element;
                Head = element;
            }
            Length++;
            return element;
        }

        public Link<T>? Lookup(T value)
        {
            Link<T>? iterator = Head;
            if (Length > 0 && iterator != null)
            {
                while (iterator != null)
                {
                    if (iterator.Value.ToString() == value.ToString())
                    {
                        return iterator;
                    }
                    iterator = iterator.Reference;
                }
            }
            return null;
        }

        public Link<T>? Insert(int index, Link<T> element)
        {
            int i = 0;

            if (index == 0)
            {
                return this.Prepend(element);
            }

            if (index + 1 == Length)
            {
                return this.Append(element);
            }

            if (Length > 0 && index > 0 && index < Length)
            {
                Link<T> prev = TraverseToIndex(index - 1);
                if (prev != null && prev.Reference != null)
                {
                    Link<T> currEl = prev.Reference;
                    prev.Reference = element;
                    element.Reference = currEl;
                    Length++;
                    return element;
                }
            }
            return null;
        }

        public Link<T>? TraverseToIndex(int index)
        {
            if (index < 0 || index >= Length)
            {
                return null;
            }
            int counter = 0;
            Link<T>? iterator = Head;
            while (counter != index)
            {
                counter++;
                iterator = iterator.Reference;
            }
            return iterator;
        }

        public Link<T>? RemoveFromIndex(int index)
        {
            if (index >= Length || index < 0) return null;

            Link<T>? prev = TraverseToIndex(index - 1);

            if (prev != null && prev.Reference != null)
            {
                Link<T> unwantedNode = prev.Reference;
                prev.Reference = unwantedNode.Reference;
                Length--;
                return unwantedNode;
            }

            return null;
        }

        public void Reverse()
        {
            if (Head == null || Head.Reference == null)
            {
                return;
            }

            Link<T>? first = Head;
            Tail = Head;
            Link<T>? second = first.Reference;

            while (second != null)
            {
                Link<T>? third = second.Reference;
                second.Reference = first;
                first = second;
                second = third;
            }

            Head = first;
            Tail.Reference = null;

        }

        public List<T> ReturnListForTesting()
        {
            List<T> elements = new List<T>();
            if (Length == 0) return elements;
            Link<T>? iterator = Head;

            while (iterator != null)
            {
                elements.Add(iterator.Value);
                iterator = iterator.Reference;
            }
            return elements;
        }

    }
    public class Link<T>
    {
        public Link<T>? Reference { get; set; } = default;
        public T Value { get; set; }

        public Link(T value, Link<T>? reference = default)
        {
            Value = value;
            Reference = reference;
        }
    }

}