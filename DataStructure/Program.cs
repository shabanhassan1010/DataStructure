﻿using DataStructure.Create_List_Of_Object;
using DataStructure.NewFolder;

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

            #region Calling Stack

            //Stack<int> stack = new Stack<int>(3);

            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30); // top so he is the last element

            //Console.WriteLine(stack.Pop()); // 30
            //Console.WriteLine(stack.Pop()); // 20
            //Console.WriteLine(stack.Pop()); // 10

            #endregion

            #region GenericList

            //genericList generic = new genericList();
            //generic.AddString("a");
            //generic.AddString("b");
            //generic.Iterate();
            //Console.WriteLine(generic.FindIndexOfString("a"));

            #endregion

            #region Create List Of Object

            CreateListOfObject empolyee1 = new CreateListOfObject();
            empolyee1.EmployeeNo = 1;
            empolyee1.FullName = "Shaban";
            empolyee1.StartSalary = 200000;
            empolyee1.WorkingHoursPerWeek = 20;
            empolyee1.Contract = ContractType.FullTime;
            CreateListOfObject empolyee2 = new CreateListOfObject();
            empolyee2.EmployeeNo = 2;
            empolyee2.FullName = "Ali";
            empolyee2.StartSalary = 14000;
            empolyee2.WorkingHoursPerWeek = 40;
            empolyee2.Contract = ContractType.PartTime;
            //  Create List from Instance(My Class)
            List<CreateListOfObject> EmployeeList = new List<CreateListOfObject>();
            // Now I can Add Item on My List
            EmployeeList.Add(empolyee1);
            EmployeeList.Add(empolyee2);
            // I can Add in List without i don't have Any instance  
            // but Must Create paramterize constructor
            //EmployeeList.Add(new CreateListOfObject());     // now he is empty so i Must Full it
            EmployeeList.Add(new CreateListOfObject(3, "Mohamed" , 15000 , 30 , ContractType.Freelance));

            foreach (CreateListOfObject emp in EmployeeList)
            {
                Console.WriteLine($" EmployeeNo:{emp.EmployeeNo}\n FullName:{emp.FullName}\n StartSalary:{emp.StartSalary}\n WorkingHoursPerWeek:{emp.WorkingHoursPerWeek}\n Contract:{emp.Contract}\n ");
                Console.WriteLine();
            }
            EmployeeList.Sort(); // so Must I mplement interface called Icomparable in my class
            SortByName sortByName = new SortByName();
            EmployeeList.Sort(sortByName);
            #endregion


        }
    }
}