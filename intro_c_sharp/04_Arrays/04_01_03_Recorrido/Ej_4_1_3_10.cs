/*(4.1.3.10) Un programa que reserve espacio para dos vectores
 *  de 3 componentes, pida al usuario sus valores
 *  y calcule su producto escalar (x1·y1+ x2·y2+x3·y3).
 */
 using System;
 
 public class Ejercicio_4_1_3_10
 {
	 public static void Main()
	 {
		 int[] vectorUno = new int[3];
		 int[] vectorDos = new int[3];
		 int productoEscalar = 0;
		 int i;

		 Console.WriteLine("Ingrese los 3 componentes" +
		  " del primer vector:"); 
		 for(i = 0; i < 3; i++)
		 {
			 vectorUno[i] = Convert.ToInt32(Console.ReadLine());

		 }
		 
		 Console.WriteLine();
		 Console.WriteLine("Ingrese los 3 componentes" +
		  " del segundo vector:");
		 for(i = 0; i < 3; i++)
		 {
			 vectorDos[i] = Convert.ToInt32(Console.ReadLine());

		 }
		 
		 //Calculo el producto escalar de los componentes
		 for(i = 0; i < 3; i++)
		 {
			 productoEscalar += (vectorUno[i] * vectorDos[i]);
		 }
		 
		 
		 Console.WriteLine("-----------------------------------------");
		 Console.WriteLine("El producto escalar de los vectores es {0}",
		  productoEscalar);

	 }
 }
