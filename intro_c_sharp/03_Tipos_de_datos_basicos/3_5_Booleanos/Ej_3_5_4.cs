/*
 *(3.5.4) Crea una versión alternativa del ejercicio 3.5.3,
 *  que use "if" en vez del operador condicional.
 */
 using System;
 
 public class Ejercicio_3_5_4
 {
	 public static void Main()
	 {
		 int numeroUno;
		 int numeroDos;
		 bool ambosPares;
		 
		 Console.WriteLine("Escriba dos numeros para compararlos: ");
		 
		 Console.Write("Escriba un numero: ");
		 numeroUno = Convert.ToInt32(Console.ReadLine());
		 
		 Console.Write("Escriba otro numero: ");
		 numeroDos = Convert.ToInt32(Console.ReadLine());
		 
		 //Condicion para que sea true
		 //utilizando if
		 if((numeroUno % 2 == 0) && (numeroDos % 2 == 0))
		 {
			 ambosPares = true;
		 }
		 else
		 {
			 ambosPares = false;
		 }
		 
		 
		 if(ambosPares) //si es true
		 {
			 Console.WriteLine("Ambos son pares.");			 
		 }
		 else
		 {
			 Console.WriteLine("Alguno es impar.");
		 }
		 
	 }
 }
