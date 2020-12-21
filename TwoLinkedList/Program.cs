using System;

namespace TwoLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTwoLinkedList<string> dogsList = new MyTwoLinkedList<string>();
            dogsList.Add("Rex");
            dogsList.Add("Kuzya");
            dogsList.Add("Bethoven");
            dogsList.Add("Lusy");
            dogsList.Add("Lusinda");
            Console.WriteLine(dogsList.Count);
            Console.WriteLine( dogsList.Contains("Rex1"));

            Console.WriteLine();
            dogsList.Remove("Bethoven");
            dogsList.AddFirst("Bethoven");

            foreach(string dog in dogsList)
            {
                Console.WriteLine(dog);
            }

            Console.WriteLine();
            string[] dogs = new string[10];

            dogsList.CopyTo(dogs, 5);


            for(int i = 0; i < dogs.Length; i++)
            {
                if (dogs[i] != null)
                {
                    Console.WriteLine(dogs[i]);
                }
               
            }
            int[] listOfNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            MyTwoLinkedList<int> numbersList = new MyTwoLinkedList<int>(listOfNumbers);
           
            foreach(int number in numbersList)
            {
                Console.WriteLine(number);
            }
        }
    }
}
