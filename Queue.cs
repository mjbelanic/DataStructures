using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Queue
    {
        public Queue() { }

        public class Node{
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
            }            
        }

        private Node head; //remove from head
        private Node tail; // add to tail

        public bool IsEmpty()
        {
            return (head == null);
        }

        public int Peek()
        {
            return head.data;
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);
            if(tail != null)
            {
                tail.next = newNode;
            }
            tail = newNode;
            if(head == null)
            {
                head = newNode;
            }
        }

        public int Remove()
        {
            int data = head.data;
            head = head.next;
            if(head == null)
            {
                tail = null;
            }
            return data;
        }


    }
}
