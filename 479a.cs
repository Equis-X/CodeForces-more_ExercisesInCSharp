using System;

namespace HelloWorld
{
	class Program
    {
        static void Main(string[] args)
        {
            long i = 0, ans = 0, a = 0, b = 0, c = 0;
            while (true)
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());
                ans=a+b+c;
                ans=Math.Max(ans,(a*b*c));
                ans=Math.Max(ans,(a+b)*c);
                ans=Math.Max(ans,a*(b+c));
                ans=Math.Max(ans,a+(b*c));
                ans=Math.Max(ans,(a*b)+c);
                Console.WriteLine(ans);
                break;
            }
        }
    }
}