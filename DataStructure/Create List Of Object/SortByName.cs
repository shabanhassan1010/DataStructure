using DataStructure.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Create_List_Of_Object
{
    public class SortByName : IComparer<Employee>
    {
        // Implementing the Compare method from IComparer<T>
        public int Compare(Employee x, Employee y)
        {
            // Null checks to handle potential null values
            if (x == null && y == null)
                return 0;
            if (x == null) 
                return -1;
            if (y == null) 
                return 1;

            // Compare FullName properties
            return x.FullName.CompareTo(y.FullName);
        }
    }
}
