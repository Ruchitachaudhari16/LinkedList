using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class LinkedList_Node
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
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("List is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }

        //Print data in Reverse Order.
        //When u are inserting a value in a node ,then head is null.
        public void Reverse_Order(int data)
        {
            Node node = new Node(data);
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
        //Remove the first element from the Node.
        public void RemoveFirstNode()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            head = head.next;
            Console.WriteLine("First element is Deleted Successfully");
        }

        //Remove the Last Element from Linked List 
        public void Remove_Last()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            if (head.next == null)
            {
                Console.WriteLine("The next element of head is null");
            }
            else
            {
                Node temp = head;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
                Console.WriteLine("Removed Last Element");

            }
        }

        public void SizeOfLinkedList()
        {
            int count = 1;
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            Node temp = head;
            while (temp.next != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine("Size of Linked list is " + count);

        }
        //Search for element which is present in linkedList or Not
        public int Search(int value)
        {
            Node node = head;
            if (node == null)
            {
                return -1;
            }
            int count = 1;
            while (node != null)
            {
                if (node.data == value)
                {
                    Console.WriteLine();
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;
        }
    }
}

