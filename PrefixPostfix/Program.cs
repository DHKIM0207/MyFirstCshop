using System;

namespace PrefixPostfix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int result1 = ++num;
            int result2 = num;

            Console.WriteLine(result1);
            Console.WriteLine(result2);

            int num2 = 10;
            int result3 = num2++;
            int result4 = num2;

            Console.WriteLine(result3);
            Console.WriteLine(result4);
        }
    }
}
