using System;

namespace StackDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StackOperations stack = new StackOperations();
            stack.push(50);
            stack.push(30);
            stack.push(70);
            Console.WriteLine("the stack list is:");
            stack.display();
        }
    }
}
