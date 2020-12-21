using System;
using System.Collections.Generic;
using System.Text;

namespace TwoLinkedList
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Previous { get; set; }
        public Node<T> Next { get; set; }

        public Node(T value)
        {
            Value = value;
        }
        public Node(T value, Node<T> previous, Node<T> next)
        {
            Value = value;
            Previous = previous;
            Next = next;
        }

    }
}
