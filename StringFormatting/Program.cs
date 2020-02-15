using System;

namespace StringFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            // 게임 승률 [ 문자열 정렬 ]
            string studentName1 = "Kim Leon";
            float winRate1 = 30.2351f;

            string studentName2 = "Lulu";
            float winRate2 = 70.11f;

            string studentName3 = "Blitzcrank";
            float winRate3 = 98.284f;

            Console.WriteLine("{0,10}{1,15}\n", "Name", "Win Rate");
            Console.WriteLine("{0,10}{1,15}\n", studentName1, winRate1);
            Console.WriteLine("{0,10}{1,15}\n", studentName2, winRate2);
            Console.WriteLine("{0,10}{1,15}\n", studentName3, winRate3);

            // 소수점 이하 자릿수 제어하기
            Console.WriteLine("{0}", 3.14159265359);
            Console.WriteLine("{0:f4}", 3.14159265359);
            Console.WriteLine("{0:f3}", 3.14159265359);
            Console.WriteLine("{0:f2}", 3.14159265359);
            Console.WriteLine("{0:f1}", 3.14159265359);

            Console.WriteLine("{0}", 10.1);
            Console.WriteLine("{0:f2}", 10.1);
            Console.WriteLine("{0:f3}", 10.1);
            Console.WriteLine("{0:f4}", 10.1);

            Console.WriteLine("{0}", 200);
            Console.WriteLine("{0:f1}", 200);
            Console.WriteLine("{0:f2}", 200);
            Console.WriteLine("{0:f3}", 200);
            Console.WriteLine("{0:f4}", 200);

        }
    }
}
