/*
 * (3.2.3.5) Crea un programa que muestre los primeros 20 valores
 *  de la función y = x2 - 1
 */
 using System;
 
 public class Ejercicio_3_2_3_5
 {
	 public static void Main()
	 {
		 double resultado;
		 int contador;
		 
		 Console.WriteLine("Primeros 20 valores" +
		 " de la función y = x^2 - 1:");
		 Console.WriteLine("------------------------------------------"+
		 "-----");
		 for(contador = 1; contador <= 20; contador++)
		 {
			 resultado = (contador * contador) - 1;
			 Console.WriteLine("y{0} = {1}",contador, resultado);		 
		 }
		 
		 
		 
	 }
 }
