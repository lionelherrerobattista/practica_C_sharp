/*
 * (3.2.5.4) Calcula la superficie y el volumen de una esfera,
 * a partir de su radio (superficie = 4 * pi * radio al cuadrado;
 * volumen = 4/3 * pi * radio al cubo). Usa datos "doble" y muestra
 * los resultados con 5 cifras decimales.
 */
 using System;

public class Ejercicio_3_2_5_4
{
	public static void Main()
	{
		double radioEsfera;
		
		double superficie;
		double volumen;
		
		Console.Write("Escriba el radio de la esfera: ");
		radioEsfera = Convert.ToDouble(Console.ReadLine());
		
		superficie = 4 * 3.14159 * (radioEsfera * radioEsfera);
		
		//Hacer typecast de uno de los numeros en la division de enteros
		// porque sino resulta en un entero
		volumen = (double)4/3 * 3.14159 *
		 (radioEsfera * radioEsfera * radioEsfera);
		
		Console.WriteLine("La superficie de la esferea es de {0}",
		 superficie.ToString("N5"));
		 
		Console.WriteLine("El volumen de la esferea es de {0}",
		 volumen.ToString("N5"));
	}
	
}
