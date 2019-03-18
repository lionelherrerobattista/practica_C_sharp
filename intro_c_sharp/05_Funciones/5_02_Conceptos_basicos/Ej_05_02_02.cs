/*(5.2.2) Crea una función llamada "DibujarCuadrado3x3",
 * que dibuje un cuadrado formato por 3 filas con 3 asteriscos cada una.
 * Incluye un "Main" para probarla.
 */
using System;

public class Ejercicio_5_2_2
{
	public static void DibujarCuadrado3x3()
	{
		int fila;
		int columna;
		
		for(fila = 1; fila <= 3; fila++)
		{
			for(columna = 1; columna <= 3; columna++)
			{
				Console.Write("*");
			}
			
			Console.WriteLine();
		}
	}
	
	public static void Main()
	{
		DibujarCuadrado3x3();
		
	}
}
