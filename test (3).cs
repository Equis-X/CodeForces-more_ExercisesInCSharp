using System;
using System.Collections.Generic;

public class Test
{
	public static void Main()
	{
		List<int> numbers = new List<int>();
		Console.WriteLine("Ingrese de manera horizontal su listado de numeros:");
		foreach(var num in Console.ReadLine().Split(' ')){
			numbers.Add(int.Parse(num));
		}
		Console.WriteLine(MaxPrime(numbers));
	}
	
	public static int MaxPrime(List<int> varx){
		int[] temp_arr = varx.ToArray();
		int res = 0;
		for (int i = 0; i < temp_arr.Length; i++){
			if (temp_arr[i] % 2 == 0 && temp_arr[i] > res){
				res = temp_arr[i];
			}
		}
		return res;
	}
}
