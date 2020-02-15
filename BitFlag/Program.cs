using System;

namespace BitFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            const int BIT_FLAG_SIZE = 8;

            byte bitFlags = 0;

            // 오른쪽에서부터 세 번째 비트를 참(true)로 설정해보자. 어떻게 해야할까?
            byte mask1 = 1 << 2;

            bitFlags |= mask1;

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

            //이제 오른쪽 끝에서 4번째 그리고 6번째 비트를 참으로 설정하고 싶다면?
            byte mask3 = (1 << 3) | (1 << 5);

            bitFlags |= mask3;

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

            /*이제 3번째 비트를 끄고 싶다면?
              다른 비트는 건드리면 안됨. 즉 다른 비트들이 1이라면 그 비트들은 여전히 1로,
              0이라면 0으로 유지해야함*/
            bitFlags &= (byte)~mask1;

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

            //만약 모든 비트를 다 꺼버리고 싶다면
            bitFlags &= 0;

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

            bitFlags &= 0;
            char char1 = 'A';
            bitFlags |= (byte)char1;
            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

            bitFlags &= 0;
            char char2 = ' ';
            bitFlags |= (byte)char2;
            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

            int result1 = char1 | ' ';
            Console.WriteLine("result1: " + (char)result1);

            char char3 = 'a';
            int result2 = char3 & '_';

            Console.WriteLine("result2: " + (char)result2);

            bitFlags &= 0;
            char char4 = '_';
            bitFlags |= (byte)char4;
            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));
        }
    }
}
