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
            Link<T>? iterator = Head;

            if (index == 0)
            {
                return this.Prepend(element);
            }

            if (index + 1 == Length)
            {
                return this.Append(element);
            }

            if (Length > 0 && iterator != null && index > 0 && index < Length)
            {
                while (i != index - 1)
                {
                    iterator = iterator.Reference;
                    i++;
                }
                element.Reference = iterator.Reference;
                iterator.Reference = element;
                Length++;
                return element;
            }
            return null;
        }

        //public Link<T>? Remove(int index)
        //{
        //    Link<T>? iterator = Head;
        //    if (iterator == null || index >= Length || index < 0) return null;
        //    int i = 0;
        //    while (i - 1 != index)
        //    {
        //        i++;
        //        iterator = iterator.Reference;
        //    }
        //    Link<T> unwantedNode = iterator.Reference;
        //    iterator.Reference = unwantedNode.Reference;
        //    Length--;
        //    return iterator;
        //}

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