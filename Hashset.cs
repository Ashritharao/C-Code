using System;
using System.Collections.Generic;

public class HashSetExample
{
    public static void Main (string[] args)
    {
        // Create a set of strings  
        var names = new HashSet<string>();
        names.Add("mom");
        names.Add("dad");
        names.Add("bro");
        names.Add("sis");
        names.Add("rheo");  
       // Iterate HashSet elements using foreach loop  
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}  
