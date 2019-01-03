/*
 * (3.2.1.1) Crea un programa que muestre el resultado
 *  de dividir 3 entre 4 usando números enteros
 *  y luego usando números de coma flotante.
 */
 using System;
 
 public class Ejercicio_3_2_1_1
 {
	 public static void Main()
	 {
		 float resultadoFloat;
		 float resultadoInt;
		 
		 int n1 = 3;
		 int n2 = 4;
		 
		 float f1 = 3;
		 float f2 = 4;
		 
		 resultadoFloat = f1 / f2; //Muestra con decimales (numeros reales)
		 
		 Console.WriteLine("El resultado con float es: {0}",
		  resultadoFloat);
		 
		 resultadoInt = n1 / n2; // Solo muestra la parte entra 
		 Console.WriteLine("El resultado con int es: {0}",
		  resultadoInt);
	 }
	 
 }

