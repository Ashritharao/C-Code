using System;

interface Animal
{

    // Animal interface
    class Pig : Animal      // Class implements interface
    {
        public void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Program
    {
        public static void Main(string[] args)     // Main Method
        {
            Pig myPig = new Pig();                // Create a object
            myPig.animalSound();
        }
    }
}