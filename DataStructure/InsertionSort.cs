namespace DataStructure
{
    public  class InsertionSort
    {
        public static void InsertionSortAlgorithm(int[] array)
        {
            //int[] array = { 6, 4, 7, 3, 4, 5, 2, 8 };
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i]; //  array[i] = index 1 = 4
                int j = i - 1;  // j = index(1) - 1 = 0         >>>> j = index (0)
                while (j >= 0 && array[j] > key)
                // j = 0 and array[0] = 6 so is true 3shan el 6 > 4
                {
                    // Shift array[j] to array[j + 1]:
                    // array[1] = array[0] → array = { 6, 6, 7, 3, 4, 5, 2, 8 }
                    array[j + 1] = array[j];
                    // Decrement j: j = 0 - 1 = -1
                    // Since j < 0, exit the while loop.
                    j = j - 1;
                }
                // Place key in the correct position: 
                //  array[j + 1] = key → array[0] = 4 → array = { 4, 6, 7, 3, 4, 5, 2, 8 }
                array[j + 1] = key;
            }

        }
        public static void PrintArray(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }
    }
}
