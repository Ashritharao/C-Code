using methodoverriding;
using System;
namespace methodoverriding
{
    class BaseClass   // declaring virtual class.
    {
        public virtual string YourCity()
        {
            return "New York";
        }
    }
    class DerivedClass : BaseClass  // declaring base class.
    {
        public override string YourCity()   // overriding.
        {
            return "London";
        }
    }
}
class program
{
    static void Main(string[] args)  // Main Method.
    {
        DerivedClass obj = new DerivedClass();
        string city = obj.YourCity();
        Console.WriteLine(city);
        Console.Read();
    }
}
