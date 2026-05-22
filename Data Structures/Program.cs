
namespace Data_Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedLists.LinkedList(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            linkedList.Print();

            var queue = new Queues.Queue(4);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Print();
        }
    }
}
