using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Section8
{
    public class DoublyLinkedList<T>
    {
        DoublyLink<T>? Head { get; set; }
        DoublyLink<T>? Tail { get; set; }
        int Length { get; set; }

        public DoublyLinkedList(params DoublyLink<T>[] values)
        {
            if (values == null || values.Length == 0)
            {
                Head = null;
                Tail = null;
                Length = 0;
            }
            else
            {
                Head = values[0];
                Tail = values[values.Length - 1];
                Length = values.Length;
                for (int i = 0; i < values.Length - 1; i++)
                {
                    values[i].Next = values[i + 1];
                }
                for (int j = values.Length - 1; j > 0; j--)
                {
                    values[j].Previous = values[j - 1];
                }
            }
        }
        public List<T> ReturnList()
        {
            List<T> list = new List<T>();
            if (Length > 0)
            {
                DoublyLink<T> link = Head;
                while (link != null)
                {
                    list.Add(link.Value);
                    link = link.Next;
                }
            }
            return list;
        }

        public DoublyLink<T>? Append(DoublyLink<T> link)
        {
            if (Length == 0)
            {
                Head = link;
                Tail = link;
                Length++;
                return link;
            }
            link.Previous = Tail;
            Tail.Next = link;
            Tail = link;
            return link;
        }

        public DoublyLink<T>? Prepend(DoublyLink<T> link)
        {
            if (Length == 0)
            {
                Head = link;
                Tail = link;
                Length++;
                return link;
            }
            link.Next = Head;
            Head.Previous = link;
            Head = link;
            return link;
        }

        public DoublyLink<T>? DeleteFirstItem()
        {
            if (Length > 1)
            {
                DoublyLink<T>? result = Head;

                result.Next.Previous = null;

                Head = result.Next;

                return result;
            }
            else if (Length == 1)
            {
                DoublyLink<T>? result = Head;
                Head = null;
                Tail = null;
                Length--;
                return result;
            }
            return null;
        }

        public DoublyLink<T>? DeleteLastItem()
        {
            if (Length > 1)
            {
                DoublyLink<T>? result = Tail;

                Tail.Previous.Next = null;

                Tail = result;

                return result;
            }
            else if (Length == 1)
            {
                DoublyLink<T>? result = Head;
                Head = null;
                Tail = null;
                Length--;
                return result;
            }
            return null;
        }

        public DoublyLink<T>? TraverseToIndex(int index)
        {
            if (Head != null && Tail != null && index > 0 && index < Length)
            {
                if (index < Length / 2)
                {
                    int counter = 0;
                    DoublyLink<T>? result = Head;
                    while (index != counter)
                    {
                        result = result.Next;
                        counter++;
                    }
                    return result;
                }
                else
                {
                    int counter = Length - 1;
                    DoublyLink<T>? result = Tail;
                    while (index != counter)
                    {
                        result = result.Previous;
                        counter--;
                    }
                    return result;
                }
            }
            return null;
        }

        public DoublyLink<T>? Remove(int index)
        {
            if (index > 0 && index < Length)
            {
                DoublyLink<T>? itemToRemove = TraverseToIndex(index);

                DoublyLink<T>? prev = itemToRemove.Previous;
                DoublyLink<T>? next = itemToRemove.Next;

                if (prev == null)
                {
                    return DeleteFirstItem();
                }
                if (next == null)
                {
                    return DeleteLastItem();
                }

                prev.Next = next;
                next.Previous = prev;
                Length--;

                return itemToRemove;

            }
            return null;
        }
    }

    public class DoublyLink<T>
    {
        public DoublyLink<T>? Next { get; set; } = default;
        public DoublyLink<T>? Previous { get; set; } = default;
        public T Value { get; set; }

        public DoublyLink(T value, DoublyLink<T>? next = default, DoublyLink<T>? previous = default)
        {
            Value = value;
            Next = next;
            Previous = previous;
        }
    }
}
