using System;
using System.Collections; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class Stack_Demo
    {
        public void Element()
        {
            Stack stack = new Stack();
            stack.Push("Ruchita");
            stack.Push("Chaudhari");
            stack.Push(12345);
            stack.Push("Aabha");
            foreach (var item in stack)
            {
                Console.WriteLine("Elements in stack:"+item);
            }
            //Count the number of elememts in a stack.
            Console.WriteLine("Stack count is:"+stack.Count);

            //It will check wheather the stack contains the Particular element.
            Console.WriteLine(stack.Contains(12345));
            Console.WriteLine(stack.Peek());// It will show us top element 
            foreach (var item in stack)
            {
                Console.WriteLine("Elements in stack:" + item);
            }
            
            Console.WriteLine("Remove the top element:"+stack.Pop());
            foreach (var item in stack)
            {
                Console.WriteLine("Elements in stack:" + item);
            }
        }

    }
}