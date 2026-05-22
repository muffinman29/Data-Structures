using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures.Trees
{
    internal class Tree<T>
    {
        private class Node(T value)
        {
            public T Value { get; set; } = value;
            public Node? Left { get; set; } = null;
            public Node? Right { get; set; } = null;
        }

        private Node? root;

        public Tree()
        {
            root = null;
        }

        public Tree(T value)
        {
            root = new Node(value);
        }

        public void Add(T value)
        {
            Node newNode = new(value);
            if (root == null)
            {
                root = newNode;
                return;
            }
            Queue<Node> queue = new();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                Node current = queue.Dequeue();
                if (current.Left == null)
                {
                    current.Left = newNode;
                    return;
                }
                else
                {
                    queue.Enqueue(current.Left);
                }
                if (current.Right == null)
                {
                    current.Right = newNode;
                    return;
                }
                else
                {
                    queue.Enqueue(current.Right);
                }
            }
        }

        public void Print()
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            Queue<Node> queue = new();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                Node current = queue.Dequeue();
                Console.Write(current.Value + " ");
                if (current.Left != null)
                {
                    queue.Enqueue(current.Left);
                }
                if (current.Right != null)
                {
                    queue.Enqueue(current.Right);
                }
            }
            Console.WriteLine();
        }
    }
}