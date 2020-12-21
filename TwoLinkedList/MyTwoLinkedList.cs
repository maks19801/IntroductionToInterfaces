using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TwoLinkedList
{
    public class MyTwoLinkedList<T>:ICollection<T>, IEnumerable<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Count { get; set; }

        public bool IsReadOnly => throw new NotImplementedException();

        public MyTwoLinkedList() { }

        public MyTwoLinkedList(T value)
        {
            Node<T> newNode = new Node<T>(value);
            Head = newNode;
            Tail = newNode;
            Count = 1;

        }
        public MyTwoLinkedList(IEnumerable<T> values)
        {
            IEnumerator<T> enumerator = values.GetEnumerator();
            Node<T> currentNode;

            if (enumerator.MoveNext())
            {
                Head = new Node<T>(enumerator.Current);
                currentNode = Head;
                Count = 1;
            }
            else
            {
                return;
            }

            while (enumerator.MoveNext())
            {
                Node<T> newNode = new Node<T>(enumerator.Current);
                currentNode.Next = newNode;
                currentNode = newNode;
                Count++;
            }

        }

        public void Add(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if(Head == null)
            {
                Head = newNode;
            }
            else
            {
                Tail.Next = newNode;
                newNode.Previous = Tail;
            }
            Tail = newNode;
            Count++;
        }

        public void AddFirst(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head.Previous = newNode;
            }
            Head = newNode;
            Count++;
        }


        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool Contains(T value)
        {
            Node<T> current = Head;
            while(current != null)
            {
                if (current.Value.Equals(value))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Node<T> current = Head;
            if (current == null)
            {
                return;
            }
            while (arrayIndex < array.Length && current != null)
            {
                array[arrayIndex] = current.Value;
                current = current.Next;
                arrayIndex++;
            }
        }

        public bool Remove(T value)
        {
            if(Head != null)
            {
                if (Head.Value.Equals(value))
                {
                    Head = Head.Next;
                    Count--;
                    return true;
                }

                Node<T> current = Head.Next;
                while(current != null)
                {
                    if (current.Value.Equals(value))
                    {
                        current.Previous.Next = current.Next;
                        Count--;
                        return true;
                    }
                    current = current.Next;
                }
                Tail = current.Previous;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator<T>(this);
        }
       
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
