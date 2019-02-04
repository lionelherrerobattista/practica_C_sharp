/*(4.4.8.1) Un programa que pida al usuario dos frases
 * y diga cual sería la "mayor" de ellas (la que aparecería
 * en último lugar en un diccionario).
 */
 using System;
 
 public class Ejercicio_4_4_8_1
 {
	 public static void Main()
	 {
		 string fraseUno;
		 string fraseDos;
		 
		 Console.WriteLine("Escriba una frase: ");
		 fraseUno = Console.ReadLine();
		 
		 Console.WriteLine("Escriba otra frase: ");
		 fraseDos = Console.ReadLine();
		 
		 if(String.Compare(fraseUno, fraseDos) == 0)
		 {
			 Console.WriteLine("Las frases son iguales.");
		 }
		 else
		 {
			 if(String.Compare(fraseUno, fraseDos) > 0)
			 {
				 Console.WriteLine("La primera frase es mayor.");
			 }
			 else
			 {
				 Console.WriteLine("La segunda frase es mayor.");
			 }
		 }
	 }
 }
