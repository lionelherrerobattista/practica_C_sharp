/*Lionel R. Herrero Battista
calcula la divisi�n de dos n�meros introducidos por el usuario,
as� como el resto de esa divisi�n
*/
using System;

public class Ejercicio_1_10_2
{
	public static void Main()
	{
		int dividendo;
		int divisor;
		int resultado;
		int resto;

		Console.WriteLine("Escriba el dividendo:");
		dividendo = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Escriba el divisor:");
		divisor = Convert.ToInt32(Console.ReadLine());

		resultado = dividendo / divisor;
		resto = dividendo % divisor;

		Console.WriteLine("El resultado de la division entre {0} y {1} es {2} y el resto es {3}",
		dividendo, divisor, resultado, resto);
	}
}