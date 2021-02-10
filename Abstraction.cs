using System;

namespace Abstraction
{
    class Program      // declaring a Parent class
    {
        abstract class animal
        {
            public abstract void eat();
            public void sound()
            {
                Console.WriteLine("cat can sound");
            }
        }
        class dog : animal   // declaring a child class
        {
            public override void eat()
            {
                Console.WriteLine("cat can eat");
            }
        }
        static void Main(string[] args)
        {
            dog mydog = new dog();
            animal thePet = mydog;
            thePet.eat();
            mydog.sound();
        }
    }
}