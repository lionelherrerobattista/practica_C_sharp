/*(4.7.1) Un programa que pida al usuario 6 números en coma flotante
 * y los muestre ordenados de menor a mayor.
 * Escoge el método de ordenación que prefieras.
 */
using System;


public class Ejercicio_4_7_1
{
	//constante para la cantidad de numeros
	const int TOTAL_NUMEROS = 6;	
	
	public static void Main()
	{
		float[] numeros = new float[TOTAL_NUMEROS];
		float auxiliarNumero; //auxiliar para guardar el numero mientras ordeno
		
		//Para iterar:
		int i;
		int j;
		
		//Pido los numeros:
		Console.WriteLine("Ingrese 6 numeros con coma flotante: ");
		for(i = 0; i < TOTAL_NUMEROS; i++)
		{
			numeros[i] = Convert.ToSingle(Console.ReadLine());		
		}
		
		Console.WriteLine();
		//Muestro los numeros:
		Console.WriteLine("Numeros ingresados sin ordenar:");
		foreach(float numero in numeros)
		{
			Console.Write("{0}  ", numero);
		}
		Console.WriteLine();
		Console.WriteLine();
		
		//Ordeno. Método de inserción:
		for(i = 1; i < TOTAL_NUMEROS; i++)//tomo el de la derecha
		{
			j = i-1; //lo comparo con el de la izquierda
			
			while((j>=0) && (numeros[j] > numeros[j+1])) //Hasta llegar al final
			{
				//si el de la izquierda es mayor, ordeno:
				auxiliarNumero = numeros[j]; //tomo el de la izq
				numeros[j] = numeros[j+1]; //lo reemplazo por el de la derecha, que es menor
				numeros[j+1] = auxiliarNumero; //paso a la derecha el mayor
				
				j--;//comparo con el que sigue a la izquierda
			}
		}
		
		//Muestro los numeros ordenados
		Console.WriteLine("Numeros ordenados:");
		
		foreach(float numero in numeros)
		{
			Console.Write("{0}  ", numero);
		}
	}
	
}
