namespace DataStructure
{
    public class Class2 : Class1
    {
        public int Salary { get; set; }
        public string Addres { get; set; }
        public Class2(int salary, string address)
        {
            Addres = address;
            Salary = salary;

        }
    }
}
