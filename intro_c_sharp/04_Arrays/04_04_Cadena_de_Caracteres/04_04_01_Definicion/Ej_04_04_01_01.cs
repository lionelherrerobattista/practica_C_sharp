/*(4.4.1.1) Crea un programa que te pida tu nombre y lo escriba 5 veces.
 */
 using System;
 
 public class Ejercicio_04_04_01_01
 {
	 public static void Main()
	 {
		 string nombre;
		 int i;
		 
		 Console.Write("Escriba su nombre: ");
		 nombre = Console.ReadLine();
		 
		 Console.WriteLine();
		 for(i = 0; i < 5; i++)
		 {
			 Console.WriteLine("{0}", nombre);
		 }
	 }
 }
