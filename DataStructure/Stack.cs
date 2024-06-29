namespace DataStructure
{
   public class Stack<T>
   {
        private T[] entries;
        private int top;
        private int maxSize;

        public Stack(int size)
        {
            maxSize = size;
            entries = new T[size];
            top = -1; // Initialize top to -1 to represent an empty stack
        }

        public void Push(T entry)
        {
            if (top == maxSize - 1)
            {
                throw new InvalidOperationException("Stack is full");
            }

            entries[++top] = entry;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == maxSize - 1;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return entries[top--];
        }
   }
}

