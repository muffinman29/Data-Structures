using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Data_Structures.Common;

namespace Data_Structures.LinkedLists.Example
{
    public class LinkedList<T>
    {
        private Node<T>? head;

        public LinkedList()
        {
            head = null;
        }

        public LinkedList(T value)
        {
            head = new Node<T>(value);
        }

        public void Add(T value)
        {
            if (head == null)
            {
                head = new Node<T>(value);
                return;
            }
            Node<T> current = head!; // head is non-null here because of the check above
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new Node<T>(value)
            {
                Previous = current
            };
        }

        public void Print()
        {
            Node<T>? current = head;
            while (current != null)
            {
                Console.Write("Current: " + current.Value + " ");
                if (current.Previous != null)
                {
                    Console.Write("Prev: " + current.Previous.Value + " ");
                }
                Console.WriteLine();
                current = current.Next;
            }
            Console.WriteLine();
        }

        public void GoBack()
        {
            Node<T>? current = head;
            Node<T>? tail = current;
            //  Traverse to the end of the list
            while (current != null)
            {
                tail = current;
                current = current.Next;
            }
            var previous = tail.Previous;
            Console.WriteLine("Go backwards one page: " + previous.Value);
        }

        public void GoForward()
        {
            Node<T>? current = head;
            Node<T>? tail = current;
            //  Traverse to the end of the list
            while (current.Next != null)
            {
                tail = current;
                current = current.Next;
            }
            var next = tail.Next;
            Console.WriteLine("Go forward one page: " + next.Value);
        }
    }
}
