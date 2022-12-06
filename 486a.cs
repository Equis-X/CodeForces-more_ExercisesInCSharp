using System;

namespace HelloWorld
{
	class Program
    {
        static void Main(string[] args)
        {
            long a = 0;
            long d = 0;
            a = int.Parse(Console.ReadLine());
            if(a%2 == 0)
            {
                Console.WriteLine(a / 2);
            }
            else
            {
                d = -1 * (a / 2 + 1);
                Console.WriteLine(d);
            }
        }
    }
}