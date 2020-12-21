using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> myList = new MyLinkedList<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Remove(3);
            Console.WriteLine(myList.Count);
            foreach (int number in myList)
            {
                Console.WriteLine(number);
            }



            string[] strings = new[] { "Bob", "Sally", "Mark", "Colt" };


            MyLinkedList<string> listOfStrings = new MyLinkedList<string>(strings);
            Console.WriteLine(listOfStrings.IndexOf("Mark"));

            listOfStrings.Insert(4, "Max");
            listOfStrings.RemoveAt(1);
            listOfStrings.Add("Porsh");
            Console.WriteLine(listOfStrings.Contains("Colty"));

            foreach (string item in listOfStrings)
            {
                Console.WriteLine(item);
            }

        }


    }
}
