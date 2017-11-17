using System;


namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack Example");
            Console.WriteLine("=============");

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

            Console.WriteLine("");

            Console.WriteLine("Linked List Example");
            Console.WriteLine("===================");
            LinkedList myList = new LinkedList();
            myList.PrintList();
            myList.Append(1);
            myList.Append(2);
            myList.Append(3);
            myList.Append(4);
            myList.Append(5);
            myList.PrintList();
            Console.WriteLine(myList.ListEmpty());
            myList.Prepend(0);
            myList.PrintList();
            myList.DeleteWithValue(3);
            myList.PrintList();


            Console.ReadLine();
        }
    }
}
