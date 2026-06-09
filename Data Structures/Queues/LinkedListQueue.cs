using Data_Structures.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures.Queues
{
    public class LinkedListQueue<T> : IPrintable
    {
        private Node<T>? _head;

        public void Enqueue(T item)
        {
            if (_head == null)
            {
                _head = new Node<T>(item);
                return;
            }
            Node<T> current = _head; // _head is non-null here because of the check above
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new Node<T>(item);
        }

        public T Dequeue()
        {
            if (_head == null)
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            var value = _head.Value;
            _head = _head.Next;

            return value;
        }

        public T Peek()
        {
            if (_head == null)
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            return _head.Value;
        }

        public void Print()
        {
            while (!IsEmpty())
            {
                Console.WriteLine(Dequeue());
            }
        }

        public bool IsEmpty() => _head == null;
    }
}
