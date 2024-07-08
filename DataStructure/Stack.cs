using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata;
using System.Collections;

namespace DataStructure
{
   public class Stack <T>
   {
        private T[] entries;
        private int top;
        private int maxSize;

        // Constructor to initialize the stack with a given size
        public Stack(int size)
        {
            // Sets the maximum size of the stack
            maxSize = size; 

            // Creates an array of type [T] to store the stack entries
            // [T] is a generic type, allowing the stack to store elements of any type.
            entries = new T[size];

            // The top variable is initialized to -1.his indicates that the stack is empty. In the context of the stack
            // top represents the index of the last added element
            top = -1; 
        }

        // This is a public method named Push which takes one parameter entry of type T.
        // [T] is a generic type parameter, meaning this method can handle any type of data specified when the stack is instantiated.
        // The Push method adds a new element (entry) to the top of the stack
        public  void Push(T entry)
        {
            // This line checks if the stack is full.
            // When top == maxSize - 1, it means the stack has reached its maximum capacity
            // (since arrays are zero-indexed, the last valid index is maxSize - 1).
            if (top == maxSize - 1)
            {
                //This exception indicates that you cannot push a new element onto the stack because there is no more space available.
                throw new InvalidOperationException("Stack is full");
            }
            // This line increments the top index by 1 using the ++ prefix operator (++top)
            // and then assigns the entry to the entries array at the new top position.
            entries[++top] = entry;
        }
        public bool IsEmpty()
        {
            return top == -1;
        }
        public  bool IsFull()
        {
            return top == maxSize - 1;
            //  return top !=  -1;

        }
        public  T Pop()
        {
            if (IsEmpty()) 
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return entries[top--];
        }
        public  T StackTop()
          // [T]:
         // This is the return type of the method, which specifies what type of value the method will return.
         // [T] is a placeholder for a generic type, meaning that the method can return a value of any type specified when the Stack class is instantiated.
         // For example, if T is int, then StackTop will return an int. If [T] is string, then StackTop will return a string.
        {
            if (!IsEmpty())
            {
                return entries[top]; // Return the element at the top
            }
            else 
            {
                throw new InvalidOperationException("Stack is empty. No top element.");
            }
        }
        public  int StackSize()
        {
            return maxSize;
        }
        public void ClearStack()
        {
            if (!IsFull())
            {
                throw new InvalidOperationException("Stack is empty. No elements Exists .");
            }
            else
            {
                top = -1;
                Console.WriteLine("Stack has been cleared Ya broo");
            }
        }
    }
}