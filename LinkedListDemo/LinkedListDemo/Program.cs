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
            LinkedListD linkedListD = new LinkedListD();
            linkedListD.LinkedListMethod();

            Console.WriteLine("-------------------------------------------------------");
            Stack_Demo stack_Demo = new Stack_Demo();
            stack_Demo.Element();
            Console.ReadLine();
        }
    }
}
