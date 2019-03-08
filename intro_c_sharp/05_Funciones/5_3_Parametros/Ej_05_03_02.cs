/*(5.3.2) Crea una función "DibujarRectangulo"
 * que dibuje en pantalla un rectángulo del ancho
 * y alto que se indiquen como parámetros. Incluye un Main para probarla.
 */
using System;

public class Ejercicio_5_3_1
{
	public static void DibujarRectangulo(int ancho, int alto)
	{
		int fila;
		int columna;
		
		//Dibujo el rectángulo del alto indicado
		for(fila = 1; fila <= alto; fila++)
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
		int alto;
		
		Console.Write("Indique el ancho del rectángulo: ");
		ancho = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Indique el alto del rectángulo: ");
		alto = Convert.ToInt32(Console.ReadLine());
		
		//Dibujo el cuadrado
		Console.WriteLine();
		DibujarRectangulo(ancho, alto);
		
	}
}

