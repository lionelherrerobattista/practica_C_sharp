/*(5.2.1) Crea una función llamada "BorrarPantalla",
 * que borre la pantalla dibujando 25 líneas en blanco.
 * Crea también un "Main" que permita probarla.
 */
using System;

public class Ejercicio_5_2_1
{
	//Función que borra la pantalla:
	public static void BorrarPantalla()
	{
		int i;
		
		for(i = 0; i < 25; i++)
		{
			Console.WriteLine();
		}
	}
	
	public static void Main()
	{
		Console.WriteLine("Hola Mundo.");//Texto a borrar
		Console.ReadLine();//Pausa
		BorrarPantalla();//Borro la pantalla
		
	}
}
