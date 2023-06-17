namespace QueueUsingLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();    
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Display();
            Console.WriteLine();
            queue.dequeue();
            queue.Display();
            Console.WriteLine();
            queue.size();
            Console.WriteLine();
            Console.WriteLine("Element to be deleted is ");
            queue.front();
        }
    }
}