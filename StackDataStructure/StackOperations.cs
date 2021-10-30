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
        /// Peeks the top most element.
        /// </summary>
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("no elements present to peek");

            }
            Console.WriteLine("top most element" + this.top.data);
        }

        /// <summary>
        /// Pops the top most element
        /// means deleting the element.
        /// </summary>
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("no elements present to pop");
                return;
            }
            int deleteNode = this.top.data;
            Peek();
            this.top = this.top.next;
            Console.WriteLine("deleted element is{0}", deleteNode);

        }
        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmpty()
        {
            while (this.top != null)
            {
                Pop();
            }
            if (this.top == null)
                return true;

            else
                return false;
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
