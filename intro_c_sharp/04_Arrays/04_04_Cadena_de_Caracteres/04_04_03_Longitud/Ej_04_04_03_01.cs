/*(4.4.3.1) Un programa que te pida tu nombre y lo muestre
 * en pantalla separando cada letra de la siguiente con un espacio.
 * Por ejemplo, si tu nombre es "Juan", debería aparecer
 * en pantalla "J u a n".
 */
 using System;
 
 public class Ejercicio_4_4_3_1
 {
	 public static void Main()
	 {
		 string nombreUsuario;
		 int i;
		 int longitud;
		 
		 Console.Write("Escriba su nombre: ");
		 nombreUsuario = Console.ReadLine();
		 
		 longitud = nombreUsuario.Length;
		 
		 for(i = 0; i < longitud; i++)
		 {
			 Console.Write("{0} ", nombreUsuario[i]);
		 } 
		 
	 }
 }
