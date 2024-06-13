
namespace DataStructure
{
    public class Program
    {
        static void Main()
        {
            #region Factorial Numbers

            //Console.WriteLine("Enter your number: ");
            //int input = int.Parse(Console.ReadLine());
            //int result = FactorialNumbers.NonFactorialFunction(input);
            //Console.WriteLine($"The factorial of {input} is {result}");


            //Console.WriteLine("Enter your number: ");
            //int number = int.Parse(Console.ReadLine());
            //int result2 = FactorialNumbers.FactorialRecursive(number);
            //Console.WriteLine($"The factorial of {number} is {result}");


            //string path = @"D:\programing"; // Replace with your directory path

            //Console.WriteLine($"Displaying folder structure for '{path}':");
            //FactorialNumbers.DisplayFolder(path, 0); // Start with indentation level 0
            #endregion

            #region Calling Insertion Sort 

            //int[] array = { 12, 11, 13, 5, 6 };

            //Console.WriteLine("Original array:");
            //InsertionSort.PrintArray(array);

            //InsertionSort.InsertionSortAlgorithm(array);

            //Console.WriteLine("Sorted array:");
            //InsertionSort.PrintArray(array);

            #endregion

            #region Calling Extension Method

            // Example Number(1)

            //Console.WriteLine("Enter Num:   ");
            //int num = int.Parse(Console.ReadLine());

            //if (num.IsBetween(10, 100))
            //    Console.WriteLine("Num Is Valid");
            //else
            //{
            //    Console.WriteLine("Num Is Not Valid");
            //}

            ////Example Number(2)

            //Console.WriteLine("Enter Word:   ");
            //string Word = Console.ReadLine()!;
            //Console.WriteLine(Word.ReverseString());
            //Console.WriteLine(Word.RemoveSpaces());
            //Console.WriteLine(Word.ReverseString().RemoveSpaces());

            ////Example Number(3)

            //Console.WriteLine("Enter Value:   ");
            //string input = Console.ReadLine();

            //if (input.IsNumber())
            //    Console.WriteLine($"Input Is a Number {input}");
            //else
            //    Console.WriteLine($"Input Is not a Number ");

            //// Example Number(4)

            //Console.WriteLine("Enter Num:   ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine(number.IsGreaterThan(100));

            // Example Number(5)

            //string text = "shaban";
            //Console.WriteLine(text.IsNumber());

            //// Example Number(6)

            //Console.WriteLine("Enter statment:   ");
            //string statment = Console.ReadLine();
            //Console.WriteLine(statment.CountWordCustome());
            //Console.WriteLine(statment.Length);

            #endregion


            Animal n = new Animal(); // animal
            n.print();
            Animal d = new Dog(); // animal
            d.print();
            Animal C = new Cat(); // cat
            d.print();

        }
    }
}