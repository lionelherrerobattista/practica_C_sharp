/*(4.4.4.1) Un programa que te pida tu nombre y lo muestre
 * en pantalla separando cada letra de la siguiente con un espacio,
 * similar al 4.4.3.1, pero esta vez usando "Substring".
 * Por ejemplo, si tu nombre es "Juan", debería aparecer
 * en pantalla "J u a n".
 */
 using System;
 
 public class Ejercicio_4_4_4_1
 {
	 public static void Main()
	 {
		 string nombre;
		 int i;
		 
		 Console.WriteLine("Escriba su nombre: ");
		 nombre = Console.ReadLine();
		 
		 for(i = 0; i < nombre.Length; i++)
		 {
			 //Substring(posición donde empieza, cantidad de caracteres)
			 Console.Write("{0} ", nombre.Substring(i,1)); //Saco de a 1 caracter y me voy moviendo de posición
		 }
		 
	 }
 }
