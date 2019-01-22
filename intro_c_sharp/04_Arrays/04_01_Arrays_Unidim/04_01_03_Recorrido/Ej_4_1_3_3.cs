/*(4.1.3.3) Un programa que pida al usuario 10 reales
 *  de doble precisión, calcule su media y luego muestre
 *  los que están por encima de la media.
 */
 using System;
 
 public class Ejercicio_4_1_3_3
 {
	 public static void Main()
	 {
		 double[] numeros = new double[10];
		 double promedio;
		 double acumulador = 0;
		 byte i;
		 
		 Console.WriteLine("Ingrese 10 numeros de doble precisión:");
		 //Pido los 10 numeros
		 for(i = 0; i < 10; i++)
		 {
			 Console.Write("Numero {0}: ", i+1);
			 numeros[i] = Convert.ToDouble(Console.ReadLine());
			 acumulador += numeros[i];
		 }
		 
		 //Calculo el promedio
		 promedio = (double)acumulador / 10;
		 
		 Console.WriteLine("La media es {0}", promedio);
		 
		 Console.WriteLine("Los numeros que estan por encima" +
		  " de la media son:");
		 //Muestro los numeros por encima de la media
		 for(i = 0; i < 10; i++)
		 {
			 if(numeros[i] > promedio)
			 {
				 Console.Write("{0} ", numeros[i]);
			 }
			 
		 }
		 
	 }
 }
