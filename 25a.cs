using System;

namespace HelloWorld
{
	class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int x = 0;
            int even = 0;
            int lastodd= 0;
            int lasteven = 0;
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; ++i)
            {
                x = int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                {
                    even += 1;
                    lasteven = i;
                }
                else
                {
                    even -= 1;
                    lastodd = i;
                }
            }
            Console.WriteLine(even > 0 ? lastodd : lasteven);
        }
    }
}