using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class CustomQUEUE<T>
    {
        public Node<T> head;
        public void Enqueue(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine("{0} is inserted into the Queue ", head.data);
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                Console.WriteLine("{0} is inserted into the Queue ", newNode.data);
            }
        }
        
        // displaying of node.
        public void Display()
        {
            Console.WriteLine("QUEUE");
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Node<T> temp = head;
                Console.WriteLine("Elements in QUEUE are:  ");
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
