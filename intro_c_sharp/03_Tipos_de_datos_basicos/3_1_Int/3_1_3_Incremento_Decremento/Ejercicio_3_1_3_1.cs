/*
 * (3.1.3.1) Crea un programa que use tres variables x,y,z.
 *  Sus valores iniciales serán 15, -10, 2.147.483.647.
 *  Se deberá incrementar el valor de estas variables.
 *  ¿Qué valores esperas que se obtengan?
 *  Contrástalo con el resultado obtenido por el programa.
 */
 
using System;

public class Ejercicio_3_1_3_1
{
	public static void Main()
	{
		byte x = 15;
		sbyte y = -10;
		int z = 2147483647; //Máximo numero que puede guardar int
		
		x++;
		y++;
		z++; //Si es int, vuelve al limite (numero negativo)
		
		Console.WriteLine("{0}",x );
		Console.WriteLine("{0}",y );
		Console.WriteLine("{0}",z );
		
		
	
	}
}
