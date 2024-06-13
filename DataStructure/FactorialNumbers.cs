using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class FactorialNumbers
    {
        // Non Recursive Way
        public static int NonFactorialFunction(int x)
        {
            if (x < 0)
                throw new ArgumentException("Factorial is not defined for negative numbers");

            int factorial = 1;
            for (int i = x; i > 0; i--)
            {
                factorial = factorial * i;
                Console.WriteLine(factorial);
            }
            return factorial;
        }

        //// Anathor Solution For Recursive Way
        //public static int Factorial(int x)
        //{
        //    if (x < 0)
        //        throw new ArgumentException("Factorial is not defined for negative numbers");
        //    int factorial = 1;
        //    for (int i = 1; i <= x; i++)
        //    {
        //        factorial = factorial * i;
        //        Console.WriteLine($"Intermediate factorial for {i}: {factorial}");
        //    }
        //    return factorial;
        //}

        //  Recursive Way

        public static int FactorialRecursive(int number)
        {
            if (number == 0)
                return 1;
            return number * FactorialRecursive(number - 1);
        }

        public static void DisplayFolder(string path , int indent)
        {
            foreach (var folder in Directory.GetDirectories(path))
            {
                Console.WriteLine($"{new string(' ', indent)} {Path.GetFileName(folder)}");
                DisplayFolder(folder, indent + 1);
            }
        }
    }
}
