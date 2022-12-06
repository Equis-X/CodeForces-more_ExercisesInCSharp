using System;
using System.Collections.Generic;

namespace HelloWorld
{
  class Program
  {
    public static void Main()
    {
        Console.WriteLine("Multiplos de 3 y 2 entre dos numeros!");
        int[] asd = {0, 0};
        List<int> numeros_res = new List<int>(); // Resultados
        Console.WriteLine("Inserte el primer numero:");
        asd[0] = int.Parse(Console.ReadLine());    // Primer Numero
        Console.WriteLine("Inserte el segundo numero:");
        asd[1] = int.Parse(Console.ReadLine());    // Segundo Numero
        for (int i = asd[0]; i < asd[1]; i++)
        {
            if (esmultiplo(i,2) && esmultiplo(i,3)){
                numeros_res.Add(i);
            }
        }
        Console.WriteLine("\nLos numeros encontrados son:");
        foreach (int item in numeros_res)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Cuadrados de los numeros encontrados:");
        foreach (int item in numeros_res)
        {
        	Console.WriteLine(Math.Pow(item,2));
        }
        Console.WriteLine("Cubos de los numeros encontrados:");
        foreach (int item in numeros_res)
        {
        	Console.WriteLine(Math.Pow(item,3));
        }
    }

    public static bool esmultiplo(int numero, int multiplo)
    {
    	if (numero % multiplo == 0){
    		return true;
    	} else {
    		return false;
    	}
    }
  }
}