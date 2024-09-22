using System.Numerics;

namespace DataStructure.How_To_Create_Generic_Class.Generic_Constraint
{
    public static class GenericConstraint
    {
        //public static int Add(int num1 , int num2)
        //{
        //    return num1 + num2;
        //}

        //public static int Add(int num1, double num2)
        //{
        //    return num1 + num2;
        //}

        //public static int Add(int num1, float num2)
        //{
        //    return num1 + num2;
        //}

        // Using Genrics
        public static T Add<T>(T num1, T num2) where T : INumber<T>
        {
            Console.WriteLine(num1 + num2);
            return num1 + num2;
        }
    }
}
