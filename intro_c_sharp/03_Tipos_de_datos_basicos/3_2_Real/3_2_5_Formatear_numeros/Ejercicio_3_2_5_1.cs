/*
 * El usuario de nuestro programa podrá teclear dos números
 *  de hasta 12 cifras significativas. El programa deberá mostrar
 *  el resultado de dividir el primer número entre el segundo,
 *  utilizando tres cifras decimales.
 */
 using System;
 
 public class Ejercicio_3_2_5_1
 {
	 public static void Main()
	 {
		 double numeroUno;
		 double numeroDos;
		 
		 double resultado;
		 
		 Console.Write("Escriba un numero: ");
		 numeroUno = Convert.ToDouble(Console.ReadLine());
		 
		 Console.Write("Escriba otro numero: ");
		 numeroDos = Convert.ToDouble(Console.ReadLine());
		 
		 resultado = numeroUno / numeroDos;
		 
		 Console.WriteLine("El resultado es {0}",resultado.ToString("N3"));
		 
	 }
	 
 }
