using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingLinkedList
{
    internal class Queue<T>
    {
        Node<T> head;
        Node<T> tail;
        public void Enqueue(T Data)
        {

            Node<T> node = new Node<T>(Data);
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                node.next = head;
                head = node;
            }
        }

        public void Display()
        {
            Node<T> temp = head;
            while (temp != null)
            {
                Console.Write(temp.Data + " -> ");
                temp = temp.next;
            }
        }

        public void dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("The Queue is empty!!!");
            }
            if (head == tail)
            {
                Console.WriteLine("Popped item is " + tail.Data);
                head = null;
            }
            head = head.next;
        }

        public void size()
        {
            Node<T> temp = head;
            int count = 0;
            if (head == null)
            {
                Console.WriteLine("Empty queue");
            }
            else
            {
                while (temp != null)
                {
                    count++;
                    temp = temp.next;
                }
            }
            Console.WriteLine("Size of the queue is" + count);
        }

        public Boolean isempty()
        {
            if(head != null)
                return true;

            return false;
        }

        public void front()
        {
            Console.WriteLine(head.Data);
        }
    }



}
