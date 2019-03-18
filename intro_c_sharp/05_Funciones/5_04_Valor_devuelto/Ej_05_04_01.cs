/*(5.4.1) Crea una función "Cubo" que calcule el cubo de un número real
 * (float) que se indique como parámetro. El resultado deberá ser otro
 * número real. Prueba esta función para calcular el cubo de 3.2
 * y el de 5.
 */
 using System;
 
 public class Ejercicio_5_4_1
 {
	 //Función que calcula el cubo de un número
	 public static float Cubo (float numero)
	 {
		 float cubo;
		 
		 //calculo el cubo
		 cubo = numero * numero * numero;
		 
		 return cubo;
	 }
	 
	 public static void Main()
	 {
		 float numeroUno = 3.2f;
		 float numeroDos = 5;
		 
		 //Utilizo la función para calcular el cubo
		 Console.WriteLine("El cubo de {0} es {1}", numeroUno,
		  Cubo(numeroUno));
		 Console.WriteLine("El cubo de {0} es {1}", numeroDos,
		  Cubo(numeroDos));
		 

	 }
 }
