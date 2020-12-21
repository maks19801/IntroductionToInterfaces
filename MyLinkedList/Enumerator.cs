using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class Enumerator<T> : IEnumerator<T>
    {
        private MyLinkedList<T> list = null;

        private Node<T> currentNode = null;

        private int index = -1;


        public Enumerator(MyLinkedList<T> myList)
        {
            list = myList;
        }

        public bool MoveNext()
        {
            currentNode = index < 0 ? list.Head : currentNode.Next;
            index++;
            return currentNode != null;
        }

        public void Reset()
        {
            currentNode = null;
            index = -1;
        }
        public T Current => currentNode.Value;

        object IEnumerator.Current => Current;
        public void Dispose() { }
    }
}
