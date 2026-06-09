using System;
using System.Collections.Generic;
using System.Text;
using Data_Structures.Common;

namespace Data_Structures.Stacks
{
    public class LinkedListStack<T> : IPrintable
    {
        private Node<T>? _head;

        public void Push(T item)
        {
            var newNode = new Node<T>(item)
            {
                Next = _head
            };
            _head = newNode;
        }

        public T Pop()
        {
            if (_head == null)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            var value = _head.Value;
            _head = _head.Next;
            
            return value;
        }

        public T Peek()
        {
            if (_head == null)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return _head.Value;
        }

        public void Print()
        {
            while(!IsEmpty())
            {
                Console.WriteLine(Pop());
            }
        }

        public bool IsEmpty() => _head == null;
    }
}
