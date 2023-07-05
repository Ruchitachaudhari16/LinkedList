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
            LinkedList_Node linkedListNode = new LinkedList_Node();
            while (true) 
            {
                Console.WriteLine("Choose the below options");
                Console.WriteLine("1:LinkedList Demo");
                Console.WriteLine("2:Stack Program");
                Console.WriteLine("3:Linked List Node");
                Console.WriteLine("4:Linked List in Reverse Order");
               Console.WriteLine("5:Remove FirstNode From LinkedList");
                Console.WriteLine("6:Remove Last Element from LinkedList");
                Console.WriteLine("7:Size Of Linked List");
                Console.WriteLine("8:Search for the Element");
                Console.WriteLine("9:Inserting data into a stack");
               
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
                        LinkedList_Node linkedListNodes = new LinkedList_Node();
                        linkedListNode.Add(4);
                        linkedListNode.Add(55);
                        linkedListNode.Add(100);
                        linkedListNode.Add(27);
                        linkedListNodes.Display();//Display Method from LinkedList_Node
                        Console.WriteLine("\n");
                        break;

                        case 4:
                        LinkedList_Node linkedListNodeOne = new LinkedList_Node();
                        linkedListNodeOne.Reverse_Order(33);
                        linkedListNodeOne.Reverse_Order(58);
                        linkedListNodeOne.Reverse_Order(99);
                        linkedListNodeOne.Display();
                        Console.WriteLine("\n");
                        break;

                        case 5:
                       linkedListNode.RemoveFirstNode();
                        linkedListNode.Display();
                        Console.WriteLine("\n");
                        break;

                        case 6:
                        linkedListNode.Remove_Last();
                        linkedListNode.Display();
                        Console.WriteLine("\n");
                        break;

                        case 7:
                        linkedListNode.SizeOfLinkedList();
                        linkedListNode.Display();
                        Console.WriteLine("\n");
                        break;

                        case 8:
                        int val=linkedListNode.Search(27);
                        Console.WriteLine(val);
                        Console.WriteLine("\n");
                        break;

                        case 9:
                            StackLinkedList stackLinkedList = new StackLinkedList();
                        stackLinkedList.Push(100);
                        stackLinkedList.Push(58);
                        stackLinkedList.Push(10);
                        stackLinkedList.Push(9);
                        stackLinkedList.Display();
                        stackLinkedList.Peek();
                        break;

                        



                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                        


                }
            }
           

            
        }
    }
}
