using Data_Structures.Common;

namespace Data_Structures.LinkedLists.Example
{
    public class LinkedList<T> : INavigation, IPrintable
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
            Node<T> current = head; // head is non-null here because of the check above
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new Node<T>(value);
        }

        public void Print()
        {
            Node<T>? current = head;
            while (current != null)
            {
                Console.WriteLine("Current: " + current.Value);
                current = current.Next;
            }
            Console.WriteLine();
        }

        public void GoBack()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            if (head.Next == null)
            {
                Console.WriteLine("List has only one node; no previous node");
                return;
            }

            Node<T> current = head;
            Node<T>? previous = null;
            // Traverse to the end of the list, keeping track of the node before the last
            while (current.Next != null)
            {
                previous = current;
                current = current.Next;
            }
            Console.WriteLine("Go backwards one: " + previous!.Value);
        }

        public void GoForward()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            if (head.Next == null)
            {
                Console.WriteLine("No next node to go forward to");
                return;
            }

            Console.WriteLine("Go forward one: " + head.Next.Value);
        }
    }
}
