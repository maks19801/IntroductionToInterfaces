using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class Enumerator<T> : IEnumerator<T>
    {
        private MyStack<T> stack = null;
        private Node<T> currentNode = null;
        private int index = -1;
        public T Current => currentNode.Value;

        object IEnumerator.Current => Current;

        public Enumerator(MyStack<T> myStack)
        {
            stack = myStack;
        } 

        public void Dispose() {}

        public bool MoveNext()
        {
            currentNode = index < 0 ? stack.Head : currentNode.Next;
            index++;
            return currentNode != null;
        }

        public void Reset()
        {
            currentNode = null;
            index = -1;
        }
    }
}
