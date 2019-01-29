/*(4.4.2.1) Crea un programa que pregunte al usuario su nombre
 * y le responda cuál es su inicial.
 */
 using System;
 
 public class Ejercicio_4_4_2_1
 {
	 public static void Main()
	 {
		 string nombreUsuario;
		 
		 Console.Write("Escriba su nombre: ");
		 nombreUsuario = Console.ReadLine();
		 
		 //Accedo como si fuese un array
		 Console.WriteLine("Su inicial es: {0}", nombreUsuario[0]);
	 }
 }
