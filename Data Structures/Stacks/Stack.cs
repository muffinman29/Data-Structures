namespace Data_Structures.Stacks
{
    internal class Stack(int size)
    {
        public int[] items = new int[size];
        public int top = -1;

        public void Push(int item)
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

        public int Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return -1; // Return -1 to indicate stack is empty
            }
            return items[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == items.Length - 1;
        }

        public int Size()
        {
            return top + 1;
        }

        public void Clear()
        {
            top = -1;
        }

        public int Top()
        {
            return top;
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
