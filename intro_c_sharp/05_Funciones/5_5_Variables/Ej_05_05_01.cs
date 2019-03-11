/*(5.5.1) Crea una función "PedirEntero", que reciba como parámetros
 * el texto que se debe mostrar en pantalla, el valor mínimo aceptable
 * y el valor máximo aceptable. Deberá pedir al usuario que introduzca
 * el valor tantas veces como sea necesario, volvérselo a pedir en caso
 * de error, y devolver un valor correcto.
 * Pruébalo con un programa que pida al usuario un año entre 1800
 * y 2100.
 */
 using System;
 
 public class Ejercicio_5_5_1
 {
	 //Función que pide un valor al usuario, entre un valor mínimo y máximo
	 //devuelve el valor
	 public static int PedirEntero(string mensaje, int minimo, int maximo)
	 {
		 
		 
		 int numeroUsuario;
			 
		 Console.WriteLine("{0}", mensaje);
			 
		 numeroUsuario = Convert.ToInt32(Console.ReadLine()); 
			 
		 while(numeroUsuario < minimo || numeroUsuario > maximo)
		 {
			 Console.WriteLine("Error. Número fuera de rango.");
			 Console.WriteLine("{0}", mensaje);
			 
			 numeroUsuario = Convert.ToInt32(Console.ReadLine()); 		 			
		 }
		 
		 return numeroUsuario;
		 
	 }
	 
	 public static void Main()
	 {
		 int numero;
		 
		 numero = PedirEntero("Ingrese un número entre 1800 y 2100: ",
		  1800, 2100);
		  
		 Console.WriteLine("El numero ingresado es {0}", numero);
		 
	 }
 }
