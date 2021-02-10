using System;
using System.Collections.Generic;

public class LinkedListExample
{
    public static void Main(string[] args)
    {
        // Create a list of strings  
        var names = new LinkedList<string>();
        names.AddLast("Sonu");
        names.AddLast("Monu");
        names.AddLast("Donu");
        names.AddLast("Irfan");
        names.AddFirst("John");  
        // Iterate list element using foreach loop  
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}
