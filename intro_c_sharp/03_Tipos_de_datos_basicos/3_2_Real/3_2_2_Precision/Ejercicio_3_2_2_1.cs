/*
 * (3.2.2.1) Crea un programa que muestre el resultado
 *  de dividir 13 entre 6 usando números enteros,
 *  luego usando números de coma flotante de simple precisión
 *  y luego con números de doble precisión.
 */
 using System;
 
 public class Ejercicio_3_2_2_1
 {
	 public static void Main()
	 {
		int i1 = 13;
		int i2 = 6;
		float f1 = 13;
		float f2 = 6;
		double d1 = 13;
		double d2 = 6; 
		
		int resultadoInt;
		float resultadoFloat;
		double resultadoDouble;
		 
		resultadoInt = i1 / i2;
		resultadoFloat = f1 / f2;
		resultadoDouble = d1 / d2;
		
		
		Console.WriteLine("El resultado en int es {0}", resultadoInt);
		Console.WriteLine("El resultado en float es {0}",
		 resultadoFloat);
		Console.WriteLine("El resultado en double es {0}",
		 resultadoDouble);
		 
	 }
 }
