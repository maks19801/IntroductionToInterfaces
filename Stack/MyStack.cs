using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class MyStack<T>: IEnumerable<T>
    {
        public Node<T> Head;
        private int count;
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; }  }
        public MyStack() { }
        public MyStack(T value)
        {
            Node<T> newNode = new Node<T>(value);
            newNode.Next = Head;
            count = 1;
        }
         public void Push(T value)
        {
            Node<T> newNode = new Node<T>(value);
            newNode.Next = Head;
            Head = newNode;
            count++;
        }
        public T Pop()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Stack is Empty");
            }
            Node<T> temporaryHead = Head;
            Head = Head.Next;
            count--;
            return temporaryHead.Value;
            
        }
        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Stack is Empty");
            }
            return Head.Value;
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
