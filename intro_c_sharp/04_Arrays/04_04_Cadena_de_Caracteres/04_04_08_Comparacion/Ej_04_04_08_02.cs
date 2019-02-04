/*(4.4.8.2) Un programa que pida al usuario cinco frases,
 * las guarde en un array y muestre la "mayor" de ellas.
 */
 using System;
 
 public class Ejercicio_4_4_8_2
 {
	 public static void Main()
	 {
		 string[] frasesUsuario = new string [5];
		 string fraseMayor = "";
		 bool primeraIteracion = true;
		 int i;
		 
		 //Le pide al usuario las 5 frases
		 Console.WriteLine("Escriba 5 frases:");
		 for(i = 0; i < 5; i++)
		 {
			 frasesUsuario[i] = Console.ReadLine();
			 
			 //Comparo para saber cuál es mayor
			 if(primeraIteracion) //primera itración
			 {
				 fraseMayor = frasesUsuario[i];
				 primeraIteracion = false;//cambiar a false
			 }
			 else
			 {
				 //Si no es la primera iteración, comparo
				 if(String.Compare(fraseMayor, frasesUsuario[i]) < 0)
				 {
					 fraseMayor = frasesUsuario[i];
				 }
			 }
		 }
		 
		 //Muestro la frase mayor
		 Console.WriteLine("La frase mayor es: {0}", fraseMayor);
	 }
 }
