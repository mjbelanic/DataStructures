namespace DataStructures
{
    public class Stack
    {
        public Stack() {}

        public class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
            }
        };

        private Node top;

        public bool IsEmpty()
        {
            return (top == null);
        }

        public int Peek()
        {
            return top.data;
        }
        
        public void Push(int data) {
            Node node = new Node(data);
            node.next = top;
            top = node;
        }

        public int Pop() {
            int data = top.data;
            top = top.next;
            return data;
        }

        public int Length()
        {
            Node iterator = top;
            int count = 0;
            while(iterator != null)
            {
                count++;
                iterator = iterator.next;
            }
            return count;
        }
    }


}
