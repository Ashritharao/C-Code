using System;
using System.Collections.Generic;

public class ListExample
{
    public static void Main(string[] args)
    {
        // Create a list of strings using collection initializer  
        var names = new List<string>() { "xyz", "abc", "def", "pqr" };

        // Iterate through the list.  
        foreach (var name in names)
        {
            Console.WriteLine(name); 
        }
    }
}
