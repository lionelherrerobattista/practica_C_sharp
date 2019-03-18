/*(5.4.5) Crea una función "UltimaLetra", que devuelva la última letra
 * de una cadena de texto. Prueba esta función para calcular la última
 * letra de la frase "Hola".
 */
using System;

public class Ejercicio_5_4_5
{
	//Función que calcula la ultima letra de una palabra
	public static char UltimaLetra(string palabra)
	{
		char ultimaLetra;
		int indiceUltimaLetra;
		
		//calculo el largo de la palabra y resto uno para obtener
		//el índice de la última letra
		indiceUltimaLetra = palabra.Length - 1;
		
		//guardo la última letra en una variable
		ultimaLetra = palabra[indiceUltimaLetra];
		
		return ultimaLetra;
	}
	
	public static void Main()
	{
		string palabra = "Hola";
		char ultimaLetra;
		
		//muestro la última letra de la palabra
		ultimaLetra = UltimaLetra(palabra);
		
		Console.WriteLine("La última letra de {0} es {1}.", palabra,
		 ultimaLetra);
	}
}

