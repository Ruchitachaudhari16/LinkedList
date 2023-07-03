using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public  class LinkedList_Node
    {
        public Node head;//Node is class 
        public void Add(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }

            Console.WriteLine(node.data);
        }
        //Display method to print the LinkedList Data.
            public void Display()
            {
            Node temp= head;
            if (temp == null)
            {
                Console.WriteLine("List is Empty");
            }
            while (temp!=null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

        //Print data in Reverse Order.
        //When u are inserting a value in a node ,then head is null.
        public void Reverse_Order(int data)
        {
            Node node=new Node(data);
            if (head == null)
            {
                head = node;

            }
            else 
            {
                Node temp = head;
                head = node;
                head.next = temp;
            }
            
        }
        public void RemoveFirstNode()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            head=head.next;
            Console.WriteLine("First element is Deleted Successfully");
        }
        }
    }

