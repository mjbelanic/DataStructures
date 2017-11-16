using System;


namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            Console.WriteLine(myStack.IsEmpty());
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                int value = random.Next(1, 100);
                myStack.Push(value);
                Console.Write(value + " ");
            }
            Console.Write("\n");
            int myStackLength = myStack.Length();
            Console.WriteLine(myStack.Peek());
            for(int i = 0; i < myStackLength; i++)
            {
                Console.Write(myStack.Pop() + " ");
            }
            Console.ReadLine();
        }
    }
}
