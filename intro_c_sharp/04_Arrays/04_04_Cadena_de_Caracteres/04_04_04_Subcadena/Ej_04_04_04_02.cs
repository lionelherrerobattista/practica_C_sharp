/*(4.4.4.2) Un programa que te pida tu nombre y lo muestre en pantalla
 * como un triángulo creciente. Por ejemplo, si tu nombre es "Juan",
 * debería aparecer en pantalla:
 * J
 * Ju
 * Jua
 * Juan
 */
 using System;
 
 public class Ejercicio_4_4_4_2
 {
	 public static void Main()
	 {
		 string nombre;
		 int i;
		 
		 Console.Write("Escriba su nombre: ");
		 nombre = Console.ReadLine();
		 
		 for(i = 0; i < nombre.Length; i++)
		 {
			 Console.WriteLine("{0}", nombre.Substring(0,i+1));
		 }
		 
	 }
 }
