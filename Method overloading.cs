using System;
public class Cal         // Passing different arguments in same method to define method over loading 
{
    public static int add(int a, int b)     // Adding two integer values
    {
        return a + b;
    }
    public static int add(int a)   
    {
        return a + 20;
    }
}
public class TestMemberOverloading
{
    public static void Main()     // Main Method
    {
        Console.WriteLine(Cal.add(12, 23));
        Console.WriteLine(Cal.add(12 /*"23, 25"*/));
    }
}
