/*(4.1.3.1) Crea un programa que pida al usuario 6 números enteros
 * cortos y luego los muestre en orden inverso (pista: usa un array
 * para almacenarlos y "for" para mostrarlos).
 */
 using System;
 
 public class Ejercicio_4_1_3_1
 {
	 public static void Main()
	 {
		 short[] numeros = new short[6];
		 int contador;
		 
		 Console.WriteLine("Escriba 6 numeros: ");
		 for(contador = 0; contador < 6; contador++)
		 {
			 Console.Write("Numero {0}: ", contador+1);
			 numeros[contador] = Convert.ToInt16(Console.ReadLine());
		 }
		 Console.WriteLine();
		 Console.WriteLine("Los numeros ingresados" +
		  " en sentido inverso son:");
		 
		 for(contador = 5; contador >= 0; contador--)
		 {
			 Console.WriteLine("{0}", numeros[contador]);
		 }
		 
	 }
 }
