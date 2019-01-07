/*
 * (3.2.6.1) Crea un programa que pida números (en base 10) al usuario
 * y muestre su equivalente en sistema binario y en hexadecimal.
 * Debe repetirse hasta que el usuario introduzca el número 0.
 */
 using System;
 
 public class Ejercicio_3_2_6_1
 {
	 public static void Main()
	 {
		 int numeroUsuario; //Para convertirlo tiene que ser entero(?)
		 
		 do
		 {
			 
			 Console.Write("Escriba un numero: ");
			 numeroUsuario = Convert.ToInt32(Console.ReadLine());
			 
			 //Paso el número a binario
			 Console.WriteLine("Sistema binario : {0}",
			  Convert.ToString(numeroUsuario, 2));
			  
			 //Paso el número a hexadecimal
			 Console.WriteLine("Sistema hexadecimal : {0}",
			  Convert.ToString(numeroUsuario, 16));
			 
			 
		 }while(numeroUsuario != 0); //0 para salir
	 }
 }
