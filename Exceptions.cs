using System;

namespace Exceptions
{
    class DivNumbers           //declare a class to define a exceptions.
    {
        int result;

        DivNumbers()
        {
            result = 0;
        }

        public void division(int num1, int num2)
        {
            try                  //throw an exception for the condition if the divident value is zero.
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }

        static void Main(string[] args)
        {
            DivNumbers d = new DivNumbers();
            d.division(25, 0);
            Console.ReadKey();
        }
    }
}
