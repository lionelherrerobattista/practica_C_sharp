/*(4.4.3.2) Un programa que pida una frase al usuario y la muestra
 * en orden inverso (de la última letra a la primera)
 */
 using System;
 
 public class Ejercicio_4_4_3_2
 {
	 public static void Main()
	 {
		 string frase;
		 int longitud;
		 int i;
		 
		 Console.WriteLine("Ingrese una frase: ");
		 frase = Console.ReadLine();
		 
		 longitud = frase.Length;
		 
		 for(i = longitud-1; i >= 0; i--)
		 {
			 Console.Write("{0}", frase[i]);
		 }
		 
	 }
 }
