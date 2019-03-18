/*(5.4.2) Crea una función "Menor" que calcule el menor
 * de dos números enteros que recibirá como parámetros.
 * El resultado será otro número entero.
 */
 using System;
 
 public class Ejercicio_5_4_2
 {
	 //Función que calcular el menor de dos números enteros
	 public static int Menor(int numeroUno, int numeroDos)
	 {
		 int menor;//variable que voy a devolver
		 
		 //coparo los número
		 if(numeroUno < numeroDos)
		 {
			 menor = numeroUno;
		 }
		 else
		 {
			 menor = numeroDos;
		 }
		 
		 return menor;
	 }
	 
	 public static void Main()
	 {
		 int numeroUno;
		 int numeroDos;
		 int numeroMenor;
		 
		 
		 //Pido dos números al ususario:
		 Console.Write("Escriba un número: ");
		 numeroUno = Convert.ToInt32(Console.ReadLine());
		 
		 Console.Write("Escriba otro número: ");
		 numeroDos = Convert.ToInt32(Console.ReadLine());
		 
		 //Calculo el menor y lo muestro:
		 numeroMenor = Menor(numeroUno, numeroDos);
		 
		 Console.WriteLine("El menor es: {0}", numeroMenor);
		 
	 }
 }
 
