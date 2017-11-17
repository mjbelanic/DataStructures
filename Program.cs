using System;


namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Linked List Example");
            Console.WriteLine("===================");
            LinkedList myList = new LinkedList();
            myList.PrintList();
            int removedValue = random.Next(1, 11);
            myList.Append(random.Next(11, 21));
            myList.Append(random.Next(21, 31));
            myList.Append(removedValue);
            myList.Append(random.Next(31, 41));
            myList.Append(random.Next(41, 51));
            myList.PrintList();
            Console.WriteLine(myList.ListEmpty());
            myList.Prepend(0);
            myList.PrintList();
            myList.DeleteWithValue(removedValue);
            myList.PrintList();

            Console.WriteLine("");

            Console.WriteLine("Queue Example");
            Console.WriteLine("=============");
            Queue myQueue = new Queue();
            Console.WriteLine(myQueue.IsEmpty());
            for (int i = 0; i < 10; i++)
            {
                int value = random.Next(1, 101);
                Console.Write(value + " ");
                myQueue.Add(value);
            }
            Console.WriteLine("");
            Console.WriteLine(myQueue.Peek());
            for(int i = 0; i < 10; i++)
            {
                int topValue = myQueue.Remove();
                Console.Write(topValue + " ");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Stack Example");
            Console.WriteLine("=============");

            Stack myStack = new Stack();
            Console.WriteLine(myStack.IsEmpty());
            
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

 


            Console.ReadLine();
        }
    }
}
