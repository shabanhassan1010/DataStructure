namespace DataStructure
{
    public class Arr<T>
    {
        private T[] items;
        private int length;
        private int size;
        public Arr(int maxSize)
        {
            size = maxSize;
            items = new T[maxSize];
            length = 0;
        }
        public void Add(T item)
        {
            if (length >= size)
            {
                Console.WriteLine("Array is full.");
                return;
            }
            items[length++] = item;
        }
        public void Display()
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
        public int Search(T number)
        {
            if (size <= 0)
            {
                Console.WriteLine("Array is Empty");
                return -1;
            }
            else if (size > 0)
            {
                for (int i = 0; i < length; i++)
                {
                    if (items[i].Equals(number))
                    {
                        Console.WriteLine($"The Number {number} is at Index {i}.");
                        return i;
                        break;
                    }
                }
            }
            Console.Write($"The Number Not Found");
            return -1;
        }
        public void Insert(int index, T newItem)
        {
            if (index >= 0 && index <= length && length < size)

            {
                // Shift elements to the right to make space for the new item
                for (int i = length; i > index; i--)
                {
                    items[i] = items[i - 1];
                }
                items[index] = newItem;
                length++;
            }
            else
                Console.WriteLine("Out Of Range");
        }
        public void Delete(int index)
        {
            if (length >= 0 && index < length)
            {
                for (int i = index; i < length - 1; i++)
                {
                    items[i] = items[i + 1];
                }
                length--;
            }
            else
                Console.WriteLine("Index Out Of Range");
        }
        public int getLegth()
        {
            Console.WriteLine($"The length is: {length}");
            return length;
        }
        public int getSize()
        {
            Console.WriteLine($"The Size My Array is: {size}");
            return size;
        }
    }
}
