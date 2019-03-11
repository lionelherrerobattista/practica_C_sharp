/*(5.4.4) Crea una función "Inicial", que devuelva la primera letra
 * de una cadena de texto. Prueba esta función para calcular
 * la primera letra de la frase "Hola".
 */
 using System;
 
 public class Ejercicio_5_5_4
 {
	//función que calcula la leta inicial de una palabra
	public static char Inicial(string palabra)
	{
		char letraInicial;
		
		//guardo en la variable la primera letra de la cadena (índice 0)
		letraInicial = palabra[0];
		
		return letraInicial;
	} 
	
	public static void Main()
	{
		string palabra = "Hola";
		char letraInicial;
		
		//Muestro la inicial
		letraInicial = Inicial(palabra);
		Console.WriteLine("{0} empieza con {1}", palabra, letraInicial);
	}
 }
