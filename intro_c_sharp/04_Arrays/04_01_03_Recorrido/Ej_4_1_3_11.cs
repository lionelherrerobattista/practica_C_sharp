/*(4.1.3.11) Un programa que pida al usuario 4 números enteros
 *  y calcule (y muestre) cuál es el mayor de ellos.
 *  Nota: para calcular el mayor valor de un array,
 *  hay que comparar cada uno de los valores
 *  que tiene almacenados el array con el que hasta ese momento
 *  es el máximo provisional. El valor inicial
 *  de este máximo provisional no debería ser cero
 *  (porque el resultado sería incorrecto
 *  si todos los números son negativos),
 *  sino el primer elemento del array.
 */
 using System;
 
 public class Ejercicio_4_1_3_11
 {
	 public static void Main()
	 {
		 int[] numeros = new int[4];
		 int numeroMayor = 0;
		 int i;
		 
		 Console.WriteLine("Escriba cuatro numeros para saber" +
		  " cuál es el mayor:");
		 for(i = 0; i < 4; i++)
		 {
			 numeros[i] = Convert.ToInt32(Console.ReadLine());
			 
			 if(i == 0)
			 {
				 numeroMayor = numeros[i];
			 }
			 else
			 {
				 if(numeroMayor < numeros[i])
				 {
					 numeroMayor = numeros[i];
				 }
			 }
		 }
		 
		 Console.WriteLine("El mayor es {0}", numeroMayor);
		
	 }
 }
