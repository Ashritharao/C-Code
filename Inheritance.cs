using System;
public class Animal   // declaring a parent class
{
public void eat() 
{ 
Console.WriteLine("Eating..."); 
}
}
public class Dog : Animal // declaring a child class
{
public void bark() 
{ 
Console.WriteLine("Barking..."); 
}
}
class TestInheritance2
{
public static void Main(string[] args)  // main function
 {
Dog d1 = new Dog();
d1.eat();
d1.bark();
}
}
