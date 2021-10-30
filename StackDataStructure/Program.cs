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
            stack.Peek();
            stack.Pop();
            Console.WriteLine("after the pop list is");
            stack.display();
            stack.IsEmpty();



            /*stack.push(50);
            stack.push(30);
            stack.push(70);
            Console.WriteLine("the stack list is:");
            stack.display();*/
        }
    }
}
