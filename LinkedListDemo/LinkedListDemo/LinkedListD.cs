using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class LinkedListD
    {

        public void LinkedListMethod()
        {
            //inbuilt linked list class.
            LinkedList<int> list = new LinkedList<int>(); //in inbuilt class of linkedList we can use generics.
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);
            list.AddFirst(9);
            foreach (int i in list)
            {
                Console.WriteLine("Elements in LinkedList are:");
                Console.WriteLine(i);


            }
            Console.WriteLine("Remove the element from the list" + list.Remove(9));
            foreach (int i in list)
            {
                Console.WriteLine("Elements from the list are:"+i);
            }

            Console.WriteLine("Removed a element from list");
            list.Remove(list.Last);
            foreach (int i in list)
                {
                Console.WriteLine("Elements in list are:"+i);
            }

            list.Clear();
            foreach (int i in list)
            {
                Console.WriteLine("Deleted elements from list are:" + i);
            }
            Console.WriteLine("Count After Deleting the elements:"+list.Count);

        }
    }
}
