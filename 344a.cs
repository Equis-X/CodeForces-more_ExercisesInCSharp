using System;

namespace HelloWorld
{
	class Program
    {
        static void Main(string[] args)
        {
            int n = 0, c = 0;
            n = int.Parse(Console.ReadLine());
            int[] a = new int[100000];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if(a[i] != a[i+1]) c++;
            }

            Console.WriteLine(c);
        }
    }
}