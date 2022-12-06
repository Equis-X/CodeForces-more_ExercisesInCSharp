using System;

namespace HelloWorld
{
	class Program
    {
        static void Main(string[] args)
        {
            int n=0, b=0;
            int[] mas = new int[105];
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                b = int.Parse(Console.ReadLine());
                mas[b] = i;
            }
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(mas[i]+" ");
            }
        }
    }
}