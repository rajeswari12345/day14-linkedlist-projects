﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresDemo
{
    internal class linked_list_add
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data)
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = head;
            }
            Console.WriteLine("{0} inserted into linkedlist()", Node.data);
        }
        //-----------uc2------//
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
        //---------uc4----------//
        internal Node InsertParticularPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid Position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode = this.head;
                head = newNode;
                else
                {
                    while (position-- != 0)
                    {
                        if (position == 1)
                        {
                            Node node = new Node(data);
                            node.next = this.head.next;
                            head.next = node;
                            break;
                        }

                        head = head.next;
                    }
                    if (position != 1)
                        Console.WriteLine("position out of range");


                }
                Console.WriteLine("Inserted value is : +head");
                return head;
            }

        }

    }
}



