/* (4.1.3.6) Un programa que pida 10 nombres y los memorice
 *  (pista: esta vez se trata de un array de "string").
 *  Después deberá pedir que se teclee un nombre
 *  y dirá si se encuentra o no entre los 10 que
 *  se han tecleado antes. Volverá a pedir otro nombre
 *  y a decir si se encuentra entre ellos, y así sucesivamente
 *  hasta que se teclee "fin".
 */
 using System;
 
 public class Ejercicio_4_1_3_6
 {
	 public static void Main()
	 {
		 string[] nombres = new string[10];//donde se guardan los nombres
		 int i;
		 string nombreUsuario; //Nombre que ingresa el usuario
		 
		 Console.WriteLine("Escriba 10 nombres:");
		 for(i = 0; i < 10 ; i++)
		 {
			 nombres[i] = Console.ReadLine();
		 }
		 
		 do
		 {
			 Console.WriteLine("---------------------------------");
			 Console.Write("Escriba el nombre a buscar" +
			  " o \"fin\" para salir: ");
			 nombreUsuario = Console.ReadLine();
			 
			 for(i = 0; i < 10; i++)
			 {
				 if(nombreUsuario == nombres[i])
				 {
					 Console.WriteLine("Se encontró el nombre.");
					 break;
				 }
			 }
			 
			 if(i > 9)
			 {
					 Console.WriteLine("No se encontró el nombre.");				 
			 }
		 }while(nombreUsuario != "fin");		 
		 
		 
	 }
	 
 }
