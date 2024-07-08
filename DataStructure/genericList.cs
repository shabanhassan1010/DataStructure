using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class genericList
    {
        // Creating List
        List<string> Names = new List<string>();  // Empty List
        // List<int> numbers = new List<int>() {1 , 2 , 4 , 5, 7 }; // full list

        // Method to add a string to the list
        public void AddString(string name)
        {
            Names.Add(name);
        }

        // Accessing By Index
        public int FindIndexOfString(string name)
        {
            return Names.IndexOf(name);
        }
        // Iterate Through List
        public void Iterate()
        {
            if (Names.Count == 0)  // check if my arr full or empty
            {
                Console.WriteLine("The names list is empty.");
                return;
            }
            foreach (var name in Names)
            {
                Console.WriteLine(name);
            }
        }
        public static void Display(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static void Display(string[] list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
