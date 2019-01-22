/*(4.2.1) Un programa que pida al usuario dos bloques de 10 números
 *  enteros (usando un array de dos dimensiones). Después deberá mostrar
 *  el mayor dato que se ha introducido en cada uno de ellos.
 */
 using System;
 
 public class Ejercicio_4_2_1
 {
	 public static void Main()
	 {
		 //declaro el array de dos dimensiones
		 int[,] numeros = new int [2,10]; //2 bloques de 10
		 int i;
		 int mayorUno; //mayor del primer grupo
		 int mayorDos; //mayor del segundo grupo
		 
		 Console.WriteLine("Escriba 10 numeros para el primer grupo:");
		 for(i=0; i < 10; i++)
		 {
			 //Accedo al primer bloque con el índice 0
			 numeros[0, i] = Convert.ToInt32(Console.ReadLine());
		 }
		 
		 //Tomo como mayora al primero y lo comparo con los otros
		 mayorUno = numeros[0, 0];
		 
		 for(i=1; i < 10; i++)
		 {
			 if(numeros[0, i] > mayorUno)
			 {
				 mayorUno = numeros[0, i];				 
			 }
		 }
		 
		 Console.WriteLine("Escriba 10 numeros para el segundo grupo:");
		 for(i=0; i < 10; i++)
		 {
			 numeros[1, i] = Convert.ToInt32(Console.ReadLine());
		 }
		 
		 //Tomo como mayora al primero y lo comparo con los otros
		 mayorDos = numeros[1, 0];
		 
		 for(i=1; i < 10; i++)
		 {
			 if(numeros[1, i] > mayorDos)
			 {
				 mayorDos = numeros[1, i];				 
			 }
		 }
		 
		 Console.WriteLine("El mayor del primer grupo es {0}" +
		  " y el del segundo grupo es {1}", mayorUno, mayorDos);
		 
	 }
 }
