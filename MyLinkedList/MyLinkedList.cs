using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class MyLinkedList<T> : ICollection<T>, IEnumerable<T>, IList<T>
    {
        public Node<T> Head { get; set; }
        public int Count { get; set; }

        public bool IsReadOnly => throw new NotImplementedException();

        public T this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public MyLinkedList() { }

        public MyLinkedList(T Value)
        {
            Node<T> node = new Node<T>(Value);
            Head = node;
            Count = 1;
        }

        public MyLinkedList(IEnumerable<T> values)
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

        public void Add(T Value)
        {
            Node<T> node = new Node<T>(Value);
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Node<T> current = Head;
                while(current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
            Count++;
        }

        public bool Remove(T Value)
        {
            if (Head != null)
            {
                if (Head.Value.Equals(Value))
                {
                    Head = Head.Next;
                    Count--;
                    return true;
                }
                Node<T> current = Head.Next;
                Node<T> previous = Head;
                while (current != null)
                {
                    if (current.Value.Equals(Value))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return true;
                    }
                    previous = current;
                    current = current.Next;
                }
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

        public void Clear()
        {
            Head = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            foreach (T collectionItem in this)
            {
                if (collectionItem.Equals(item)) return true;
            }

            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Node<T> currentNode = Head;
            if (currentNode == null) return;

            while (arrayIndex < array.Length && Count - arrayIndex >= 0)
            {
                array[arrayIndex] = currentNode.Value;
                currentNode = currentNode.Next;
                arrayIndex++;
            }
        }

        public int IndexOf(T item)
        {
            int index = 0;
            Node<T> current = Head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    return index;
                }
                index++;
                current = current.Next;

            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index > Count)
            {
                Console.WriteLine("Index is out of range");
            }
            else
            {
                if (index == 0)
                {
                    Node<T> newNode = new Node<T>(item);
                    newNode.Next = Head;
                    Head = newNode;
                }

                else
                {
                    Node<T> current = Head;
                    Node<T> previous = null;

                    for (int i = 1; i <= index; i++)
                    {
                        previous = current;
                        current = current.Next;
                    }
                    Node<T> newNode = new Node<T>(item);

                    if (current == null)
                    {
                        previous.Next = newNode;
                    }
                    else
                    {
                        previous.Next = newNode;
                        newNode.Next = current;
                    }
                }
                Count++;
            }

        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                Console.WriteLine("Index is out of range");
            }
            else
            {
                Node<T> current = Head;
                Node<T> previous = null;
                if (Count == 1)
                {
                    Head = null;
                }
                else
                {
                    for (int i = 0; i < index; i++)
                    {
                        previous = current;
                        current = current.Next;
                    }

                    if (previous == null)
                    {
                        Head = Head.Next;
                    }
                    else
                    {
                        previous.Next = current.Next;
                    }

                }
                Count--;
            }
        }
    }
}