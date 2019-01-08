/*
 * (3.3.1.1) Crea un programa que pida una letra al usuario
 *  y diga si se trata de una vocal.
 */
 using System;
 
 public class Ejercicio_3_3_1_1
 {
	 public static void Main()
	 {
		 char letra;
		 
		 Console.Write("Escriba una letra"+
		 " para saber si es una vocal: ");
		 letra = Convert.ToChar(Console.ReadLine()); //Tengo que pasar el String a Char
		 
		 //Me fijo si es una vocal
		 if(letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o'
		 || letra == 'u')
		 {
			 Console.WriteLine("La letra '{0}' es una vocal.", letra);
		 }
		 else
		 {
			 Console.WriteLine("La letra '{0}' no es una vocal.", letra);
		 }
	 }
 }
