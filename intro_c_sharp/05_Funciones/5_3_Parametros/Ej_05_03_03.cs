/*(5.3.3) Crea una función "DibujarRectanguloHueco" que dibuje
 * en pantalla un rectángulo hueco del ancho y alto que se indiquen
 * como parámetros, formado por una letra que también se indique
 * como parámetro. Completa el programa con un Main que pida
 * esos datos al usuario y dibuje el rectángulo.
 */
using System;

public class Ejercicio_5_3_1
{
	public static void DibujarRectanguloHueco(int ancho, int alto)
	{
		int fila;
		int columna;
		
		//Dibujo el rectángulo del alto indicado
		for(fila = 1; fila <= alto; fila++)
		{
			//Me muevo de acuerdo al ancho elegido
			for(columna = 1; columna <= ancho; columna++)
			{
				//si es la primera o la última fila todo *, o si es la primera o la última columna 
				if( (fila == 1 || fila == alto) || (columna == 1 || columna == ancho))
				{
					Console.Write("*");//dibujo las columnas					
				}
				else
				{
					Console.Write(" ");
				}
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
		DibujarRectanguloHueco(ancho, alto);
		
	}
}
