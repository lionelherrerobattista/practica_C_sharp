/*
 * (3.2.6.3) Crea un programa para mostrar los números del 0 a 255
 *  en hexadecimal, en 16 filas de 16 columnas cada una
 * (la primera fila contendrá los números del 0 al 15 –decimal-,
 *  la segunda del 16 al 31 –decimal- y así sucesivamente).
 */
 using System;
 //Hacer variables del 0 al 15 (primera columna) 16 al 31 (segunda)... 
public class Ejercicio_3_2_6_3
{
	public static void Main()
	{
		int numero = 0;
		int filas;
		int columnas;
		
		for(filas=1; filas <=16; filas++) //las filas
		{
			for(columnas = 1; columnas <= 16; columnas++) // Cada columna
			{
				Console.Write("{0} ", numero.ToString("X2")); //Muestra dos cifras en hexa
				numero +=16; //para imprimir al lado el siguiente numero que corresponde
			}
			numero = numero - 16*16; //resto lo que sume
			numero++; //sumo uno para continuar con la siguiente fila de numeros
			
			Console.WriteLine();
		}
	}
	
}
