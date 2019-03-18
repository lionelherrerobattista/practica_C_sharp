/*(5.10.3) Crea un programa que emplee recursividad para calcular
 * un número de la serie Fibonacci (en la que
 * los dos primeros elementos valen 1, y para los restantes,
 * cada elemento es la suma de los dos anteriores).
 */
 using System;
 
 public class Ejercicio_5_10_3
 {
	 public static int Fibonacci(int numero)
	 {
		 int retorno;
		 
		 retorno = numero;
		 
		 if(numero <= 1)
		 {
			 retorno = 1;
		 }
		 else
		 {
			 
			 retorno = Fibonacci(numero - 1) +Fibonacci(numero -2);
		 }
		 
		 return retorno;
	 
	 }
	 
	 public static void Main()
	 {
		 Console.WriteLine(Fibonacci(11));	 
	 }
 }
