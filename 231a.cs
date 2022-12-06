using System;

namespace HelloWorld
{
	class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int view = 0, count = 0, problemcount = 0;
            for(int i = 1; i <= n; i++)
            {
                count = 0;
                for (int j = 1; j <= 3; j++)
                {
                    view = int.Parse(Console.ReadLine());
                    if (view == 1){
                        count++;
                    }
                }
                if (count >= 2)
                {
                    problemcount++;
                }
            }

            Console.WriteLine(problemcount);
        }
    }
}