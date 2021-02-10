using System;
public class Address            //declare a class to fill the address .
{
    public string addresslane, city, state;
    public Address(string addresslane, string city, string state)
    {
        this.addresslane = addresslane;
        this.city = city;
        this.state = state;
    }
}
public class Student    //call the variables of adress class in  Student class by using this method. 
{
    public string name;
    int id;
    static int batch = 2017;
    static string course = "B. Tech.";
    Address address;
    public Student(int id, string name, Address address)
    {
        this.id = id;
        this.name = name;
        this.address = address;
    }
    public void display()
    {
        Console.WriteLine(id + " " + name + " " + address.addresslane + " " + address.city + " " + address.state + " " + course + " " + batch);
    }
}
public class AggregationExample
{
    public static void Main(string[] args)
    {
        Address a = new Address("s-15", "Hyderabad", "TS");
        Student s = new Student(101, "Ayush", a);
        s.display();
    }
}