/*
 * (3.2.2.2) Calcula el área de un círculo, dado su radio,
 *  que será un número entero (área = pi * radio al cuadrado)
 */
 using System;
 
 public class Ejercicio_3_2_2_2
 {
	 public static void Main()
	 {
		float area;
		float pi = 3.14f; //Agregar f al final al hacer la asignación
						  //directa de un float
		int radio;
		
		Console.Write("Ingrese el radio del circulo " +
		 "para calcular su area: ");
		radio = Convert.ToInt32(Console.ReadLine());
		
		area= pi * (radio * radio);
		
		Console.WriteLine("El area del circulo es {0}", area);
 
	 }
 }
