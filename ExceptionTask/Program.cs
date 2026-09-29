using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Exception Handling");

            try
            {
                string[] names = new string[3];

                names[0] = "Rubi";
                names[1] = "Asha";
                names[2] = "John";

                object[] objects = names;
                objects[0] = 100;
            }
            catch (ArrayTypeMismatchException ex)
            {
                Console.WriteLine("\nArrayTypeMismatchException");
                Console.WriteLine(ex.Message);
            }

            try
            {
                string name = null;

                Console.WriteLine("\nName length: " + name.Length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("\nNullReferenceException");
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.Write("\nEnter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int result = num1 / num2;

                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("\nDivideByZeroException");
                Console.WriteLine(ex.Message);
            }

            try
            {
                object value = "Hello";

                int number = (int)value;

                Console.WriteLine("Number: " + number);
            }
            catch (InvalidCastException ex)

            {
                Console.WriteLine("\nInvalidCastException");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nProgram completed.");
            Console.ReadLine();
        }
    }
}