using System;
using System.Collections.Generic;

public class SortedSetExample
{
    public static void Main(string[] args)   //Main Method
    {
        // Create a set of strings  
        var names = new SortedSet<string>();
        names.Add("ashu");
        names.Add("rita");
        names.Add("brio");
        names.Add("sahu");
        names.Add("rheo");
        // Iterate HashSet elements using foreach loop  
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}
