/*
 * (3.1.4.1) Crea un programa que use tres variables x,y,z.
 *  Sus valores iniciales serán 15, -10, 214.
 *  Deberás incrementar el valor de estas variables en 12,
 *  usando el formato abreviado. ¿Qué valores esperas que se obtengan?
 *  Contrástalo con el resultado obtenido por el programa.
 */
using System;

public class Ejercicio_3_1_4_1
{
	public static void Main()
	{
		byte x = 15; //8 bits 0 hasta 256
		sbyte y = -10; // numero con signo
		byte z = 214;
		
		//Incremento usando método abreviado
		x += 12;
		y += 12;
		z += 12;
		
		Console.WriteLine("x = {0}", x);
		Console.WriteLine("y = {0}", y);
		Console.WriteLine("z = {0}", z);
	}
	
}
