using System;

namespace HelloWorld
{
	class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int ctr = 0;
            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());   
            }
            int key = a[k-1];
            for(int i = 0; i < n; i++)
            {
                if(a[i] >= key && a[i] > 0)
                {
                    ctr++;
                }   
            }
            Console.WriteLine(ctr);
        }
    }
}