// See https://aka.ms/new-console-template for more information
using System;
namespace DataStructuresDemo
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HelloWorld!");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);

            //----uc2---//
            list.Display();

            //---------------uc4----------//
            list.insertparticularPosition(2, 30);
        }
    }
}
