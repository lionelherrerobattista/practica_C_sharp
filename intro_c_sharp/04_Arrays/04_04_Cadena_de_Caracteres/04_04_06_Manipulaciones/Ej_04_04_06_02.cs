/*(4.4.6.2) Un programa que pida al usuario una frase y elimine
 * todos los espacios redundantes que contenga (debe quedar sólo
 * un espacio entre cada palabra y la siguiente).
 */
 using System;
 
 public class Ejercicio_4_4_6_2
 {
	 public static void Main()
	 {
		 string fraseUsuario;
		 
		 Console.WriteLine("Escriba una frase: ");
		 fraseUsuario = Console.ReadLine();
		 
		 //Si == -1 no hay espacios de más
		 while(fraseUsuario.IndexOf("  ") != -1)
		 {
			 //Reemplazo por un solo espacio
		     fraseUsuario = fraseUsuario.Replace("  "," ");	 
		 }

		 Console.WriteLine("{0}", fraseUsuario);
		 
	 }
 }
