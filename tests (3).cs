using System;
using System.Linq;

namespace HelloWorld
{
	class Program
    {
		static void Main(string[] args)
		{
			int[] numbers = { 1, 3, 4, 9, 2 };
            int indexToRemove = 1;
            foreach (var item in numbers)
            {
            	Console.WriteLine(item);
			}
            Console.WriteLine("Length: " + numbers.Length);
            //
            numbers = RemoveArrAt(indexToRemove, numbers);
            //
            foreach (var item in numbers)
            {
            	Console.WriteLine(item);
			}
            Console.WriteLine("Length: " + numbers.Length);
    	}
        
        public static int[] RemoveArrAt(int indx, int[] arr)
        {
        	return arr.Where(val => val != arr[indx]).ToArray();
        }
  	}
}