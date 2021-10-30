using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackDataStructure
{
    class StackOperations
    {
        public Node top;
        
        /// <summary>
        /// Pushes the specified data.
        /// using linkedlist method insertfirst
        /// </summary>
        /// <param name="data">The data.</param>
        public void push(int data)
        {
            //linkedList.InsertLast(data);
            Node newNode = new Node(data);
            if (this.top != null)
            {
                newNode.next = this.top;
            }
            this.top = newNode;
            Console.WriteLine("the value inserted," + newNode.data);
        }
        /// <summary>
        /// Displays this stack values.
        /// </summary>
        public void display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("empty");
            }
            while (temp != null)
            {
                Console.WriteLine("value is inserted " + temp.data);
                temp = temp.next;
            }
        }



    }
}
