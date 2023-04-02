using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    // UC1- Using custom generic linked list.
    internal class CustomLinkedList<T>
    {
        public Node<T> head;
        public void Add(T data)
        {
            Node<T> newnode = new Node<T>(data);
            if (head == null)
            {
                head = newnode;
                Console.WriteLine("{0} inserted into the LinkedList", head.data);
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newnode;
                Console.WriteLine("{0} inserted into Linked List", newnode.data);
            }

        }

        // displaying of insertion element.
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            Node<T> temp = this.head;
            Console.WriteLine("\nElements in linked list are:  ");
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
