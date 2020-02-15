using System;

namespace PrintStudentInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Lulu";
            int id = 20190001;

            // 방법1
            String message1 = string.Format($"Student Name: {name} / Student ID: {id}");
            Console.WriteLine(message1);

            // 방법2
            Console.WriteLine($"Student Name: {name} / Student ID: {id}");
        }
    }
}
