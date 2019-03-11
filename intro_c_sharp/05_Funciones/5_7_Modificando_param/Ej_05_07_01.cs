/*(5.7.1) Crea una función "Intercambiar", que intercambie el valor
 * de los dos números enteros que se le indiquen como parámetro.
 * Crea también un programa que la pruebe.
 */
 using System;
 
 public class Ejercicio_5_7_1
 {
	 //Función que intercambia dos números pasados por referencia
	 public static void Intercambiar(ref int numeroUno, ref int numeroDos)
	 {
		 int numeroAuxiliar;
		 
		 //intercambio:
		 numeroAuxiliar = numeroUno;
		 numeroUno = numeroDos;
		 numeroDos = numeroAuxiliar;
	 }
	 
	 public static void Main()
	 {
		 int numeroUno;
		 int numeroDos;
		 
		 //Pido los número al usuario:
		 Console.Write("Numero 1: ");
		 numeroUno = Convert.ToInt32(Console.ReadLine());
		 
		 Console.Write("Numero 2: ");
		 numeroDos = Convert.ToInt32(Console.ReadLine());
		 
		 //Intercambio los números
		 Console.WriteLine("Intercambio los números:");
		 
		 Intercambiar(ref numeroUno, ref numeroDos); //Paso los valores por ref
		 
		 //Muestro los números intercambiados:
		 Console.WriteLine("Numero 1: {0}", numeroUno);
		 Console.WriteLine("Numero 2: {0}", numeroDos);
		 			 
	 }
 }
