namespace DataStructure.How_To_Create_Generic_Class
{
    public class GenericList<T>
    // public class GenericList<T1 , T2>              In This Case I Will take two data type 
    {
        private readonly List<T> _items = new List<T>();
        public void Add(T item)
        {
            _items.Add(item);
        }
        public void Remove(T item)
        {
            _items.Remove(item);
        }
        public void display()
        {
            foreach (var item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
