/*(4.5.2) Un programa que pida al usuario una frase y la descomponga
 * en subcadenas separadas por espacios, usando "Split".
 * Luego debe mostrar cada subcadena en una línea nueva,
 * usando "foreach".
 */
 using System;
 
 public class Ejercicio_4_5_2
 {
	 public static void Main()
	 {
		 string frase;
		 string [] palabras;
		 char delimitador = ' ';
		 
		 Console.WriteLine("Escriba una frase: ");
		 frase = Console.ReadLine();
		 
		 palabras = frase.Split(delimitador);
		 
		 foreach(string palabra in palabras)
		 {
			 Console.WriteLine("{0}", palabra);
		 }
	 }
 }
