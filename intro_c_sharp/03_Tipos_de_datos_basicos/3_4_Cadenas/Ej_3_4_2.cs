/*
 * (3.4.2) Crear un programa que pida al usuario un nombre
 *  y una contraseña. La contraseña se debe introducir dos veces.
 *  Si las dos contraseñas no son iguales, se avisará al usuario
 *  y se le volverán a pedir las dos contraseñas.
 */
 using System;
 
 public class Ejercicio_3_4_2
 {
	 public static void Main()
	 {
		 string nombre;
		 string password;
		 string passwordDos;
		 
		 Console.Write("Escriba su nombre: ");
		 nombre = Console.ReadLine();
		 
		 Console.Write("Escriba su password: ");
		 password = Console.ReadLine();
		 
		 Console.Write("Confirme su password: ");
		 passwordDos = Console.ReadLine();
		 
		 while(password != passwordDos)
		 {
			 Console.WriteLine();
			 
			 Console.Write("Error. Escriba su password nuevamente: ");
			 password = Console.ReadLine();
			 
			 Console.Write("Confirme su password: ");
			 passwordDos = Console.ReadLine();			 
		 }
		 
		 Console.WriteLine();
		 Console.WriteLine("Exito!");
		 
	 }
	 
 }
