/*
 * (3.1.2.3) Pide al usuario dos números enteros largos ("long")
 *  y muestra su suma, su resta y su producto.
 */
 
using System;

public class Ejercicio_3_1_2_3
{
	public static void Main()
	{
		long numeroUno;
		long numeroDos;
		
		long suma;
		long resta;
		long producto;
	
		Console.Write("Escriba un numero: ");
		numeroUno = Convert.ToInt64(Console.ReadLine());//Paso la string a long - 64 bits
		
		Console.Write("Escriba otro numero: ");
		numeroDos = Convert.ToInt64(Console.ReadLine());
		
		suma = numeroUno + numeroDos;
		resta = numeroUno - numeroDos;
		producto = numeroUno * numeroDos;
		
		Console.Write("La suma de los numeros es {0}, la resta {1} y su producto {2}",
		 suma, resta, producto);
	}
}
