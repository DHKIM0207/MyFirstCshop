using System;

namespace LogicalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
			int num = 10;

			if (3 * 6 != 18 || ++num == 11)
			{
				num++;
			}

			if (12 + 2 == 14 && num++ == 11)
			{
				num++;
			}
			
			if (1 * 4 == 4 || num++ > 0)
			{
				num++;
			}

			Console.WriteLine(num);
		}
    }
}
