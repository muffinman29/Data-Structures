using Data_Structures.LinkedLists.Example;
using System.Xml.Linq;

namespace Data_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List.");
            var history = new History
            {
                Id = 1,
                Url = "https://www.google.com"
            };
            var linkedList = new LinkedLists.Example.LinkedList<History>(history);
            var history2 = new History
            {
                Id = 2,
                Url = "https://www.github.com"
            };
            linkedList.Add(history2);
            var history3 = new History
            {
                Id = 3,
                Url = "https://www.stackoverflow.com"
            };
            linkedList.Add(history3);
            var history4 = new History
            {
                Id = 4,
                Url = "https://www.microsoft.com"
            };
            linkedList.Add(history4);
            linkedList.Print();
            linkedList.GoBack();
            linkedList.GoForward();

            Console.WriteLine("Queue.");
            var queue = new Queues.LinkedListQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Print();

            Console.WriteLine("Stack.");
            var stack = new Stacks.LinkedListStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Print();
        }       
    }
}
