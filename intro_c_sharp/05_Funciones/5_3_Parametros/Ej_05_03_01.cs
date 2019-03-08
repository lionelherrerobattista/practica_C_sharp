/*(5.3.1) Crea una función "DibujarCuadrado" que dibuje en pantalla
 * un cuadrado del ancho (y alto) que se indique como parámetro.
 * Completa el programa con un Main que permita probarla.
 */
using System;

public class Ejercicio_5_3_1
{
	public static void DibujarCuadrado(int ancho)
	{
		int fila;
		int columna;
		
		//Dibujo el cuadrado del ancho indicado
		for(fila = 1; fila <= ancho; fila++)
		{
			//Me muevo de acuerdo al ancho elegido
			for(columna = 1; columna <= ancho; columna++)
			{
				Console.Write("*");//dibujo las columnas
			}
			
			Console.WriteLine();//paso a la siguiente fila
		}
	}
	
	public static void Main()
	{
		int ancho;
		
		Console.Write("Indique el ancho del cuadrado: ");
		ancho = Convert.ToInt32(Console.ReadLine());
		
		//Dibujo el cuadrado
		Console.WriteLine();
		DibujarCuadrado(ancho);
		
	}
}
