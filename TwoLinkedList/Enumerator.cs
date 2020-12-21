using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TwoLinkedList
{
    public class Enumerator<T> : IEnumerator<T>
    {
        private MyTwoLinkedList<T> list = null;
        private Node<T> current = null;
        private int index = -1;
        public T Current => current.Value;

        object IEnumerator.Current => Current;

        public Enumerator(MyTwoLinkedList<T> myList)
        {
            list = myList;
        }



        public void Dispose(){}

        public bool MoveNext()
        {
            current = index < 0 ? list.Head : current.Next;
            index++;
            return current != null;
        }

        public void Reset()
        {
            current = null;
            index = -1;
        }
    }
}
