using System;

namespace Constructor
{
    class User
    {
        public string name, location;
        public User()  // Default Constructor.
        {
            name = "sairam";
            location = "hyderabad";
        }
    }
    class program
    {
        static void Main(string[] args)   // Main Method.
        {
            User user = new User();       // Constructor will be called automatically once the instance of class is created.

            Console.WriteLine(user.name);

            Console.WriteLine(user.location);

            Console.WriteLine("\n Press Enter Key to Exit..");

            Console.ReadLine();

        }

    }

}

        
    
