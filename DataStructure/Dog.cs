using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Dog : Animal
    {
        public new void print()
        {
            Console.WriteLine("Print from Dog");
        }
    }
}
