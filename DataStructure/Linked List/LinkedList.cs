namespace DataStructure.Linked_List
{
    public class linkedlist
    {
        public Node head; // head he will refer on Node so it sort is Node
        public linkedlist()
        {
            head = null;
        }
        public bool IsEmpty()
        {
            return head == null;
        }
        public void InsertFirst(int data)
        {
            Node newNode = new Node(data); // parameterized Constructor in Node Class
            if (IsEmpty())
            {
                newNode.Next = null;
                head = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }
        }
        public void InsertLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
                head = newNode;
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty.");
                return;
            }
            Node Temp = head;   // now Temp and head pointer on first Node
            while (Temp != null)
            {
                Console.Write(Temp.Data + " -> ");
                Temp = Temp.Next;
            }
            Console.WriteLine("null");
        }
        public int count()
        {
            int counter = 0;
            Node Temp = head;
            while (Temp != null)
            {
                counter++;
                Temp = Temp.Next;
            }
            return counter;
        }
        public bool IsFound(int Item)
        {
            Node Temp = head;
            while (Temp != null)
            {
                if (Temp.Data == Item)
                    return true;
                Temp = Temp.Next;
            }
            return false;
        }
    }
}
