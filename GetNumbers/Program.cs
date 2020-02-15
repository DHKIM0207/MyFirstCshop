using System;

namespace GetNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number (Integer): ");
            string num1 = Console.ReadLine();

            Console.WriteLine("Enter the second number (Integer): ");
            string num2 = Console.ReadLine();

            Console.WriteLine("Enter the third number (Integer): ");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the forth number (floating number): ");
            float num4 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Num1: {num1}, Num2: {num2}, Num3: {num3}, Num4: {num4}");
        }
    }
}
