using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures.LinkedLists
{
    public class LinkedList
    {
        private class Node {
            public int Value { get; set; }
            public Node? Next { get; set; }

            public Node(int value)
            {
                Value = value;
                Next = null;
            }
        }

        private Node? head;

        public LinkedList()
        {
            head = null;
        }

        public LinkedList(int value)
        {
            head = new Node(value);
        }

        public void Add(int value)
        {
            if (head == null)
            {
                head = new Node(value);
                return;
            }
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new Node(value);
        }

        public void Print()
        {
            Node? current = head;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
