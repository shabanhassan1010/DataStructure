using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Animal
    {
        public int ID { get; set; }
        public string  Name { get; set; }
        public virtual void print()
        {
            Console.WriteLine("Print from animal");
        }
    }
}
