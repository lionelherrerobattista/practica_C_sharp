/*(5.10.1) Crea una función que calcule el valor de elevar
 * un número entero a otro número entero (por ejemplo,
 * 5 elevado a 3 = 53 = 5 ·5 ·5 = 125).
 * Esta función se debe crear de forma recursiva.
 * Piensa cuál será el caso base (qué potencia se puede calcular
 * de forma trivial) y cómo pasar del caso "n-1" al caso "n"
 * (por ejemplo, si sabes el valor de 5^4, cómo hallarías
 * el de 5^5 a partir de él).
 */
using System;

public class Ejercicio_5_10_1
{
	public static double Potencia(int numero, int exponente)
	{
		double resultado;
		
		resultado = numero;
		
		if(exponente == 1)//salida
		{
			resultado *= 1;
		}
		else
		{
			resultado *= Potencia(numero, exponente-1);
		}
		
		return resultado;
	}
	
	public static void Main()
	{
		int numero;
		int exponente;
		double resultado;
		
		//Pido los datos
		Console.WriteLine("Ingrese la base y el exponente" +
		 " para calcular su potencia:");
		
		Console.Write("Base: ");
		numero = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Exponente: ");
		exponente = Convert.ToInt32(Console.ReadLine());
		
		//Calculo el resultado
		resultado = Potencia(numero, exponente);
		
		//Lo muestro
		Console.WriteLine(resultado);
	}
}
