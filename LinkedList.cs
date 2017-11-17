using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
        }
    };

    public class LinkedList
    {
        public LinkedList() { }

        private Node head;

        public bool ListEmpty()
        {
            return (head == null);
        }

        public void Append(int data)
        {
            if (head == null)
            {
                head = new Node(data);
            }
            else
            {
                Node iterator = head;
                while (iterator.next != null)
                {
                    iterator = iterator.next;
                }
                iterator.next = new Node(data);
            }
        }

        public void Prepend(int data)
        {
            Node newHead = new Node(data);
            newHead.next = head;
            head = newHead;
        }

        public void DeleteWithValue(int data)
        {
            if(head == null)
            {
                return;
            }
            if(head.data == data)
            {
                head = head.next;
                return;
            }
            Node iterator = head;
            while(iterator.next != null)
            {
                if (iterator.next.data == data)
                {
                    iterator.next = iterator.next.next;
                    return;
                }
                iterator = iterator.next;
            }
        }

        public void PrintList()
        {
            if (head == null)
            {
                Console.Write("List is empty");
            }
            else
            {
                Node iterator = head;
                while (iterator != null)
                {
                    Console.Write(iterator.data + " ");
                    iterator = iterator.next;
                }
            }
            Console.WriteLine("");
        }

    }


}
