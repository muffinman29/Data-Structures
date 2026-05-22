namespace Data_Structures.Queues
{
    public class Queue
    {
        public int[] items;
        public int front = 0;
        public int back = -1;

        public Queue(int size)
        {
            items = new int[size];
        }

        public void Enqueue(int item)
        {
            if (back == items.Length - 1)
            {
                Console.WriteLine("Queue is full");
                return;
            }
            back++;
            items[back] = item;
        }

        public void Dequeue()
        {
            if (front > back)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            front++;
        }

        public void Print()
        {
            for (int i = front; i <= back; i++)
            {
                Console.Write(items[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
