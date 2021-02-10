using System;
using System.Collections;

namespace Stack1
{
    class Program
    {
            static void Main(string[] args)
            {
            Stack st = new Stack();    // creating a stack variable.
                st.Push(1);            // pushing elements to the stack.
                st.Push(2);
                st.Push(3);

                foreach (Object obj in st)
                {
                    Console.WriteLine(obj);  // displaying stack elements.
                }
                Console.WriteLine(); Console.WriteLine();
                Console.WriteLine("The number of elements in the stack " + st.Count);
                Console.WriteLine("Does the stack contain the elements 3 " + st.Contains(3));
                Console.ReadKey();
            }
        }
    }
