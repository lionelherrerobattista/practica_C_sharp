/*
 * (3.1.2.2) Pide al usuario dos números de dos cifras ("byte"),
 *  calcula su multiplicación, que se deberá guardar en un "ushort",
 *  y muestra el resultado en pantalla.
 */
 
using System;

public class Ejercicio_3_1_2_2
{
	public static void Main()
	{
		byte numeroUno; //guarda hasta 255 - 8 bits
		byte numeroDos;
		ushort resultado; //16 bits
		
		Console.Write("Escriba un numero para calcular su producto: ");
		numeroUno = Convert.ToByte(Console.ReadLine());
		
		Console.Write("Escriba el otro numero: ");
		numeroDos = Convert.ToByte(Console.ReadLine());
		
		resultado = Convert.ToUInt16(numeroUno * numeroDos);
		
		Console.Write("El resultado es {0}", resultado);
	}
	
	
	
}
