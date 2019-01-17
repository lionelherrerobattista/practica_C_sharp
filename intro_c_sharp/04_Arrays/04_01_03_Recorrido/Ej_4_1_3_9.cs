/*(4.1.3.9) Un programa que reserve espacio para dos vectores
 *  de 3 componentes, pida al usuario sus valores
 *  y calcule la suma de ambos vectores
 *  (su primera componente será x1+y1,
 *  la segunda será x2+y2 y así sucesivamente).
 */
 using System;
 
 public class Ejercicio_4_1_2_9
 {
	 public static void Main()
	 {
		 int[] vectorUno = new int[3];
		 int[] vectorDos = new int[3];
		 int[] vectorResultado = new int[3];
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
		 
		 //Sumo los componentes
		 for(i = 0; i < 3; i++)
		 {
			 vectorResultado[i] = vectorUno[i] + vectorDos[i];
		 }
		 
		 Console.WriteLine("-----------------------------------------");
		 Console.WriteLine("El resultado de la suma " +
		  "de los vectores es:");
		 //Muestro el resultado
		 for(i = 0; i < 3; i++)
		 {
			 Console.WriteLine(vectorResultado[i]);
		 }
	 }
 }
