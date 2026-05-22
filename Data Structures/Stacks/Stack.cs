namespace Data_Structures.Stacks
{
    internal class Stack<T>(int size)
    {
        public T[] items = new T[size];
        public int top = -1;

        public void Push(T item)
        {
            if (top == items.Length - 1)
            {
                Console.WriteLine("Stack is full");
                return;
            }
            top++;
            items[top] = item;
        }

        public void Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            top--;
        }

        public void Print()
        {
            for (int i = top; i >= 0; i--)
            {
                Console.Write(items[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
