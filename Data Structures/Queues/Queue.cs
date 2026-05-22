namespace Data_Structures.Queues
{
    internal class Queue<T>(int size)
    {
        public T[] items = new T[size];
        public int front = 0;
        public int back = -1;

        public void Enqueue(T item)
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
    }
}
