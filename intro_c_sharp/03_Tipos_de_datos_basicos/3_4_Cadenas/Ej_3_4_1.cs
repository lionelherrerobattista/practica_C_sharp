/*
 * (3.4.1) Crear un programa que pida al usuario su nombre,
 * y le diga "Hola" si se llama "Juan", o bien le diga "No te conozco"
 * si teclea otro nombre.
 */
 using System;
 
 public class Ejercicio_3_4_1
 {
	 public static void Main()
	 {
		 string nombreUsuario;
		 
		 Console.Write("Escriba su nombre: ");
		 nombreUsuario = Console.ReadLine();
		 
		 if(nombreUsuario == "Juan")
		 {
			 Console.WriteLine("Hola, {0}", nombreUsuario);
		 }
		 else
		 {
			 Console.WriteLine("No te conozco.");
			 
		 }
	 }
 }
