﻿namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  Data Structure problems  *****");
            CustomLinkedList<int> list = new CustomLinkedList<int>();
            list.Add(48);
            list.Add(40);
            list.Add(102);
            list.Display();
        }
    }
}