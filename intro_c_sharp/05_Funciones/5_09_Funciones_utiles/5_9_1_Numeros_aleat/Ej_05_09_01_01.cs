/*(5.9.1.1) Crea un programa que imite el lanzamiento de un dado,
 * generando un número al azar entre 1 y 6.
 */
 using System;
 
 public class Ejercicio_5_9_1_1
 {
	 public static void Main()
	 {
		 //Creo objeto random:
		 Random dado = new Random();
		 
		 int numeroDado;
		 
		 //Uso Next para obtener un numero al azar entre el rango
		 numeroDado = dado.Next(1, 7); //último número no incluído
		 
		 Console.WriteLine("El número del dado es {0}", numeroDado);
		 		 
	 }
 }
