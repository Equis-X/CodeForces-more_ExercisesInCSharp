using System;

namespace HelloWorld
{
	class Program
    {
        static void Main(string[] args)
        {
            int a=0,count=0;
            a = int.Parse(Console.ReadLine());
            int[] x = new int[50], y = new int[50];
            for(int i=0; i<a; i++)
            {
                x[i] = int.Parse(Console.ReadLine());
                y[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0; i<a; i++)
            {
                for(int j=0; j<a; j++)
                {
                    if(x[i]==y[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}