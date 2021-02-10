using System;
using System.Collections;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)  // Main Method.
        {
            Queue qt = new Queue();    // creating a queue variable.
            qt.Enqueue(1);             // adding elements to the queue.
            qt.Enqueue(2);
            qt.Enqueue(3);
            foreach (Object obj in qt)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();
        }
    }
}
