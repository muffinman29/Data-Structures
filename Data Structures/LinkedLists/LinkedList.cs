using Data_Structures.Common;

namespace Data_Structures.LinkedLists
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
            Node<T> newNode = new Node<T>(value);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void Print()
        {
            Node<T>? current = head;
            while (current != null)
            {
                Console.Write($"{current.Value} -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}
