using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        public delegate double MathOperation(double x, double y);
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose an operation (1: Add, 2: Subtract, 3: Multiply, 4: Divide):");
            int choice = int.Parse(Console.ReadLine());

            MathOperation operation = null;
            switch (choice)
            {
                case 1:
                    operation = Add;
                    break;
                case 2:
                    operation = Subtract;
                    break;
                case 3:
                    operation = Multiply;
                    break;
                case 4:
                    operation = Divide;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            try
            {
                double result = Calculate(x, y, operation);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        static double Add(double x, double y)
        {
            return x + y;
        }
        static double Subtract(double x, double y)
        {
            return x - y;
        }
        static double Multiply(double x, double y)
        {
            return x * y;
        }
        static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return x / y;
        }
        static double Calculate(double x, double y, MathOperation operation)
        {
            return operation(x, y);
        }
    }
}
