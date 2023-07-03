using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("Choose the below options");
                Console.WriteLine("1:LinkedList Demo");
                Console.WriteLine("2:Stack Program");
                Console.WriteLine("3:Linked List Node");
                int choice=Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //Linked List using inbuilt class.
                        LinkedListD linkedListD = new LinkedListD();
                        linkedListD.LinkedListMethod();
                        break;

                        case 2:
                        //Stack
                        Stack_Demo stack_Demo = new Stack_Demo();
                        stack_Demo.Element();
                        break;

                        case 3:
                        //Linked list using user Defined.
                        LinkedList_Node linkedListNode = new LinkedList_Node();
                        linkedListNode.Add(4);
                        linkedListNode.Add(55);
                        linkedListNode.Add(100);
                        linkedListNode.Add(27);

                        linkedListNode.Display();//Display Method from LinkedList_Node

                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                        


                }
            }
           

            
        }
    }
}
