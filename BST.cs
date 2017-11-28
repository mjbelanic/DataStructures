using System;

namespace DataStructures
{
    public class BSTNode
    {
        public int data;
        public BSTNode left;
        public BSTNode right;

        public BSTNode(int data)
        {
            this.data = data;
        }

        public void InsertNode(int value)
        {
            if (value <= data)
            {
                if (left == null)
                {
                    left = new BSTNode(value);
                }
                else
                {
                    left.InsertNode(value);
                }
            }
            else
            {
                if (right == null)
                {
                    right = new BSTNode(value);
                }
                else
                {
                    right.InsertNode(value);
                }
            }
        }

        public bool ContainsNode(int value)
        {
            if (value == data)
            {
                return true;
            }
            else if (value < data)
            {
                if (left == null)
                {
                    return false;
                }
                else
                {
                    return left.ContainsNode(value);
                }
            }
            else
            {
                if (right == null)
                {
                    return false;
                }
                else
                {
                    return right.ContainsNode(value);
                }
            }
        }

        public void PrintInOrder()
        {
            if (left != null)
            {
                left.PrintInOrder();
            }
            if (right != null)
            {
                right.PrintInOrder();
            }
            Console.Write(data + " ");
        }
    };
}
