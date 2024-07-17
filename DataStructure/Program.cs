using DataStructure.Create_List_Of_Object;
using DataStructure.NewFolder;
using System.Diagnostics;
using static DataStructure.ENUMSSS;

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

            //Stack<int> stack = new Stack<int>(10);

            //stack.PUSH(10);
            //stack.PUSH(20);
            //stack.PUSH(30);
            //stack.PUSH(40);
            //stack.PUSH(50); // top so he is the last element

            //Console.WriteLine($"Stack Top:   {stack.StackTop()}"); // 50
            //Console.WriteLine($"Stack Full:  {stack.IsFull()}");
            //Console.WriteLine($"Stack Empty: {stack.IsEmpty()}"); // false
            //Console.WriteLine($"Stack Size:  {stack.StackSize()}");

            //stack.ClearStack();
            //Console.WriteLine($"Stack Empty:  {stack.IsEmpty()}"); // true

            //Console.WriteLine();

            //Console.WriteLine(stack.POP()); // 10
            //Console.WriteLine(stack.POP()); // 20
            //Console.WriteLine(stack.POP()); // 30
            //Console.WriteLine(stack.POP()); // 40
            //Console.WriteLine(stack.POP()); // 50


            #endregion

            #region GenericList

            //genericList generic = new genericList();
            //generic.AddString("a");
            //generic.AddString("b");
            //generic.Iterate();
            //Console.WriteLine(generic.FindIndexOfString("a"));

            #endregion

            #region Create List Of Object

            //Employee empolyee1 = new Employee();
            //empolyee1.EmployeeNo = 1;
            //empolyee1.FullName = "Shaban";
            //empolyee1.StartSalary = 200000;
            //empolyee1.WorkingHoursPerWeek = 20;
            //empolyee1.Contract = ContractType.FullTime;

            //Employee empolyee2 = new Employee();
            //empolyee2.EmployeeNo = 2;
            //empolyee2.FullName = "Ali";
            //empolyee2.StartSalary = 14000;
            //empolyee2.WorkingHoursPerWeek = 40;
            //empolyee2.Contract = ContractType.PartTime;

            ////  Create List from Instance(My Class)
            //List<Employee> EmployeeList = new List<Employee>();
            //// Now I can Add Item on My List
            //EmployeeList.Add(empolyee1);
            //EmployeeList.Add(empolyee2);

            // I can Add in List without i don't have Any instance  
            // but Must Create paramterize constructor
            // EmployeeList.Add(new CreateListOfObject());     // now he is empty so i Must Full it
            //EmployeeList.Add(new Employee(3, "Mohamed", 15000, 30, ContractType.Freelance));
            //EmployeeList.Add(new Employee(4, "Mostafa", 20000, 40, ContractType.FullTime));

            //SortByName sortByName = new SortByName();
            //EmployeeList.Sort(sortByName);
            //foreach (Employee emp in EmployeeList)
            //{
            //    Console.WriteLine($" EmployeeNo:{emp.EmployeeNo}\n FullName:{emp.FullName}\n StartSalary:{emp.StartSalary}\n WorkingHoursPerWeek:{emp.WorkingHoursPerWeek}\n Contract:{emp.Contract}\n ");
            //    Console.WriteLine();
            //}
            //EmployeeList.Sort(); // so Must I mplement interface called Icomparable in my class

            #endregion

            #region Difference between Array , List

            //// Array
            //int size = 10000000;
            //int[] array = new int[size];
            //int number;

            //for(int i = 0; i< array.Length; i++)
            //{
            //    array[i] = i;
            //}

            //Stopwatch sw = new Stopwatch();
            //sw.Start();

            //for (int i = 0; i< array.Length; i++)
            //{
            //    number = array[i];
            //}
            //sw.Stop();
            //Console.WriteLine($"Array Access time: {sw.ElapsedMilliseconds}"); // 227

            //// List
            //List<int> list = new List<int>();
            //int item;

            //for (int i = 0; i < size; i++)
            //{
            //    list.Add(i);
            //}

            //sw.Start();

            //for (int i = 0; i < list.Count; i++)
            //{
            //    item = list[i];
            //}
            //sw.Stop();
            //Console.WriteLine($"List Access time: {sw.ElapsedMilliseconds}"); // 925

            #endregion

            #region How to Convert Enum into List

            //var list = Enum.GetValues(typeof(languages)).Cast<languages>().ToList();
            //// another Solution 
            //var list2 = (Enum.GetValues(typeof(languages)) as IEnumerable<languages>).ToList();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Monotonic_Increasing_Stack

            Monotonic_Increasing_Stack mo = new Monotonic_Increasing_Stack();

            List<int> nums = new List<int> { 1 , 2 ,3 , 4, 5 ,7 ,5 ,8 ,9,8}; // 1 2 3 4 5 5 8 8 
            List<int> result = mo.Monotonic(nums);
            foreach (var item in result)
            {
                Console.Write($"{item}\t");
            }
            #endregion
        }
    }
}