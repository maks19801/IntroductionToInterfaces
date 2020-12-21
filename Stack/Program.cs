using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<string> carsStack = new MyStack<string>();
            carsStack.Push("Ford");
            carsStack.Push("Daewoo");
            carsStack.Push("Opel");
            carsStack.Push("BMW");

            foreach (var item in carsStack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            string header = carsStack.Peek();
            Console.WriteLine("The Peek of the stack : " + header);
            Console.WriteLine();

            header = carsStack.Pop();
            foreach (var item in carsStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
