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
                Console.WriteLine("Popped item is " +tail.Data);
                head = null;
            }
            head = head.next;
        }
    }


    /*Enqueue:

    Description: Adds an element to the back of the queue.
    Method: enqueue(element)
    Example: queue.enqueue(5)
    Dequeue:

    Description: Removes and returns the element from the front of the queue.
    Method: dequeue()
    Example: queue.dequeue()
    Front (or Peek):

    Description: Returns the element at the front of the queue without removing it.
    Method: front()
    Example: queue.front()
    IsEmpty:

    Description: Checks if the queue is empty.
    Method: isEmpty()
    Example: queue.isEmpty()
    Size:

    Description: Returns the number of elements in the queue.
    Method: size()
    Example: queue.size()*/
}
