﻿using System;

namespace double_linked_list
{
    class Node
    {
        /*Node class represent the node of dpubly linked list
         *It consist of the information part and links to
         *Its succeding and preeceding
         *In terms of next and previous */
        public int noMhs;
        public string name;
        //point to the succeding node
        public Node next;
        //point to the preceding node
        public Node prev;
    }
    class DoubleLinkedList
    {
        Node START;

        //constructor

        public void addNode()
        {
            int nim;
            string nm;
            Console.WriteLine("\n Enter the roll number of the stuent :");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Enter the name of student: ");
            nm =  Console.ReadLine();
            Node newNode = new Node();
            newNode.noMhs = nim;
            newNode.name = nm;

            //check if the list empty
            if (START == null || nim <= START.noMhs)
            {
                if ((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\n Duplicate number not allowed");
                    return;
                }
                newNode.next = START;
                if(START != null)
                    START.next = newNode;
                newNode.next = null;
                START = newNode;
                return;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}